using Microsoft.AspNetCore.Authorization;
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
        public ActionResult Manage()
        {
            // var pageString = Request.QueryString["page"];
            // var itemString = Request.QueryString["items"];
            var series = _seriesService.GetAll();
            ViewBag.Pagination = new Pagination(null, null, series.Count());
            return View(series);
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
            return View();
        }

        // POST: Series/Create
        [HttpPost]
        [Route("series/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name")] Series series)
        {
            if (ModelState.IsValid)
            {
                _seriesService.Add(series);
                return RedirectToAction("Manage");
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
        public ActionResult Edit([Bind("Name")] Series series)
        {
            if (ModelState.IsValid)
            {
                _seriesService.Update(series);

                return RedirectToAction("Manage");
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
