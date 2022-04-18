using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin,Author")]
    public class CompaniesController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [Route("companies/")]
        public ActionResult Index()
        {
            return View(_companyService.GetAll());
        }

        // GET: Companies
        [Route("companies/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {            
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "date" ? "date_desc" : "date";    
            
            var companies = _companyService.FilterSearch(currentFilter);
            companies = _companyService.SortList(sortOrder, companies);

            var result = PaginatedList<Company>.Create(companies.AsNoTracking(), page, items);
            var action = this.ControllerContext.ActionDescriptor.ActionName.ToString();
            result.Pagination.Configure( action, currentFilter,sortOrder);

            return View(result);
        }

        // GET: Companies/Details/5
        [Route("companies/details/{id}")]
        public ActionResult Details(int? id)
        {
            Company company = _companyService.Find(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // GET: Companies/Add
        [Route("companies/add")]
        public ActionResult Add()
        {
            ViewBag.returnUrl = HttpContext.Request.Headers["Referer"];
            return View();
        }

        [HttpPost]
        [Route("companies/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Company company, string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var errors = _companyService.ValidateCompany(company);
                if (!errors.Any())
                {
                    _companyService.Add(company);
                    if (returnUrl != null) { return Redirect(returnUrl); }
                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }

            return View(company);
        }

        // GET: Companies/Edit/5
        [Route("companies/edit/{id}")]
        public ActionResult Edit(int? id)
        {

            Company company = _companyService.Find(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        [HttpPost]
        [Route("companies/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Company company)
        {
            if (ModelState.IsValid)
            {
                var errors = _companyService.ValidateCompany(company);
                if (!errors.Any())
                {
                    _companyService.Update(company);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        [Route("companies/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {

            Company company = _companyService.Find(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("companies/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = _companyService.Find(id);
            _companyService.Delete(company);
            return RedirectToAction("Manage");
        }

    }
}
