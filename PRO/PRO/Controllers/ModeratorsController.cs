﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PRO.Controllers
{
    public class ModeratorsController : Controller
    {
        private readonly IModeratorService _moderatorService;
        private readonly IUserService _userService;
        public ModeratorsController(IUserService userService, IModeratorService moderatorService)
        {
            _moderatorService = moderatorService;
            _userService = userService;
        }

        // GET: Moderators
        [Route("moderators/manage")]
        public ActionResult Manage(int? page, int? items)
        {

            var moderators = _moderatorService.GetAll().AsQueryable();
            return View(PaginatedList<Moderator>.Create(moderators.AsNoTracking(), page, items));
        }

        // GET: Moderators/Details/5
        [Route("moderators/details/{id}")]
        public ActionResult Details(int? id)
        {
            Moderator moderator = _moderatorService.Find(id);
            if (moderator == null)
            {
                return NotFound();
            }
            return View(moderator);
        }

        // GET: Moderators/Create
        [Route("moderators/add")]
        public ActionResult Add()
        {
            var users = _userService.GetAll().Where(s=>s.Moderator==null).ToList();
            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();

            return View();
        }

        // POST: Moderators/Create
        [HttpPost]
        [Route("moderators/add")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddAsync([Bind("UserId,CreatedDate,IsActive")] Moderator moderator)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(moderator.UserId);

                if (moderator.IsActive)
                {
                    var result = await _userService.AddRoleToUserAsync(user, "Moderator");
                    if (!result.Succeeded)
                    {
                        return RedirectToAction("Add");
                    }
                }
                _moderatorService.Add(moderator);
                return RedirectToAction("Manage");
            }

            var users = _userService.GetAll().Where(s=>s.Moderator==null).ToList();
            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();

            return View(moderator);
        }

        // GET: Moderators/Edit/5
        [Route("moderators/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            Moderator moderator = _moderatorService.Find(id);
            if (moderator == null)
            {
                return NotFound();
            }
            return View(moderator);
        }

        // POST: Moderators/Edit/5
        [HttpPost]
        [Route("moderators/edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("UserId,CreatedDate,IsActive")] Moderator moderator)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(moderator.UserId); 
                if (user == null) return NotFound();

                var isModerator = await _userService.IsUserInRole(user, "Moderator");
                IdentityResult result = null;

                if (isModerator && !moderator.IsActive)
                {
                    result = await _userService.DeleteRoleFromUserAsync(user, "Moderator");
                };
                if (!isModerator && moderator.IsActive)
                {
                    result = await _userService.AddRoleToUserAsync(user, "Moderator");
                }
                _moderatorService.Update(moderator);
                return RedirectToAction("Manage");
            }
            return View(moderator);
        }

        // GET: Moderators/Delete/5
        [Route("moderators/delete/{id}")]
        public ActionResult Delete(int? id)
        {
            Moderator moderator = _moderatorService.Find(id);
            if (moderator == null)
            {
                return NotFound();
            }
            return View(moderator);
        }

        // POST: Moderators/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("moderators/delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(int id)
        {
            Moderator moderator = _moderatorService.Find(id);

            if (moderator.IsActive)
            {
                var result = await _userService.DeleteRoleFromUserAsync(moderator.User, "Moderator");
                if (!result.Succeeded) {
                    return RedirectToAction("Delete", new { Id = moderator.UserId }); 
                }
            };

            _moderatorService.Delete(moderator);
            return RedirectToAction("Manage");
        }
    }
}
