using PRO.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Interfaces.Services
{
    public interface IArticleService
    {
        public IEnumerable<Article> GetAll();
        public Article Find(int? id);
        public Article FindActive(int? id);
        public void Add(Article article, int? userid);
        public void Delete(Article article);
        public void Update(Article article);
        List<Article> GetAllActive();
        public IEnumerable<Article> GetRecentlyReleased();
        public IEnumerable<Article> GetAllByPlatform(string platform);
        public IEnumerable<Article> SearchResultArticles(IEnumerable<Article> list,string query);
        public IEnumerable<Article> ArticlesByPlatform(string platform);
        public IEnumerable<Article> GetAllForAuthor(string query, int? id);
        public IEnumerable<Article> GetAllForAdmin(string query);
        public IQueryable<Article> SortList(string sortOrder, IQueryable<Article> articlesList);
    }
}
