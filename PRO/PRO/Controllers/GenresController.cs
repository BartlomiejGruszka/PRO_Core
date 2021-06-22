using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class GenresController : Controller
    {

        private readonly IGenreService _genreService;
        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: Genres
        [Route("genres/")]
        public ActionResult Index()
        {
            return View();//
        }

        [HttpGet]
        [Route("genres/manage/{query?}")]
        public ActionResult Manage(string query, int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (!String.IsNullOrEmpty(query))
            {
                page = 1;             
            }
            else
            {
                query = currentFilter;
            }
            ViewData["CurrentFilter"] = query;
            var genres = _genreService.FilterSearch(query);
            genres = _genreService.SortList(sortOrder,genres);

            var result = PaginatedList<Genre>.Create(genres.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Action = action;

            return View("Manage", result);
        }

        // GET: Genres/Details/5
        [Route("genres/details/{id}")]
        public ActionResult Details(int? id)
        {
            Genre genre = _genreService.Find(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        // GET: Genres/add
        [Route("genres/add")]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("genres/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                var errors = _genreService.ValidateGenre(genre);
                if (!errors.Any())
                {
                    _genreService.Add(genre);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            return View(genre);
        }

        // GET: Genres/Edit/5
        [Route("genres/edit/{id}")]
        public ActionResult Edit(int? id)
        {

            Genre genre = _genreService.Find(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }


        [HttpPost]
        [Route("genres/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genre, int id)
        {
            genre.Id = id;
            if (ModelState.IsValid)
            {
                var errors = _genreService.ValidateGenre(genre);
                if (!errors.Any())
                {
                    _genreService.Update(genre);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(genre);
        }

        // GET: Genres/Delete/5
        [Route("genres/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {

            Genre genre = _genreService.Find(id);
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("genres/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Genre genre = _genreService.Find(id);
            _genreService.Delete(genre);
            return RedirectToAction("Manage");
        }

    }
}
