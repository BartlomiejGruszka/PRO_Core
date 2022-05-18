﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;


namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class SeriesController : Controller
    {
        private readonly ISeriesService _seriesService;
        public SeriesController(ISeriesService seriesService)
        {
            _seriesService = seriesService;
        }

        // GET: Series
        [Route("series/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";
            var series = _seriesService.FilterSearch(currentFilter);
            series = _seriesService.SortList(sortOrder, series);
            var result = PaginatedList<Series>.Create(series.AsNoTracking(), page, items);

            result.Pagination.Configure("manage", currentFilter, sortOrder);
            return View(result);
        }

        // GET: Series/Details/5
        [Route("series/details/{id}")]
        public ActionResult Details(int? id)
        {
            Series series = _seriesService.Find(id);
            if (series == null)
            {
                return NotFound();
            }
            return View(series);
        }

        // GET: Series/Create
        [Route("series/add")]
        public ActionResult Add()
        {
            ViewBag.returnUrl = HttpContext.Request.Headers["Referer"];
            return View();
        }

        // POST: Series/Create
        [HttpPost]
        [Route("series/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Series series, string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var errors = _seriesService.ValidateSeries(series);
                if (!errors.Any())
                {
                    _seriesService.Add(series);
                    if (returnUrl != null) { return Redirect(returnUrl); }
                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            return View(series);
        }

        // GET: Series/Edit/5
        [Route("series/edit/{id}")]
        public ActionResult Edit(int? id)
        {

            Series series = _seriesService.Find(id);
            if (series == null)
            {
                return NotFound();
            }
            return View(series);
        }

        // POST: Series/Edit/5

        [HttpPost]
        [Route("series/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Series series)
        {
            if (ModelState.IsValid)
            {
                var errors = _seriesService.ValidateSeries(series);
                if (!errors.Any())
                {
                    _seriesService.Update(series);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(series);
        }

        // GET: Series/Delete/5
        [Route("series/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Series series = _seriesService.Find(id);
            if (series == null)
            {
                return NotFound();
            }
            return View(series);
        }

        // POST: Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("series/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Series series = _seriesService.Find(id);

            _seriesService.RemoveFromGames(id);
            _seriesService.Delete(series);

            return RedirectToAction("Manage");
        }
    }
}
