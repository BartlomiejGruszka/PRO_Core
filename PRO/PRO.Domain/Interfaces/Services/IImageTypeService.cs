using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IImageTypeService
    {
        public IEnumerable<ImageType> GetAll();
        public ImageType Find(int? id);
        public void Add(ImageType imageType);
        public void Delete(ImageType imageType);
        public IEnumerable<ImageType> GetByType(ImageTypes type);

        public void Update(ImageType imageType);
        public ModelStateDictionary ValidateImageType(ImageType imageType);
        IQueryable<ImageType> FilterSearch(string query);
        IQueryable<ImageType> SortList(string sortOrder, IQueryable<ImageType> imageTypes);
    }
}
