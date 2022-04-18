using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {

        public AuthorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public new IEnumerable<Author> GetAll()
        {
            var users = _dbContext.Authors
               .Include(o => o.User)
               .ToList();
            return users;
        }
        public new Author Find(int? id)
        {
            return _dbContext.Authors.Include(i=>i.User).SingleOrDefault(u => u.UserId == id);
        }

    }
}
