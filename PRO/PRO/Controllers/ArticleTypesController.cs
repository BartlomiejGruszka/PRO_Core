
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Entities;
using PRO.Persistance.Data;
using PRO.Domain.Interfaces.Services;
using System;

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
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {            
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "Name" ? "name_desc" : "Name";

            var articleTypesList = _articleTypeService.FilterSearch(currentFilter);
            articleTypesList = _articleTypeService.SortList(sortOrder, articleTypesList);
            var result = PaginatedList<ArticleType>.Create(articleTypesList.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Configure( action, currentFilter,sortOrder);

            return View(result);
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
                var errors = _articleTypeService.ValidateArticleType(articleType);
                if (!errors.Any())
                {
                    _articleTypeService.Add(articleType);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
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
        public ActionResult Edit(ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                var errors = _articleTypeService.ValidateArticleType(articleType);
                if (!errors.Any())
                {
                    _articleTypeService.Update(articleType);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
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