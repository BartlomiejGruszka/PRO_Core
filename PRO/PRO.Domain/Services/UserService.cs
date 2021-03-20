using Microsoft.AspNetCore.Http;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRO.Domain.Services
{
    class UserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int GetLoggedInUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<int>(); // Specify the type of your UserId;
            return userId;
        }
    }
}
