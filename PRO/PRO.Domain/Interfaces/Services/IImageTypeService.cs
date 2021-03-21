using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IImageTypeService
    {
        public IEnumerable<ImageType> GetAll();
        public ImageType Find(int id);
        public void Add(ImageType imageType);
        public void Delete(ImageType imageType);

        public void Update(ImageType imageType);
    }
}
