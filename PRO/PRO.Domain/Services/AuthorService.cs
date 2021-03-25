﻿using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _repository;
        public AuthorService(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public void Add(Author author)
        {
            _repository.Add(author);
            _repository.Save();
        }

        public void Delete(Author author)
        {
            _repository.Remove(author);
            _repository.Save();
        }

        public Author Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Author> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Author author)
        {
            _repository.Update(author);
            _repository.Save();
        }
    }
}