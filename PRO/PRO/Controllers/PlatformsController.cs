using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class PlatformsController : Controller
    {
        private readonly IPlatformService _platformService;
        private readonly ICompanyService _companyService;
        public PlatformsController(IPlatformService platformService, ICompanyService companyService)
        {
            _platformService = platformService;
            _companyService = companyService;
        }

        // GET: Platforms
        [Route("platforms/")]
        public ActionResult Index()
        {
            return View(_platformService.GetAll());
        }
        // GET: Platforms
        [Route("platforms/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CompanySortParm"] = sortOrder == "company" ? "company_desc" : "company";
            ViewData["DateSortParm"] = sortOrder == "date" ? "date_desc" : "date";

            var platforms = _platformService.FilterSearch(currentFilter);
            platforms = _platformService.SortList(sortOrder, platforms);

            var result = PaginatedList<Platform>.Create(platforms.AsNoTracking(), page, items);

            result.Pagination.Configure("manage", currentFilter, sortOrder);
            return View(result);
        }

        // GET: Platforms/Details/5
        [Route("platforms/details/{id}")]
        public ActionResult Details(int? id)
        {
            Platform platform = _platformService.Find(id);
            if (platform == null)
            {
                return NotFound();
            }
            return View(platform);
        }

        // GET: Platforms/Create
        [Route("platforms/add")]
        public ActionResult Add()
        {
            ViewBag.Companies = _companyService.GetAll();
            return View();
        }

        // POST: Platforms/Create
        [HttpPost]
        [Route("platforms/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add( Platform platform)
        {
            if (ModelState.IsValid)
            {
                var errors = _platformService.ValidatePlatform(platform);
                if (!errors.Any())
                {
                    _platformService.Add(platform);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);

            }

            ViewBag.Companies = _companyService.GetAll();
            return View(platform);
        }

        // GET: Platforms/Edit/5
        [Route("platforms/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            Platform platform = _platformService.Find(id);
            if (platform == null)
            {
                return NotFound();
            }
            ViewBag.Companies = _companyService.GetAll();
            return View(platform);
        }

        // POST: Platforms/Edit/5
        [HttpPost]
        [Route("platforms/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Platform platform)
        {
            if (ModelState.IsValid)
            {
                var errors = _platformService.ValidatePlatform(platform);
                if (!errors.Any())
                {
                    _platformService.Update(platform);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            ViewBag.Companies = _companyService.GetAll();
            return View(platform);
        }

        // GET: Platforms/Delete/5
        [Route("platforms/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Platform platform = _platformService.Find(id);
            if (platform == null)
            {
                return NotFound();
            }
            return View(platform);
        }

        // POST: Platforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("platforms/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Platform platform = _platformService.Find(id);
            _platformService.Delete(platform);
            return RedirectToAction("Manage");
        }
    }
}
