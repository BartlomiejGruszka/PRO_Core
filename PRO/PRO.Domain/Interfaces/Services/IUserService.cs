using Microsoft.AspNetCore.Identity;
using PRO.Domain.HelperClasses;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IUserService
    {
        public IEnumerable<ApplicationUser> GetAll();
        public ApplicationUser Find(int? id);
        public ApplicationUser FindActive(int? id);
        public void Add(ApplicationUser user);
        public Task<IdentityResult> Delete(ApplicationUser user);

        public Task<IdentityResult> Update(ApplicationUser user);
        public int? GetLoggedInUserId();
        public Task<IdentityResult> ChangePasswordAsync(ApplicationUser user, string oldpassword, string newpassword);
        public Task<IdentityResult> ResetPasswordAsync(ApplicationUser user, string newpassword);
        public Task<string> ResetTokenAsync(ApplicationUser user);
        public Task<IdentityResult> AddUserAsync(ApplicationUser user, string password);
        public Task<IdentityResult> AddRoleToUserAsync(ApplicationUser user, string role);
        public Task<IdentityResult> DeleteRoleFromUserAsync(ApplicationUser user, string role);

        public Task<bool> IsUserInRole(ApplicationUser user, string role);
        IQueryable<ApplicationUser> FilterSearch(string query);
        IQueryable<ApplicationUser> SortList(string sortOrder, IQueryable<ApplicationUser> users);
        List<UserIdNames> GetUserIdNamesList(IEnumerable<ApplicationUser> list);
    }
}
