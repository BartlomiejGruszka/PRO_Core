﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

            var userlists = _userListService.GetAll();

            ViewBag.Pagination = new Pagination(page, items, userlists.Count());

            return View(userlists.ToList());
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
        public ActionResult Add([Bind("Id,CreatedDate,Name,IsPublic,UserId,ListTypeId")] UserList userList)
        {
            if (ModelState.IsValid)
            {
                 _userListService.Add(userList);
                return RedirectToAction("Manage");
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
        public ActionResult Edit([Bind("Id,CreatedDate,Name,IsPublic,UserId,ListTypeId")] UserList userList)
        {
            if (ModelState.IsValid)
            {
                _userListService.Update(userList);
                return RedirectToAction("Manage");
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
