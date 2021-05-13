using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

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

        public ModelStateDictionary ValidateLanguage(Language language)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (language == null) return errors;

            var languages = _repository.GetAll().Where(i => i.Name == language.Name && i.Id != language.Id);

            if (languages.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już taki język.");
            }
            return errors;
        }
    }
}
