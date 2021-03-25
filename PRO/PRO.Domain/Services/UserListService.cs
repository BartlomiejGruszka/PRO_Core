using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class UserListService : IUserListService
    {
        private readonly IRepository<UserList> _repository;
        public UserListService(IRepository<UserList> repository)
        {
            _repository = repository;
        }

        public void Add(UserList userList)
        {
            _repository.Add(userList);
            _repository.Save();
        }

        public void Delete(UserList userList)
        {
            _repository.Remove(userList);
            _repository.Save();
        }

        public UserList Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<UserList> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(UserList userList)
        {
            _repository.Update(userList);
            _repository.Save();
        }
    }
}
