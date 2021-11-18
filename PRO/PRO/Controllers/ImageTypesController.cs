
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Entities;
using PRO.Domain.Interfaces.Services;
using System;

namespace PRO.Controllers
{
    public class ImageTypesController : Controller
    {

        private readonly IImageTypeService _imageTypeService;
        public ImageTypesController(IImageTypeService imageTypeService)
        {
            _imageTypeService = imageTypeService;
        }

        [Route("ImageTypes/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["TypeSortParm"] = sortOrder == "type" ? "type_desc" : "type";
            var ImageTypes = _imageTypeService.FilterSearch(currentFilter);
            ImageTypes = _imageTypeService.SortList(sortOrder, ImageTypes);
            var result = PaginatedList<ImageType>.Create(ImageTypes.AsNoTracking(), page, items);

            result.Pagination.Configure("manage", currentFilter,sortOrder);
            return View(result);
        }

        // GET: ImageTypes/Details/5
        [Route("ImageTypes/details/{id}")]
        public ActionResult Details(int? id)
        {
            ImageType ImageType = _imageTypeService.Find(id);
            if (ImageType == null)
            {
                return BadRequest();
            }
            return View(ImageType);
        }

        // GET: ImageTypes/add
        [Route("ImageTypes/add")]
        public ActionResult Add()
        {
            return View();
        }

        // POST: ImageTypes/Add
        [HttpPost]
        [Route("ImageTypes/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ImageType ImageType)
        {
            if (ModelState.IsValid)
            {
                var errors = _imageTypeService.ValidateImageType(ImageType);
                if (!errors.Any())
                {
                    _imageTypeService.Add(ImageType);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
               
            }

            return View(ImageType);
        }

        // GET: ImageTypes/Edit/5
        [Route("ImageTypes/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            ImageType ImageType = _imageTypeService.Find(id);
            if (ImageType == null)
            {
                return BadRequest();
            }
            return View(ImageType);
        }

        [HttpPost]
        [Route("ImageTypes/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( ImageType imageType)
        {
            if (ModelState.IsValid)
            {
                var errors = _imageTypeService.ValidateImageType(imageType);
                if (!errors.Any())
                {
                    _imageTypeService.Update(imageType);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(imageType);
        }

        // GET: ImageTypes/Delete/5
        [Route("ImageTypes/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            ImageType ImageType = _imageTypeService.Find(id);
            if (ImageType == null)
            {
                return BadRequest();
            }
            return View(ImageType);
        }

        // POST: ImageTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("ImageTypes/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ImageType ImageType = _imageTypeService.Find(id);
            if (ImageType == null)
            {
                return BadRequest();
            }
            _imageTypeService.Delete(ImageType);

            return RedirectToAction("Manage");
        }

    }
}

