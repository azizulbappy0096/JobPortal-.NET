﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.models
{
    internal class EmployerUser : User
    {

        public EmployerUser(int id, string fullName, string email, string password, string accountType, string phone) : base(id, fullName, email, password, accountType, phone)
        {

        }
    }
}