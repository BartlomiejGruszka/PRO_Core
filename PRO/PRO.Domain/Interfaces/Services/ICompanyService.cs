using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAll();
        public Company Find(int? id);
        public void Add(Company company);
        public void Delete(Company company);

        public void Update(Company company);
        public List<Tuple<Company, int>> GetPopularCompanies(int? number);
        public ModelStateDictionary ValidateCompany(Company company);
        IQueryable<Company> FilterSearch(string query);
        IQueryable<Company> SortList(string sortOrder, IQueryable<Company> companies);
    }
}
