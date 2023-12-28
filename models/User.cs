using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.models
{
    internal class User
    {
        public static string Id { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string AccountType { get; set; }
        public static string Phone {  get; set; }

        public User()
        {

        }
        public User(string id, string firstName, string lastName, string email, string accountType, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            AccountType = accountType;
            Phone = phone;
        }
    }
}
