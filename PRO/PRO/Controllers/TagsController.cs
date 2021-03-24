using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using PRO.Models;

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
        public ActionResult Manage()
        {
           // var pageString = Request.QueryString["page"];
            //var itemString = Request.QueryString["items"];
            var tags = _tagService.GetAll();
            ViewBag.Pagination = new Pagination(null, null, tags.Count());
            return View(tags);
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
            return View();
        }

        // POST: Tags/Create
        [HttpPost]
        [Route("tags/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _tagService.Add(tag);
                return RedirectToAction("Manage");
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
        public ActionResult Edit([Bind("Name")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _tagService.Update(tag);
                return RedirectToAction("Manage");
            }
            return View(tag);
        }

        // GET: Tags/Delete/5
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

        // POST: Tags/Delete/5
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
