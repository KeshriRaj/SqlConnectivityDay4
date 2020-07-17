using Day4.Model;
using Day4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
namespace Day4
{
    public class Program
    {
        static void Main(string[] args)
        {
            applicationDB _db = new applicationDB();
            UserRepository initializeUser = new UserRepository();
            for (var i = 0; i < 10; i++)
            {
                user userData = new user();


                userData.name = "Kunal" + (i + 1);
                userData.location = "Bhagalpur" + (i + 1);
                userData.address = "Aliganj" + (i + 1);

                userData.email = "kunal" + (i + 1) + "@gmail.com";
                userData.isActive = (i + 1) % 2 == 0 ? true : false;


                _db.users.Add(userData);
                _db.SaveChanges();
            }



            List<user> AllUserData = new List<user>();
           AllUserData= initializeUser.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (user users in AllUserData)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);

            }




            Console.WriteLine();

            user getUser;
            Console.WriteLine("Enter the user id which you want to retrieve");
            int id = Convert.ToInt32(Console.ReadLine());
            getUser = initializeUser.GetUser(id);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            Console.WriteLine(getUser.id + "\t" + getUser.name + "\t" + getUser.email + "\t" + getUser.location + "\t" + getUser.address + "\t  " + getUser.isActive);







            Console.WriteLine();



            Console.WriteLine("Enter the id for User you want to Delete");
            int delUser = Convert.ToInt32(Console.ReadLine());
            List<user> delUserlist = new List<user>();
            delUserlist = initializeUser.DeleteUser(delUser);
            Console.WriteLine("List after deletion of User");
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (user users in delUserlist)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);

            }



            Console.WriteLine();


            List<user> ActiveUser = new List<user>();
            ActiveUser = initializeUser.ActiveUsers();
            Console.WriteLine("Active Users in List");
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (user users in ActiveUser)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);

            }





            Console.WriteLine();
            Console.WriteLine("Enter Users Details you want to add in the list");
            user addUser=new user();

            Console.WriteLine("Enter User Name");
             addUser.name = Console.ReadLine();

            Console.WriteLine("Enter User Email");
            addUser.email = Console.ReadLine() + "\t";

            Console.WriteLine("Enter User Location");
           addUser.location = Console.ReadLine();

            Console.WriteLine("Enter User Address");
            addUser.address = Console.ReadLine() + "\t";

            Console.WriteLine("Enter User Activity Status");
            addUser.isActive = Convert.ToBoolean(Console.ReadLine());

            List<user> UserListAfterAddition = new List<user>();
            UserListAfterAddition = initializeUser.AddUser(addUser);

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (user users in UserListAfterAddition)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);

            }

        }
    }
}
