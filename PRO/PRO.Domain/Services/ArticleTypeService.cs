using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class ArticleTypeService :IArticleTypeService
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

        public IQueryable<ArticleType> FilterSearch(string query)
        {
            var articleTypes = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                articleTypes = articleTypes.Where(s => s.Name.ToLower().Contains(query.ToLower()));
            }
            return articleTypes;
        }

        public ArticleType Find(int? id)
        {
            if (!id.HasValue) return null;
            return _repository.Find(id.Value);
        }

        public IEnumerable<ArticleType> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<ArticleType> SortList(string sortOrder, IQueryable<ArticleType> articleTypes)
        {
            articleTypes = sortOrder switch
            {
                "name_desc" => articleTypes.OrderByDescending(s => s.Name),
                "" => articleTypes.OrderBy(s => s.Name),
                _ => articleTypes.OrderBy(s => s.Name),
            };
            return articleTypes.AsQueryable();
        }

        public void Update(ArticleType imageType)
        {
            _repository.Update(imageType);
            _repository.Save();
        }

        public ModelStateDictionary ValidateArticleType(ArticleType articleType)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (articleType == null) return errors;

            var articleTypes = _repository.GetAll().Where(i => i.Name == articleType.Name && i.Id != articleType.Id);

            if (articleTypes.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już rodzaj artykułu o takiej nazwie.");
            }
            return errors;
        }
    }
}
