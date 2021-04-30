﻿using Microsoft.AspNetCore.Identity;
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

    }
}
