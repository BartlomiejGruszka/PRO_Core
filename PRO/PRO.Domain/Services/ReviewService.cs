using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class ReviewService : IReviewService
    {
        private readonly IRepository<Review> _repository;
        public ReviewService(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public void Add(Review review)
        {
            _repository.Add(review);
            _repository.Save();
        }

        public void Delete(Review review)
        {
            _repository.Remove(review);
            _repository.Save();
        }

        public Review Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Review> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Review review)
        {
            _repository.Update(review);
            _repository.Save();
        }
    }
}
