using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
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

        public Company Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Company> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Tuple<Company, int>> GetPopularCompanies(int? number)
        {
            var companies = _gameListRepository.GetAll()
                .GroupBy(g => g.Game.DeveloperCompany)
                .Select(g => new { company = g.Key, count = g.Count() })
                .AsEnumerable()
                .Select(c => new Tuple<Company, int>(c.company, c.count))
                .OrderByDescending(o => o.Item2);

            if (number.HasValue) { return companies.Take(number.Value).ToList(); }
            return companies.ToList();
        }

        public void Update(Company company)
        {
            _repository.Update(company);
            _repository.Save();
        }
    }
}
