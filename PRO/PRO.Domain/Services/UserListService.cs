using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class UserListService : IUserListService
    {
        private readonly IRepository<UserList> _repository;
        private readonly IUserListRepository _userListRepository;
        private readonly IUserService _userService;
        public UserListService(IRepository<UserList> repository, IUserListRepository userListRepository, IUserService userService)
        {
            _repository = repository;
            _userListRepository = userListRepository;
            _userService = userService;
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
            if (String.IsNullOrEmpty(userList.Name))
            {
                errors.TryAddModelError("Name", "Nazwa listy jest wymagana.");
            }
            else if (userList.Name.Length < 3 || userList.Name.Length > 50)
            {
                errors.TryAddModelError("Name", "Nazwa musi mieć od 3 do 50 znaków.");
            }
            if (userList?.ListTypeId <= 0)
            {
                errors.TryAddModelError("ListTypeId", "Wybierz rodzaj listy");
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
                s.User.UserName.ToLower().Contains(query.ToLower()) ||
                s.ListType.Name.ToLower().Contains(query.ToLower())
                );
            }
            return userLists;
        }

        public IQueryable<UserList> SortList(string sortOrder, IQueryable<UserList> userlists)
        {
            userlists = sortOrder switch
            {
                "id_desc" => userlists.OrderByDescending(s => s.Id),
                "" => userlists.OrderBy(s => s.Id),
                "adddate_desc" => userlists.OrderByDescending(s => s.CreatedDate),
                "adddate" => userlists.OrderBy(s => s.CreatedDate),
                "name_desc" => userlists.OrderByDescending(s => s.Name),
                "name" => userlists.OrderBy(s => s.Name),
                "user_desc" => userlists.OrderByDescending(s => s.User.UserName),
                "user" => userlists.OrderBy(s => s.User.UserName),
                "type_desc" => userlists.OrderByDescending(s => s.ListType.Name),
                "type" => userlists.OrderBy(s => s.ListType.Name),
                "count_desc" => userlists.OrderByDescending(s => s.GameLists.Count()),
                "count" => userlists.OrderBy(s => s.GameLists.Count()),
                _ => userlists.OrderBy(s => s.Id),
            };
            return userlists.AsQueryable();
        }

        public IQueryable<UserList> FilterByList(string currentFilter, IQueryable<UserList> userlists)
        {
            if (currentFilter == null) return userlists;
            if (userlists == null) return null;
            if (currentFilter.Equals("all")) return userlists;
            return userlists.Where(s => s.ListType.Name.ToLower().Contains(currentFilter.ToLower()));
        }

        public void AddOrUpdate(UserList model)
        {
            UserList oldlist = Find(model.Id);
            if (oldlist == null)
            {
                model.CreatedDate = System.DateTime.Now;
                Add(model);
            }
            else if (_userService.IsOwner(oldlist.UserId))
            {
                oldlist.IsPublic = model.IsPublic;
                oldlist.Name = model.Name;
                oldlist.ListTypeId = model.ListTypeId;
                Update(oldlist);
            }


        }

        public bool UserDelete(int id)
        {
            UserList userList = Find(id);
            var IsOwner = _userService.IsOwner(userList?.UserId);
            if (!IsOwner || userList == null) return false;
            Delete(userList);
            return true;
        }

        public IQueryable<UserList> OwnerUserLists(int? userid)
        {
            var IsOwner = _userService.IsOwner(userid);
            IQueryable<UserList> userlists = null;
            if (IsOwner)
            {
                userlists = GetAll().Where(u => u.UserId == userid).AsQueryable();
            }
            else
            {
                userlists = GetAll().Where(u => u.UserId == userid && u.IsPublic == true).AsQueryable();
            }
            return userlists;



        }
    }
}
