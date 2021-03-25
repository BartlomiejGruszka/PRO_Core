using Microsoft.EntityFrameworkCore;
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

        public new Article Find(int? id)
        {
            if (!id.HasValue) return null;
            Article article = _dbContext.Articles
                .Include(a => a.Game)
                .Include(a => a.Game.Tags)
                .Include(a => a.Author)
                .Include(a => a.ArticleType)
                .Include(a => a.Image)
                .SingleOrDefault(a => a.Id == id);
            return article;
        }



        public new IEnumerable<Article> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
