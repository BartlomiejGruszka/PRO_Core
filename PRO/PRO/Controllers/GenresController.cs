using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            return View(_genreService.GetAll());
        }
        [Route("genres/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var genres = _genreService.GetAll();
            ViewBag.Pagination = new Pagination(page, items, genres.Count());

            return View(genres);
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
        public ActionResult Edit([Bind("Name")] Genre genre)
        {
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
