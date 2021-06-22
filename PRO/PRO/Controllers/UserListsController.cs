using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace PRO.Controllers
{
    [Authorize]
    public class UserListsController : Controller
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;
        private readonly IImageService _imageService;
        private readonly IUserListService _userListService;
        private readonly IListTypeService _listTypeService;
        public UserListsController
            (
            IUserService userService,
            IReviewService reviewService,
            IImageService imageService,
            IUserListService userListService,
            IListTypeService listTypeService
            )

        {
            _imageService = imageService;
            _userService = userService;
            _reviewService = reviewService;
            _userListService = userListService;
            _listTypeService = listTypeService;
        }
        // GET: UserLists
        [Route("userlists/manage")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Manage(int? page, int? items)
        {

            var userlists = _userListService.GetAll().AsQueryable();
            var result = PaginatedList<UserList>.Create(userlists.AsNoTracking(), page, items);

            result.Pagination.Action = "manage";
            return View(result);
        }

        // GET: UserLists/Details/5
        [Route("userlists/details/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Details(int? id)
        {
            UserList userList = _userListService.Find(id);
            if (userList == null)
            {
                return NotFound();
            }
            return View(userList);
        }

        // GET: UserLists/Create
        [Route("userlists/add")]
        [Authorize(Roles = "Admin")]
        public ActionResult Add()
        {
            var users = _userService.GetAll().ToList();

            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();
            ViewBag.typesList = _listTypeService.GetAll().ToList();
            return View();
        }

        [HttpPost]
        [Route("userlists/add")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(UserList userList)
        {
            if (ModelState.IsValid)
            {
                var errors = _userListService.ValidateUserList(userList);
                if (!errors.Any())
                {
                    _userListService.Add(userList);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            var users = _userService.GetAll().ToList();

            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();
            ViewBag.typesList = _listTypeService.GetAll().ToList();
            return View(userList);
        }

        // GET: UserLists/Edit/5
        [Route("userlists/edit/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Edit(int? id)
        {
            UserList userList = _userListService.Find(id);
            if (userList == null)
            {
                return NotFound();
            }
            var users = _userService.GetAll().ToList();

            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();
            ViewBag.typesList = _listTypeService.GetAll().ToList();
            return View(userList);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Moderator")]
        [Route("userlists/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( UserList userList)
        {
            if (ModelState.IsValid)
            {
                var errors = _userListService.ValidateUserList(userList);
                if (!errors.Any())
                {
                    _userListService.Update(userList);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            var users = _userService.GetAll().ToList();

            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();
            ViewBag.typesList = _listTypeService.GetAll().ToList();
            return View(userList);
        }

        // GET: UserLists/Delete/5
        [Route("userlists/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            UserList userList = _userListService.Find(id);
            if (userList == null)
            {
                return NotFound();
            }
            return View(userList);
        }

        // POST: UserLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [Route("userlists/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserList userList = _userListService.Find(id);
            _userListService.Delete(userList);
            return RedirectToAction("Manage");
        }

    }
}
