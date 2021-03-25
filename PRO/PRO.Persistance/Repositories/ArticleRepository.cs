using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Persistance.Repositories
{
    class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void Add(Article newElement)
        {
            throw new NotImplementedException();
        }

        public Article Find(int? id)
        {
            if (!id.HasValue) return null;
            Article article = context.Articles
                .Include(a => a.Game)
                .Include(a => a.Game.Tags)
                .Include(a => a.Author)
                .Include(a => a.ArticleType)
                .Include(a => a.Image)
                .SingleOrDefault(a => a.Id == id);
            return article;
        }

        public IEnumerable<Article> Get(Func<Article, bool> wherePredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Article elementToRemove)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Article updatedElement)
        {
            throw new NotImplementedException();
        }
    }
}
