using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.models
{
    internal class EmployerUser : User
    {

        public EmployerUser(string id, string firtsName, string lastName, string email, string accountType, string phone) : base(id, firtsName, lastName, email, accountType, phone)
        {

        }
    }
}
