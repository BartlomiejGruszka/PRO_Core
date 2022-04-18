using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Entities;
using PRO.Domain.HelperClasses;
using System.Collections.Generic;
using System.Linq;


namespace PRO.Domain.Interfaces.Services
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAll();
        public Company Find(int? id);
        public void Add(Company company);
        public void Delete(Company company);

        public void Update(Company company);
        public List<CompanyPopularity> GetPopularCompanies(int? number);
        public ModelStateDictionary ValidateCompany(Company company);
        IQueryable<Company> FilterSearch(string query);
        IQueryable<Company> SortList(string sortOrder, IQueryable<Company> companies);
    }
}
