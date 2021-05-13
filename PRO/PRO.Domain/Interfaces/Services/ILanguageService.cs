﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface ILanguageService
    {
        public IEnumerable<Language> GetAll();
        public Language Find(int? id);
        public void Add(Language language);
        public void Delete(Language language);

        public void Update(Language language);
        public ModelStateDictionary ValidateLanguage(Language language);
    }
}
