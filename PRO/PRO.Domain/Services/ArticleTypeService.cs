using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class ArticleTypeService :IArticleTypeService
    {
        private readonly IRepository<ArticleType> _repository;
        public ArticleTypeService(IRepository<ArticleType> repository)
        {
            _repository = repository;
        }

        public void Add(ArticleType imageType)
        {
            _repository.Add(imageType);
            _repository.Save();
        }

        public void Delete(ArticleType imageType)
        {
            _repository.Remove(imageType);
            _repository.Save();
        }

        public ArticleType Find(int? id)
        {
            if (id.HasValue) return null;
            return _repository.Find(id.Value);
        }

        public IEnumerable<ArticleType> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(ArticleType imageType)
        {
            _repository.Update(imageType);
            _repository.Save();
        }
    }
}
