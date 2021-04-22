using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepository<Language> _repository;
        public LanguageService(IRepository<Language> repository)
        {
            _repository = repository;
        }
        public void Add(Language language)
        {
            _repository.Add(language);
            _repository.Save();
        }

        public void Delete(Language language)
        {
            _repository.Remove(language);
            _repository.Save();
        }

        public Language Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Language> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Language language)
        {
            _repository.Update(language);
            _repository.Save();
        }
    }
}
