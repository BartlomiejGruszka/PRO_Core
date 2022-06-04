using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class LanguagesController : Controller
    {
        private readonly ILanguageService _languageService;
        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        // GET: Languages
        [Route("languages/")]
        public ActionResult Index()
        {
            return View(_languageService.GetAll());
        }

        [Route("languages/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            var languages = _languageService.FilterSearch(currentFilter);
            languages = _languageService.SortList(sortOrder, languages);
            var result = PaginatedList<Language>.Create(languages.AsNoTracking(), page, items);
            result.Pagination.Configure(
                this.ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, sortOrder);

            return View(result);

        }

        // GET: Languages/Details/5
        [Route("languages/details/{id}")]
        public ActionResult Details(int? id)
        {

            Language language = _languageService.Find(id);
            if (language == null)
            {
                return NotFound();
            }
            return View(language);
        }

        // GET: Languages/add
        [Route("languages/add")]
        public ActionResult Add()
        {
            ViewBag.returnUrl = HttpContext.Request.Headers["Referer"];
            return View();
        }

        // POST: Languages/Create
        [HttpPost]
        [Route("languages/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Language language, string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var errors = _languageService.ValidateLanguage(language);
                if (!errors.Any())
                {
                    _languageService.Add(language);
                    if (returnUrl != null) { return Redirect(returnUrl); }
                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);

            }

            return View(language);
        }

        // GET: Languages/Edit/5
        [Route("languages/edit/{id}")]
        public ActionResult Edit(int? id)
        {

            Language language = _languageService.Find(id);
            if (language == null)
            {
                return NotFound();
            }
            return View(language);
        }

        // POST: Languages/Edit/5
        [HttpPost]
        [Route("languages/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Language language)
        {
            if (ModelState.IsValid)
            {
                var errors = _languageService.ValidateLanguage(language);
                if (!errors.Any())
                {
                    _languageService.Update(language);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(language);
        }

        [Authorize(Roles = "Admin")]
        [Route("languages/delete/{id}")]
        public ActionResult Delete(int? id)
        {
            Language language = _languageService.Find(id);
            if (language == null)
            {
                return NotFound();
            }
            return View(language);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [Route("languages/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Language language = _languageService.Find(id);
            _languageService.Delete(language);
            return RedirectToAction("Manage");
        }
    }
}
