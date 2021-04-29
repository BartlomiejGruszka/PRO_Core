using PRO.Entities;
using System.Collections.Generic;


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
        public IEnumerable<Article> GetAllByPlatform(string platform);
        public IEnumerable<Article> SearchResultArticles(string query);
        public IEnumerable<Article> ArticlesByPlatform(string platform);
    }
}
