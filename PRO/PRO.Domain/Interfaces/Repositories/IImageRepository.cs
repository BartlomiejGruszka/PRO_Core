using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRO.Domain.Interfaces.Repositories
{
   public interface IImageRepository : IRepository<Image>
    {
        public new IEnumerable<Image> GetAll();
        public new Image Find(int id);
        public void Delete(Image image);
        public void UpdateName(Image image);
        public void DetachOld(Image image);
    }
}
