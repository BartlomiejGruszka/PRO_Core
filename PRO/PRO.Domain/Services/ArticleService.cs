using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class ArticleService : IArticleService
    {

        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void Add(Article article, int? userid)
        {
            article.UserId = userid.Value;
            article.PublishedDate = System.DateTime.Now;
            _articleRepository.Add(article);
            _articleRepository.Save();
        }

        public void Delete(Article article)
        {
            _articleRepository.Remove(article);
            _articleRepository.Save();
        }

        public Article Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _articleRepository.Find(id.Value);
        }
        public Article FindActive(int? id)
        {
            var article = Find(id);
            if (article == null) {return null; }
            if (article.IsActive == false) { return null; }
            return article;
        }

        public IEnumerable<Article> GetAll()
        {
            return _articleRepository.GetAll();
        }

        public void Update(Article article)
        {
            _articleRepository.Update(article);
            _articleRepository.Save();
        }
        public List<Article> GetAllActive()
        {
            return _articleRepository.GetAll().Where(i=>i.IsActive==true).ToList();
        }
        public IEnumerable<Article> GetAllByPlatform(string platform)
        {
            return _articleRepository.GetAll().Where(i=>i.Game.Platform.Name.Contains(platform)).ToList();
        }

        public IEnumerable<Article> ArticlesByPlatform(string platform)
        {
            IEnumerable<Article> articlesList = new List<Article>();
            IEnumerable<Article> otherArticles = new List<Article>();
            if (platform == null || platform == "all")
            {
                articlesList = GetAllActive();
            }
            else if (platform == "other")
            {
                otherArticles = GetAllActive(); ;
                articlesList = otherArticles
                .Where(i =>
                          !i.Game.Platform.Name.Contains("PC")
                        & !i.Game.Platform.Name.Contains("Playstation")
                        & !i.Game.Platform.Name.Contains("Xbox")
                        & !i.Game.Platform.Name.Contains("Switch"))
                .OrderByDescending(d => d.PublishedDate)
                .ToList();

            }
            else
            {
                articlesList = GetAllByPlatform(platform);
            }
            return articlesList.ToList();
        }

        public IEnumerable<Article> SearchResultArticles(IEnumerable<Article> list, string query)
        {
            IEnumerable<Article> searchList = new List<Article>();
            if(list == null ) list = GetAllActive();
            searchList = list.Where(a =>
            a.Title.ToLower().Contains(query.ToLower()) ||
            a.Preview.ToLower().Contains(query.ToLower()) ||
            a.Content.ToLower().Contains(query.ToLower()) ||
            a.Game.Title.ToLower().Contains(query.ToLower())
            ).ToList();
            return searchList;

        }

        public IEnumerable<Article> GetAllForAuthor(string query, int? id)
        {
            var articlesList = GetAll()
                    .Where(s => s.Author.UserId == id.Value);

            if (string.IsNullOrEmpty(query)) return articlesList;
            return SearchResultArticles(articlesList, query);
        }


        public IEnumerable<Article> GetAllForAdmin(string query)
        {
            var articlesList = GetAll();
            if (string.IsNullOrEmpty(query)) return articlesList;
            return SearchResultArticles(articlesList, query);
        }

        public IQueryable<Article> SortList(string sortOrder, IQueryable<Article> articlesList)
        {
            articlesList = sortOrder switch
            {
                "title_desc" => articlesList.OrderByDescending(s => s.Title),
                "" => articlesList.OrderBy(s => s.Title),
                "date_desc" => articlesList.OrderByDescending(s => s.PublishedDate),
                "Date" => articlesList.OrderBy(s => s.PublishedDate),
                "game_desc" => articlesList.OrderByDescending(s => s.Game.Title),
                "Game" => articlesList.OrderBy(s => s.Game.Title),
                _ => articlesList.OrderByDescending(s => s.PublishedDate),
            };
            return articlesList.AsQueryable();
        }
    }
}
