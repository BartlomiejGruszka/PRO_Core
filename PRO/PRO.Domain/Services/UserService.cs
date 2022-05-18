using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRO.Domain.Extensions;

namespace PRO.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;
        public UserService(
            UserManager<ApplicationUser> userManager,
            IUserRepository userRepository,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public void Add(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> Delete(ApplicationUser user)
        {
            return _userManager.DeleteAsync(user);
        }

        public ApplicationUser Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _userRepository.Find(id.Value);
        }

        public ApplicationUser FindActive(int? id)
        {
            ApplicationUser user = Find(id);
            if (user == null) { return null; }
            if (!user.IsActive) { return null; }
            return user;
        }


        public IEnumerable<ApplicationUser> GetAll()
        {
            return _userRepository.GetAll();
        }

        public int? GetLoggedInUserId()
        {
            int? userId = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<int>();
            return userId;
        }


        public Task<IdentityResult> Update(ApplicationUser editUser)
        {
            var user = Find(editUser.Id);
            user.Email = editUser.Email;
            user.UserName = editUser.UserName;
            user.RegisterDate = editUser.RegisterDate;
            user.EditDate = DateTime.Now;
            user.Description = editUser.Description;
            user.IsActive = editUser.IsActive;
            user.IsPublic = editUser.IsPublic;
            if (editUser.ImageId == null || editUser.ImageId <= 0)
            {
                user.ImageId = null;
            }
            else
            {
                user.ImageId = editUser.ImageId;
            }
            return _userManager.UpdateAsync(user);
        }

        public Task<IdentityResult> ChangePasswordAsync(ApplicationUser user, string oldpassword, string newpassword)
        {
            return _userManager.ChangePasswordAsync(user, oldpassword, newpassword);
        }
        public Task<string> ResetTokenAsync(ApplicationUser user)
        {
            return _userManager.GeneratePasswordResetTokenAsync(user);
        }
        public Task<IdentityResult> ResetPasswordAsync(ApplicationUser user, string newpassword)
        {
            string token = ResetTokenAsync(user).Result;
            return _userManager.ResetPasswordAsync(user, token, newpassword);
        }

        public Task<IdentityResult> AddUserAsync(ApplicationUser user, string password)
        {
            if (user.ImageId == 0) user.ImageId = null;
            return _userManager.CreateAsync(user, password);
        }

        public Task<IdentityResult> AddRoleToUserAsync(ApplicationUser user, string role)
        {
            return _userManager.AddToRoleAsync(user, role);
        }

        public Task<IdentityResult> DeleteRoleFromUserAsync(ApplicationUser user, string role)
        {
            return _userManager.RemoveFromRoleAsync(user, role);
        }
        public Task<bool> IsUserInRole(ApplicationUser user, string role)
        {
            return _userManager.IsInRoleAsync(user, role);
        }

        public IQueryable<ApplicationUser> FilterSearch(string query)
        {
            var users = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                users = users.Where(s =>
                s.UserName.ToLower().Contains(query.ToLower()) ||
                s.Email.ToLower().Contains(query.ToLower())
                );
            }
            return users;
        }

        public IQueryable<ApplicationUser> SortList(string sortOrder, IQueryable<ApplicationUser> users)
        {
            users = sortOrder switch
            {
                "id_desc" => users.OrderByDescending(s => s.Id),
                "" => users.OrderBy(s => s.Id),
                "user_desc" => users.OrderByDescending(s => s.UserName),
                "user" => users.OrderBy(s => s.UserName),
                "email_desc" => users.OrderByDescending(s => s.Email),
                "email" => users.OrderBy(s => s.Email),
                "adddate_desc" => users.OrderByDescending(s => s.RegisterDate),
                "adddate" => users.OrderBy(s => s.RegisterDate),
                "editdate_desc" => users.OrderByDescending(s => s.EditDate),
                "editdate" => users.OrderBy(s => s.EditDate),
                _ => users.OrderBy(s => s.Id),
            };
            return users.AsQueryable();
        }

        public List<UserIdNames> GetUserIdNamesList(IEnumerable<ApplicationUser> list)
        {
            if (list == null) { list = GetAll(); }
            List<UserIdNames> users = new List<UserIdNames>();
            foreach (var item in list)
            {
                var user = new UserIdNames { Id = item.Id, UserName = item.UserName };
                users.Add(user);

            }
            return users;
        }
        public bool IsOwner(int? userid)
        {
            var loggeduserid = GetLoggedInUserId();
            if (!loggeduserid.HasValue || !userid.HasValue) return false;
            if (loggeduserid.Value != userid.Value) return false;
            return true;
        }

        public async Task<List<UserLoginInfo>> GetUserLoginsAsync(int? id)
        {
            var user = Find(id);
            if (user == null) return null;
            var CurrentLogins = await _userManager.GetLoginsAsync(user);
            return CurrentLogins.ToList();
        }
    }
}
