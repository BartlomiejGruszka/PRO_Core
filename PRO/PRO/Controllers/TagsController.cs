using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class TagsController : Controller
    {

        private readonly ITagService _tagService;
        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        // GET: Tags
        [Route("tags/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            var tags = _tagService.FilterSearch(currentFilter);
            tags = _tagService.SortList(sortOrder, tags);
            var result = PaginatedList<Tag>.Create(tags.AsNoTracking(), page, items);

            result.Pagination.Configure("manage", currentFilter, sortOrder);
            return View(result);
        }

        // GET: Tags/Details/5
        [Route("tags/details/{id}")]
        public ActionResult Details(int? id)
        {
            Tag tag = _tagService.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // GET: Tags/Create
        [Route("tags/add")]
        public ActionResult Add()
        {
            ViewBag.returnUrl = HttpContext.Request.Headers["Referer"];
            return View();
        }

        // POST: Tags/Create
        [HttpPost]
        [Route("tags/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Tag tag, string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var errors = _tagService.ValidateTag(tag);
                if (!errors.Any())
                {
                    _tagService.Add(tag);
                    if (returnUrl != null) { return Redirect(returnUrl); }
                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            return View(tag);
        }

        // GET: Tags/Edit/5
        [Route("tags/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            Tag tag = _tagService.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // POST: Tags/Edit/5
        [HttpPost]
        [Route("tags/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tag tag)
        {
            if (ModelState.IsValid)
            {
                var errors = _tagService.ValidateTag(tag);
                if (!errors.Any())
                {
                    _tagService.Update(tag);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(tag);
        }

        [Authorize(Roles = "Admin")]
        [Route("tags/delete/{id}")]
        public ActionResult Delete(int? id)
        {

            Tag tag = _tagService.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [Route("tags/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tag tag = _tagService.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            _tagService.Delete(tag);
            return RedirectToAction("Manage");
        }
    }
}
