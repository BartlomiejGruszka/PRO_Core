
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRO.Entities;
using PRO.Persistance.Data;
using PRO.Domain.Interfaces.Services;

namespace PRO.Controllers
{
    [Authorize]
    public class ArticleTypesController : Controller
    {
        private readonly IArticleTypeService _articleTypeService;
        public ArticleTypesController(IArticleTypeService articleTypeService)
        {
            _articleTypeService = articleTypeService;
        }


        [Route("articletypes/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var articleTypesList = _articleTypeService.GetAll();
            ViewBag.Pagination = new Pagination(page, items, articleTypesList.Count());

            return View(articleTypesList);
        }

        [Route("articletypes/details/{id}")]
        public ActionResult Details(int? id)
        {
            ArticleType articletype = _articleTypeService.Find(id);
            if (articletype == null)
            {
                return BadRequest();
            }
            return View(articletype);
        }

        [Route("articletypes/add")]
        public ActionResult Add()
        {
            return View(new ArticleType());
        }


        [HttpPost]
        [Route("articletypes/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                _articleTypeService.Add(articleType);

                return RedirectToAction("Manage");
            }
            return View(articleType);
        }

        [Route("articletypes/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            ArticleType articletype = _articleTypeService.Find(id);
            if (articletype == null)
            {
                return BadRequest();
            }
            return View(articletype);
        }

        [HttpPost]
        [Route("articletypes/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Name")] ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                _articleTypeService.Update(articleType);
                return RedirectToAction("Manage");
            }
            return View(articleType);
        }

        [Route("articletypes/delete/{id}")]
        public ActionResult Delete(int? id)
        {
            ArticleType articleType = _articleTypeService.Find(id);
            if (articleType == null)
            {
                return BadRequest();
            }
            return View(articleType);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("articletypes/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArticleType articleType = _articleTypeService.Find(id);
            if (articleType == null)
            {
                return BadRequest();
            }
            _articleTypeService.Delete(articleType);

            return RedirectToAction("Manage");
        }

    }
}