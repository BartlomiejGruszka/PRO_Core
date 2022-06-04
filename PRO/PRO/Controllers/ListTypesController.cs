using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ListTypesController : Controller
    {

        private readonly IListTypeService _listTypeService;
        public ListTypesController(IListTypeService listTypeService)
        {
            _listTypeService = listTypeService;
        }

        // GET: ListTypes
        [Route("listtypes/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {

            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["NameSortParm"] = sortOrder == "name" ? "name_desc" : "name";

            var listTypes = _listTypeService.FilterSearch(currentFilter);
            listTypes = _listTypeService.SortList(sortOrder, listTypes);
            var result = PaginatedList<ListType>.Create(listTypes.AsNoTracking(), page, items);
            result.Pagination.Configure(
                this.ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, sortOrder);
            return View(result);
        }

        // GET: ListTypes/Details/5
        [Route("listtypes/details/{id}")]
        public ActionResult Details(int? id)
        {
            ListType listType = _listTypeService.Find(id);
            if (listType == null)
            {
                return NotFound();
            }
            return View(listType);
        }

        // GET: ListTypes/Create
        [Route("listtypes/add")]
        public ActionResult Add()
        {
            return View();
        }

        // POST: ListTypes/Create
        [HttpPost]
        [Route("listtypes/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ListType listType)
        {
            if (ModelState.IsValid)
            {
                var errors = _listTypeService.ValidateListType(listType);
                if (!errors.Any())
                {
                    _listTypeService.Add(listType);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
               
            }

            return View(listType);
        }

        // GET: ListTypes/Edit/5
        [Route("listtypes/edit/{id}")]
        public ActionResult Edit(int? id)
        {

            ListType listType = _listTypeService.Find(id);
            if (listType == null)
            {
                return NotFound();
            }
            return View(listType);
        }

        // POST: ListTypes/Edit/5
        [HttpPost]
        [Route("listtypes/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ListType listType)
        {
            if (ModelState.IsValid)
            {
                var errors = _listTypeService.ValidateListType(listType);
                if (!errors.Any())
                {
                    _listTypeService.Update(listType);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(listType);
        }

        // GET: ListTypes/Delete/5
        [Route("listtypes/delete/{id}")]
        public ActionResult Delete(int? id)
        {
            ListType listType = _listTypeService.Find(id);
            if (listType == null)
            {
                return NotFound();
            }
            return View(listType);
        }

        // POST: ListTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("listtypes/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListType listType = _listTypeService.Find(id);
            _listTypeService.Delete(listType);
            return RedirectToAction("Manage");
        }
    }
}
