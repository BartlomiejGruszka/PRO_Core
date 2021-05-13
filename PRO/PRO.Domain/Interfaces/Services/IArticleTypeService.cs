using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;

using System.Collections.Generic;


namespace PRO.Domain.Interfaces.Services
{
    public interface IArticleTypeService
    {
        public IEnumerable<ArticleType> GetAll();
        public ArticleType Find(int? id);
        public void Add(ArticleType articleType);
        public void Delete(ArticleType articleType);

        public void Update(ArticleType articleType);

        public ModelStateDictionary ValidateArticleType(ArticleType articleType);
    }
}
