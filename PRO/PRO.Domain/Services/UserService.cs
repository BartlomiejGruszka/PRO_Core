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

        public void YourMethodName()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<string>(); // Specify the type of your UserId;
        }
    }
}
