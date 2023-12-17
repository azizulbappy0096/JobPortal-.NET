using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.models
{
    internal class User
    {
        public static int Id { get; set; }
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string AccountType { get; set; }
        public static string Phone {  get; set; }
        public User(int id, string fullName, string email, string password, string accountType, string phone)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;
            AccountType = accountType;
            Phone = phone;
        }
    }
}
