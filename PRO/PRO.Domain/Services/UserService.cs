using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            return  _userManager.DeleteAsync(user);
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
            user.Description = editUser.Description;
            user.IsActive = editUser.IsActive;
            user.IsPublic = editUser.IsPublic;
            user.ImageId = editUser.ImageId;
            return _userManager.UpdateAsync(user);
        }

        public Task<IdentityResult> ChangePasswordAsync(ApplicationUser user,string oldpassword, string newpassword )
        {
            return  _userManager.ChangePasswordAsync(user, oldpassword,newpassword);
        }
        public Task<string> ResetTokenAsync(ApplicationUser user)
        {
            return _userManager.GeneratePasswordResetTokenAsync(user);
        }
        public Task<IdentityResult> ResetPasswordAsync(ApplicationUser user, string newpassword)
        {
            string token =  ResetTokenAsync(user).Result;
            return _userManager.ResetPasswordAsync(user, token, newpassword);
        }

        public Task<IdentityResult> AddUserAsync(ApplicationUser user, string password)
        {
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
            return  _userManager.IsInRoleAsync(user, role);
        }
    }
}
