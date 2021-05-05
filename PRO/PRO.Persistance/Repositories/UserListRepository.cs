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
    public class UserListRepository : BaseRepository<UserList>, IUserListRepository
    {

        public UserListRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public new UserList Find(int? id)
        {
            if (!id.HasValue) return null;
            var userlist = _dbContext.UserLists
                .Include(m => m.User)
                .Include(a => a.ListType)
                .SingleOrDefault(r => r.Id == id.Value);
            return userlist;
        }
        public IEnumerable<UserList> GetUserUserLists(int? userId)
        {
            if (!userId.HasValue) return null;
            var userlists = _dbContext.UserLists
                .Include(m => m.User)
                .Include(a => a.ListType)
                .Where(r => r.UserId == userId.Value)
                .ToList();
            return userlists;
        }
        public new IEnumerable<UserList> GetAll()
        {
            var userlists = _dbContext.UserLists
            .Include(m => m.User)
            .Include(a => a.ListType)
            .ToList();
            return userlists;
        }

    }
}
