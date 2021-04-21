using Microsoft.AspNetCore.Http;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRO.Domain.Services
{
    class UserService :IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Add(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public void Delete(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Find(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public int? GetLoggedInUserId()
        {
            int? userId = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<int>();
            return userId;
        }

        public void Update(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
