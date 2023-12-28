using JobPortal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.services
{
    internal interface IAuth
    {
        bool Registration(string firstName, string lastName, string email, string accountType, string password);
        Response<User> Login(string email, string password);
        Response<bool> UpdatePassword(string userId, string cPassword, string nPassword);
    }
}
