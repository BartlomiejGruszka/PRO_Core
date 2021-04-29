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

        public IEnumerable<Article> SearchResultArticles(string query)
        {
            IEnumerable<Article> searchList = new List<Article>();

            var articlesList = GetAllActive();
            searchList = articlesList.Where(a =>
            a.Title.ToLower().Contains(query) ||
            a.Preview.ToLower().Contains(query) ||
            a.Content.ToLower().Contains(query)
            ).ToList();
            return searchList;

        }
    }
}
