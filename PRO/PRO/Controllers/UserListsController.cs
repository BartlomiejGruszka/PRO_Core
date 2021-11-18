using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Extensions;
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
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {        
            ViewData["AddDateSortParm"] = String.IsNullOrEmpty(sortOrder) ? "adddate_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            ViewData["UserSortParm"] = sortOrder == "user" ? "user_desc" : "user";
            ViewData["TypeSortParm"] = sortOrder == "type" ? "type_desc" : "type";
            var userlists = _userListService.FilterSearch(currentFilter);
            userlists = _userListService.SortList(sortOrder, userlists);

            var result = PaginatedList<UserList>.Create(userlists.AsNoTracking(), page, items);

            result.Pagination.Configure("manage", currentFilter, sortOrder);
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

            ViewBag.usersList = _userService.GetUserIdNamesList(null);
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

            ViewBag.usersList = _userService.GetUserIdNamesList(null);
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

            ViewBag.usersList = _userService.GetUserIdNamesList(null);
            ViewBag.typesList = _listTypeService.GetAll().ToList();
            return View(userList);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Moderator")]
        [Route("userlists/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserList userList)
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
            ViewBag.usersList = _userService.GetUserIdNamesList(null);
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

        [Authorize]
        [HttpPost]
        [Route("userlists/useredit")]
        [ValidateAntiForgeryToken]
        public ActionResult UserEdit(UserList model)
        {
            var previouspage = HttpContext.Request.Headers["Referer"];
            TempData.Put("userList", model);

            var errors = _userListService.ValidateUserList(model);
            ModelState.Merge(errors);
            if (ModelState.IsValid)
            {
                _userListService.AddOrUpdate(model);
                TempData.Clear();
                return RedirectToAction("UserLists", "Users");
            }
 
            return Redirect(previouspage);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize]
        [Route("userlists/userdelete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult UserDelete(int id)
        {
            if (!_userListService.UserDelete(id))
            {
                return NotFound();
            }
            return RedirectToAction("UserLists", "Users");
        }

    }
}
