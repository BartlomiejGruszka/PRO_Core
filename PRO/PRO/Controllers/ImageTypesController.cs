
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
    public class ImageTypesController : Controller
    {

        private readonly IImageTypeService _imageTypeService;
        public ImageTypesController(IImageTypeService imageTypeService)
        {
            _imageTypeService = imageTypeService;
        }

        [Route("ImageTypes/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var ImageTypes = _imageTypeService.GetAll();
            ViewBag.Pagination = new Pagination(page, items, ImageTypes.Count());

            return View(ImageTypes);
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
        public ActionResult Add([Bind("Id,Name")] ImageType ImageType)
        {
            if (ModelState.IsValid)
            {
                _imageTypeService.Add(ImageType);
                return RedirectToAction("Manage");
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
        public ActionResult Edit([Bind("Id,Name")] ImageType imageType)
        {
            if (ModelState.IsValid)
            {
                _imageTypeService.Update(imageType);
                return RedirectToAction("Manage");
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

