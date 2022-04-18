using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IModeratorService
    {
        public IEnumerable<Moderator> GetAll();
        public Moderator Find(int? id);
        public void Add(Moderator moderator);
        public void Delete(Moderator moderator);

        public void Update(Moderator moderator);
        IQueryable<Moderator> FilterSearch(string query);
        IQueryable<Moderator> SortList(string sortOrder, IQueryable<Moderator> moderators);
    }
}
