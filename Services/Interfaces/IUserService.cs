using System;
using Entities;
using System.Collections.Generic;

namespace server.Interfaces
{
    interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
        User Reset(string username);
    }
}