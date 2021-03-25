using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    class ArticleService : IArticleService
    {
        private readonly IRepository<Article> _repository;
        public ArticleService(IRepository<Article> repository)
        {
            _repository = repository;
        }

        public void Add(Article award)
        {
            _repository.Add(award);
            _repository.Save();
        }

        public void Delete(Article award)
        {
            _repository.Remove(award);
            _repository.Save();
        }

        public Article Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Article> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Article award)
        {
            _repository.Update(award);
            _repository.Save();
        }
        public IEnumerable<Article> GetAllActive()
        {
            return _repository.GetAll();//
        }
    }
}
