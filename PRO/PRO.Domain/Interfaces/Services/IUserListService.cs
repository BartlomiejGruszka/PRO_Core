using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IUserListService
    {
        public IEnumerable<UserList> GetAll();
        public IEnumerable<UserList> GetUserUserLists(int? userid);
        public UserList Find(int? id);
        public void Add(UserList userList);
        public void Delete(UserList userList);

        public void Update(UserList userList);
        public ModelStateDictionary ValidateUserList(UserList userList);
        IQueryable<UserList> FilterSearch(string query);
        IQueryable<UserList> SortList(string sortOrder, IQueryable<UserList> userlists);
        IQueryable<UserList> FilterByList(string currentFilter, IQueryable<UserList> userlists);
        void AddOrUpdate(UserList model);
    }
}
