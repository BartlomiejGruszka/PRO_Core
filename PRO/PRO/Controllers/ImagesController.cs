using System;
using System.Collections.Generic;
using System.IO;
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
   // [Authorize]
    public class ImagesController : Controller
    {


        private readonly IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }

        // GET: Image
        [Route("images/")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("images/manage")]
       // [Authorize(Roles = "Admin,Author")]
        public ActionResult Manage()
        {
            // var pageString = Request.QueryString["page"];
            //  var itemString = Request.QueryString["items"];
            var images = _imageService.ImagesList(); 
            ViewBag.Pagination = new Pagination(null, null, images.Count());
            return View(images);
        }

        [Route("images/details/{id}")]
        //[Authorize(Roles = "Admin,Author")]
        public ActionResult Details(int? id)
        {
            Image image = _imageService.FindImage(id);
            if (image == null)
            {
                return BadRequest();
            }
            return View(image);
        }

        [HttpGet]
        [Route("images/add")]
       // [Authorize(Roles = "Admin,Author")]
        public ActionResult Add()
        {
           // ViewBag.ImageTypes = _imageService.GetImageTypes();
            return View();
        }

        [HttpPost]
        [Route("images/add")]
        //[Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Image image)
        {
            if (ModelState.IsValid) {

                _imageService.AddImage(image);

            return RedirectToAction("Manage");
            }
            return View(image);
        }

        // GET: Companies/Edit/5
        [Route("images/edit/{id}")]
        //[Authorize(Roles = "Admin,Author")]
        public ActionResult EditFile(int? id)
        {
            Image image = _imageService.FindImage(id);
            if (image == null)
            {
                return BadRequest();
            }
           // ViewBag.ImageTypes = _imageService.GetImageTypes();
            return View(image);
        }
        [Route("images/rename/{id}")]
        //[Authorize(Roles = "Admin,Author")]
        public ActionResult Edit(int? id)
        {
            Image image = _imageService.FindImage(id);
            if (image == null)
            {
                return BadRequest();
            }
           // ViewBag.ImageTypes = _imageService.GetImageTypes();
            return View(image);
        }


        [HttpPost]
        [Route("images/edit/{id}")]
       // [Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult EditFile(Image image)
        {
            if (ModelState.IsValid)
            {
                _imageService.UpdateImage(image);
                
                return RedirectToAction("Manage");
            }
           // ViewBag.ImageTypes = _imageService.GetImageTypes();
            return View(image);
        }

        [HttpPost]
        [Route("images/rename/{id}")]
       // [Authorize(Roles = "Admin,Author")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Image image)
        {
            var errorList = ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );
            if (!errorList.ContainsKey("Name") && image.ImageFile == null)
            {
                _imageService.RenameImage(image);
                return RedirectToAction("Manage");
            }
            //ViewBag.ImageTypes = _imageService.GetImageTypes();
            return View(image);
        }

        [Route("images/delete/{id}")]
       // [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Image image = _imageService.FindImage(id);

            if (image == null)
            {
                return BadRequest();
            }
            return View(image);
        }

        [HttpPost, ActionName("Delete")]
        [Route("images/delete/{id}")]
       // [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Image image = _imageService.FindImage(id);

            _imageService.DeleteImage(image);  
            
            return RedirectToAction("Manage");
        }

        [HttpPost]
        //[Authorize(Roles = "Admin,Author")]
        [Route("images/getimagesbytype/{id?}")]
        public ActionResult GetImagesByType(int id)
        {
            var ImagesByType = _imageService.GetImagesByType(id);
            SelectList viewLists = new SelectList(ImagesByType, "Id", "Name", 0);
            return Json(viewLists);
        }
    }
}