using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;

namespace PRO.Persistance.Repositories
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {

        public ImageRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public new IEnumerable<Image>GetAll()
        {
            return _dbContext.Images.Include(i => i.ImageType).ToList();
        }
        public void Delete(Image image)
        {
            var games = _dbContext.Games.Where(i => i.ImageId == image.Id).ToList();
            foreach (var element in games)
            {
                element.ImageId = null;
            };
            var articles = _dbContext.Articles.Where(i => i.ImageId == image.Id).ToList();
            foreach (var element in articles)
            {
                element.ImageId = null;
            };
            var users = _dbContext.ApplicationUsers.Where(i => i.ImageId == image.Id).ToList();
            foreach (var element in users)
            {
                element.ImageId = null;
            };

            _dbContext.Remove(image);
        }

        public new Image Find(int? id)
        {
            if (!id.HasValue) return null;
            return _dbContext.Images.Include(i => i.ImageType).SingleOrDefault(s=>s.Id == id.Value);
        }
        public void UpdateName(Image image)
        {
            var oldimage = Find(image.Id);
            oldimage.Name = image.Name;
            oldimage.ImageTypeId = image.ImageTypeId;
        }

        public void DetachOld(Image image)
        {
            _dbContext.Entry(image).State = EntityState.Detached;
        }
    }
}
