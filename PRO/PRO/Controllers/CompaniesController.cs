using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
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
        public ActionResult Manage()
        {
            // var pageString = Request.QueryString["page"];
            // var itemString = Request.QueryString["items"];
            var companies = _companyService.GetAll();
            ViewBag.Pagination = new Pagination(null, null, companies.Count());
            return View(companies);
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
            return View();
        }

        [HttpPost]
        [Route("companies/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Name,CreatedDate,IsActive")] Company company)
        {
            if (ModelState.IsValid)
            {
                _companyService.Add(company);
                return RedirectToAction("Manage");
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
        public ActionResult Edit([Bind("Name,CreatedDate,IsActive")] Company company)
        {
            if (ModelState.IsValid)
            {
                _companyService.Update(company);
                return RedirectToAction("Manage");
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
