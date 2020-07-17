using System;
using System.Collections.Generic;
using System.Text;
using Day4.Model;
namespace Day4.Repository
{
    interface IUserRepository
    {
        public List<user> Users();
        public user GetUser(int id);
        public List<user> DeleteUser(int id);
        public List<user> ActiveUsers();

        public List<user> AddUser(user users);

    }
}
