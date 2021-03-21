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
    public class ImageTypeRepository : BaseRepository<ImageType>, IImageTypeRepository
    {

        public ImageTypeRepository(ApplicationDbContext dbContext) : base(dbContext) { }
        
      
    }
}
