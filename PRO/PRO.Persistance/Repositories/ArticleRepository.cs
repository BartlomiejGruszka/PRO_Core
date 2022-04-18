using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Persistance.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
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
            var articles = _dbContext.Articles
             .Include(i => i.Image)
             .Include(i => i.Author)
             .Include(i => i.ArticleType)
             .Include(i => i.Game)
             .Include(i => i.Game.Platform)
             .OrderByDescending(d => d.PublishedDate);
            return articles;
        }

        
    }
}
