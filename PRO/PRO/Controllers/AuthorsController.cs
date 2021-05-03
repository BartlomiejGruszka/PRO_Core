using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;

namespace PRO.Controllers
{
    [Authorize]
    public class AuthorsController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IUserService _userService;
        public AuthorsController(IUserService userService, IAuthorService authorService)
        {
            _authorService = authorService;
            _userService = userService;
        }

        // GET: Authors
        [Route("authors/manage")]
        public ActionResult Manage(int? page, int? items)
        {

            var authors = _authorService.GetAll();

            ViewBag.Pagination = new Pagination(page, items, authors.Count());
            return View(authors);
        }

        // GET: Authors/Details/5
        [Route("authors/details/{id}")]
        public ActionResult Details(int? id)
        {
            Author author = _authorService.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // GET: Authors/Create
        [Route("authors/add")]
        public ActionResult Add()
        {

            var users = _userService.GetAll();
            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();

            return View();
        }

        [HttpPost]
        [Route("authors/add")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddAsync([Bind("UserId,FirstName,LastName,CreatedDate,isActive")] Author author)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(author.UserId);

                if (author.IsActive)
                {
                    var result = await _userService.AddRoleToUserAsync(user, "Author");

                }
                _authorService.Add(author);

                return RedirectToAction("Manage");
            }

            var users = _userService.GetAll();
            ViewBag.usersList = users.Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();

            return View(author);
        }

        // GET: Authors/Edit/5
        [Route("authors/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            Author author = _authorService.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        [HttpPost]
        [Route("authors/edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync([Bind("UserId,FirstName,LastName,CreatedDate")] Author author)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(author.UserId);
                if (user == null) return NotFound();

                var isAuthor = await _userService.IsUserInRole(user, "Author");
                IdentityResult result = null;

                if (isAuthor && !author.IsActive)
                {
                    result = await _userService.DeleteRoleFromUserAsync(user, "Author");
                };
                if (!isAuthor && author.IsActive)
                {
                    result = await _userService.AddRoleToUserAsync(user, "Author");
                }
                _authorService.Update(author);
                return RedirectToAction("Manage");
            }
            return View(author);
        }

        // GET: Authors/Delete/5
        [Route("authors/delete/{id}")]
        public ActionResult Delete(int? id)
        {
            Author author = _authorService.Find(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("authors/delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(int id)
        {
            Author author = _authorService.Find(id);

            var isAuthor = await _userService.IsUserInRole(author.User, "Author");

            if (isAuthor)
            {
                var result = await _userService.DeleteRoleFromUserAsync(author.User, "Author");
            };
            _authorService.Delete(author);
            return RedirectToAction("Manage");

        }
    }
}
