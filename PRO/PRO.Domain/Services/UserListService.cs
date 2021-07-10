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

        public IQueryable<UserList> FilterSearch(string query)
        {
            var userLists = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                userLists = userLists.Where(s =>
                s.Name.ToLower().Contains(query.ToLower()) ||
                s.User.UserName.ToLower().Contains(query.ToLower())||
                s.ListType.Name.ToLower().Contains(query.ToLower())
                );
            }
            return userLists;
        }

        public IQueryable<UserList> SortList(string sortOrder, IQueryable<UserList> userlists)
        {
            userlists = sortOrder switch
            {
                "adddate_desc" => userlists.OrderByDescending(s => s.CreatedDate),
                "" => userlists.OrderBy(s => s.CreatedDate),
                "name_desc" => userlists.OrderByDescending(s => s.Name),
                "name" => userlists.OrderBy(s => s.Name),
                "user_desc" => userlists.OrderByDescending(s => s.User.UserName),
                "user" => userlists.OrderBy(s => s.User.UserName),
                "type_desc" => userlists.OrderByDescending(s => s.ListType.Name),
                "type" => userlists.OrderBy(s => s.ListType.Name),
                _ => userlists.OrderBy(s => s.CreatedDate),
            };
            return userlists.AsQueryable();
        }

        public IQueryable<UserList> FilterByList(string currentFilter, IQueryable<UserList> userlists)
        {
            if (currentFilter == null) return userlists;
            if (currentFilter.Equals("all")) return userlists;
            return userlists.Where(s => s.ListType.Name.ToLower().Contains(currentFilter.ToLower()));
        }

        public void AddOrUpdate(UserList model)
        {
            var oldlist = Find(model.Id);
            if (oldlist == null)
            {
                Add(model);
            }
            else
            {
                oldlist.IsPublic = model.IsPublic;
                oldlist.Name = model.Name;
                oldlist.ListTypeId = model.ListTypeId;
                Update(oldlist);
            }


        }
    }
}
