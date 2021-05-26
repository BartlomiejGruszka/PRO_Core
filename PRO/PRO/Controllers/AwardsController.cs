﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class AwardsController : Controller
    {
        private readonly IAwardService _awardService;
        private readonly IGameService _gameService;
        public AwardsController(IAwardService awardService, IGameService gameService)
        {
            _awardService = awardService;
            _gameService = gameService;
        }

        [Route("awards/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var awards = _awardService.GetAll().AsQueryable();

            return View(PaginatedList<Award>.Create(awards.AsNoTracking(), page, items));
        }

        // GET: Awards/Details/5
        [Route("awards/details/{id}")]
        public ActionResult Details(int? id)
        {
            Award award = _awardService.Find(id);
            if (award == null)
            {
                return BadRequest();
            }
            return View(award);
        }

        // GET: Awards/Create
        [Route("awards/add")]
        public ActionResult Add()
        {
            ViewBag.GameId = new SelectList(_gameService.GetAll(), "Id", "Title");
            return View();
        }

        [HttpPost]
        [Route("awards/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name,AwardDate,GameId")] Award award)
        {
            if (ModelState.IsValid)
            {
                var errors = _awardService.ValidateAward(award);
                if (!errors.Any())
                {
                    _awardService.Add(award);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            ViewBag.GameId = new SelectList(_gameService.GetAll(), "Id", "Title", award.GameId);
            return View(award);
        }

        // GET: Awards/Edit/5
        [Route("awards/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            Award award = _awardService.Find(id);
            if (award == null)
            {
                return BadRequest();
            }
            ViewBag.GameId = new SelectList(_gameService.GetAll(), "Id", "Title", award.GameId);
            return View(award);
        }

        [HttpPost]
        [Route("awards/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(",Name,AwardDate,GameId")] Award award)
        {
            if (ModelState.IsValid)
            {
                var errors = _awardService.ValidateAward(award);
                if (!errors.Any())
                {
                    _awardService.Update(award);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            ViewBag.GameId = new SelectList(_gameService.GetAll(), "Id", "Title", award.GameId); ;
            return View(award);
        }

        // GET: Awards/Delete/5
        [Route("awards/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Award award = _awardService.Find(id);
            if (award == null)
            {
                return BadRequest();
            }
            return View(award);
        }

        // POST: Awards/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("awards/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Award award = _awardService.Find(id);
            if (award == null)
            {
                return BadRequest();
            }
            _awardService.Delete(award);
            return RedirectToAction("Manage");
        }
    }
}
