using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class UserListService : IUserListService
    {
        private readonly IRepository<UserList> _repository;
        private readonly IUserListRepository _userListRepository;
        public UserListService(IRepository<UserList> repository, IUserListRepository userListRepository)
        {
            _repository = repository;
            _userListRepository = userListRepository;
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

        public IEnumerable<UserList> GetUserUserLists(int? userid)
        {
            return _userListRepository.GetUserUserLists(userid);
        }

        public IEnumerable<UserList> GetAll()
        {
            return _userListRepository.GetAll();
        }

        public void Update(UserList userList)
        {
            _repository.Update(userList);
            _repository.Save();
        }

        public UserList Find(int? id)
        {
            return _userListRepository.Find(id);
        }
        public ModelStateDictionary ValidateUserList(UserList userList)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (userList == null) return errors;

            var userLists = _repository.GetAll().Where(i => i.Name == userList.Name && i.UserId == userList.UserId && i.Id != userList.Id);

            if (userLists.Any())
            {
                errors.TryAddModelError("Name", "Posiadasz już listę o takiej nazwie.");
            }
            return errors;

        }
    }
}
