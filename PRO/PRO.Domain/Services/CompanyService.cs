using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> _repository;
        private readonly IGameListRepository _gameListRepository;
        public CompanyService(IRepository<Company> repository, IGameListRepository gameListRepository)
        {
            _repository = repository;
            _gameListRepository = gameListRepository;
        }

        public void Add(Company company)
        {
            _repository.Add(company);
            _repository.Save();
        }

        public void Delete(Company company)
        {
            _repository.Remove(company);
            _repository.Save();
        }

        public IQueryable<Company> FilterSearch(string query)
        {
            var companies = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                companies = companies.Where(s => s.Name.ToLower().Contains(query.ToLower()));
            }
            return companies;
        }

        public Company Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Company> GetAll()
        {
            return _repository.GetAll();
        }

        public List<CompanyPopularity> GetPopularCompanies(int? number)
        {
            var companies = _gameListRepository.GetAll()
                .GroupBy(g => g.Game.DeveloperCompany)
                .Select(g => new CompanyPopularity{ Company = g.Key, Popularity = g.Count() })
                .AsEnumerable()             
                .OrderByDescending(o => o.Popularity);

            if (number.HasValue) { return companies.Take(number.Value).ToList(); }
            return companies.ToList();
        }

        public IQueryable<Company> SortList(string sortOrder, IQueryable<Company> companies)
        {
            companies = sortOrder switch
            {
                "id_desc" => companies.OrderByDescending(s => s.Id),
                "" => companies.OrderBy(s => s.Id),
                "name_desc" => companies.OrderByDescending(s => s.Name),
                "name" => companies.OrderBy(s => s.Name),
                "date_desc" => companies.OrderByDescending(s => s.CreatedDate),
                "date" => companies.OrderBy(s => s.CreatedDate),
                _ => companies.OrderBy(s => s.Id),
            };
            return companies.AsQueryable();
        }

        public void Update(Company company)
        {
            _repository.Update(company);
            _repository.Save();
        }

        public ModelStateDictionary ValidateCompany(Company company)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (company == null) return errors;

            var companies = _repository.GetAll().Where(i => i.Name == company.Name && i.Id != company.Id);

            if (companies.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już firma o takiej nazwie.");
            }
            return errors;
        }
    }
}
