using InterfaceLibrary.Task.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using static Utils.Enum.Enum;

namespace InterfaceLibrary.Task.Models
{
    class User : IEntity
    {
        private static int _id;
        public int ID { get; }

        public string Username { get; set; }
        public string Email { get; set; }
        public Role Roles { get; set; }

        public User(string username, string email, Role role)
        {
            _id++;
            ID = _id;
            Username = username;
            Email = email;
            Roles = role;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"User ID: {ID}\n" +
                $"User Role: {Roles}" +
                $"Username: {Username}\n" +
                $"Email: {Email}\n");
        }
    }
}
