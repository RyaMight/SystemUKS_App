using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemUKS_with_Login
{
    internal class UserStorage
    {
        public static List<User> Users = new List<User>()
        {
            new User("Rayasa", "1324") // User default
        };
    }

    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}