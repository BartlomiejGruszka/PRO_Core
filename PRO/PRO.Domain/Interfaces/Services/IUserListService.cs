﻿using PRO.Entities;
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
        public UserList Find(int? id);
        public void Add(UserList userList);
        public void Delete(UserList userList);

        public void Update(UserList userList);
    }
}