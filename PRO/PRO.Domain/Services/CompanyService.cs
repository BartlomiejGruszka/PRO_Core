using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> _repository;
        public CompanyService(IRepository<Company> repository)
        {
            _repository = repository;
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

        public void Update(Company company)
        {
            _repository.Update(company);
            _repository.Save();
        }
    }
}
