using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Entities;

using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Interfaces.Services
{
    public interface IArticleTypeService
    {
        public IEnumerable<ArticleType> GetAll();
        public ArticleType Find(int? id);
        public void Add(ArticleType articleType);
        public void Delete(ArticleType articleType);

        public void Update(ArticleType articleType);
        public IQueryable<ArticleType> FilterSearch(string query);
        public IQueryable<ArticleType> SortList(string sortOrder, IQueryable<ArticleType> articleTypes);
        public ModelStateDictionary ValidateArticleType(ArticleType articleType);
    }
}
