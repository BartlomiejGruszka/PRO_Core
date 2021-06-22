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
        public PlatformsController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        // GET: Platforms
        [Route("platforms/")]
        public ActionResult Index()
        {
            return View(_platformService.GetAll());
        }
        // GET: Platforms
        [Route("platforms/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var platforms = _platformService.GetAll().AsQueryable();
            var result = PaginatedList<Platform>.Create(platforms.AsNoTracking(), page, items);

            result.Pagination.Action = "manage";
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
            ViewBag.CompanyId = new SelectList(_platformService.GetAll(), "Id", "Name");
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

            ViewBag.CompanyId = new SelectList(_platformService.GetAll(), "Id", "Name", platform.CompanyId);
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
            ViewBag.CompanyId = new SelectList(_platformService.GetAll(), "Id", "Name", platform.CompanyId);
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
            ViewBag.CompanyId = new SelectList(_platformService.GetAll(), "Id", "Name", platform.CompanyId);
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
