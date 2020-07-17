using Day4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Day4.Repository
{
   public class UserRepository:IUserRepository
    {
        public UserRepository()
        {
        }

        List<user> AllUserData = new List<user>();
        applicationDB _db = new applicationDB();
        public List<user> Users()
        {
            AllUserData = _db.users.ToList();
            if (AllUserData.Any())
            {
                Console.WriteLine("Returned List of Users");
            }
            else
            {
                Console.WriteLine("No data found");
            }
            return AllUserData;
        }
        public user GetUser(int id)
        {
            user person = _db.users.Where(a => a.id == id).FirstOrDefault();

            if(person!=null)
            {
                Console.WriteLine("Retrieving User Data with id=" + id);
            }
            else
            {
                Console.WriteLine("There is no User with id=" + id);
            }
            return person;
        }

        public List<user> DeleteUser(int id)
        {
            user person = _db.users.Where(a => a.id == id).FirstOrDefault();
            if (person != null)
            {
                _db.users.Remove(person);
                _db.SaveChanges();
            }
            else
            {
                Console.WriteLine("no data found for this id");
            }
            return Users();
        }
        List<user> ActiveUser = new List<user>();
        public List<user> ActiveUsers()
        {
            var x = from u in _db.users
                         where u.isActive == true
                         select u;
            foreach(user activeuser in x)
            {
                ActiveUser.Add(activeuser);
            }
            return ActiveUser;

        }

        public List<user> AddUser(user addUser)
        {
            _db.users.Add(addUser);
            _db.SaveChanges();
            return Users();
        }
    }
}
