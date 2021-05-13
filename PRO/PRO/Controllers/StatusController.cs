using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;

namespace PRO.Controllers
{
    [Authorize]
    public class StatusController : Controller
    {
        private readonly IStatusService _statusService;
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }
        // GET: Status
        [Route("status/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var statuses = _statusService.GetAll();
            ViewBag.Pagination = new Pagination(page, items, statuses.Count());
            return View(statuses);
        }

        // GET: Status/Details/5
        [Route("status/details/{id}")]
        public ActionResult Details(int? id)
        {
            Status status = _statusService.Find(id);
            if (status == null)
            {
                return NotFound();
            }
            return View(status);
        }

        // GET: Status/add
        [Route("status/add")]
        public ActionResult Add()
        {
            return View();
        }

        // POST: Status/Create
        [HttpPost]
        [Route("status/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name")] Status status)
        {
            if (ModelState.IsValid)
            {
                var errors = _statusService.ValidateStatus(status);
                if (!errors.Any())
                {
                    _statusService.Add(status);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            return View(status);
        }

        // GET: Status/Edit/5
        [Route("status/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            Status status = _statusService.Find(id);
            if (status == null)
            {
                return NotFound();
            }
            return View(status);
        }

        // POST: Status/Edit/5
        [HttpPost]
        [Route("status/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Name")] Status status)
        {
            if (ModelState.IsValid)
            {
                var errors = _statusService.ValidateStatus(status);
                if (!errors.Any())
                {
                    _statusService.Update(status);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(status);
        }

        // GET: Status/Delete/5
        [Route("status/delete/{id}")]
        public ActionResult Delete(int? id)
        {
            Status status = _statusService.Find(id);
            if (status == null)
            {
                return NotFound();
            }
            return View(status);
        }

        // POST: Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("status/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Status status = _statusService.Find(id);
            _statusService.Delete(status);
            return RedirectToAction("Manage");
        }
    }
}
