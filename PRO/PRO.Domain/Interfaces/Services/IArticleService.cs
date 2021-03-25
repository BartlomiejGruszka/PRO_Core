using PRO.Entities;

using System.Collections.Generic;


namespace PRO.Domain.Interfaces.Services
{
    public interface IArticleService
    {
        public IEnumerable<Article> GetAll();
        public Article Find(int? id);
        public void Add(Article article);
        public void Delete(Article article);

        public void Update(Article article);
        IEnumerable<Article> GetAllActive();
    }
}
