using JobPortal.controllers;
using JobPortal.database;
using JobPortal.models;
using JobPortal.utils;
using JobPortal.views.common;
using JobPortal.views.dashboard;
using JobPortal.views.dashboard.employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.auth
{
    public partial class Login : Form
    {
        private HelperF functions = new HelperF();
        private Auth AuthControllers = new Auth();

        private DEmployer EmployerDashboard;
        private DEmployee EmployeeDashboard;
        private jobsearch jobsearchcommon;

        private User CurrentUser;

        private string Email {  get; set; }
        private string Password { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void LoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Email = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if (String.IsNullOrEmpty(this.Email) || !functions.IsEmailValid(this.Email))
            {
                MessageBox.Show("Invalid e-mail address, please try again");
                return;
            }
            Response<User> res = AuthControllers.Login(Email, Password);

            Console.WriteLine(res.success);

            if(res.success)
            {
                Console.WriteLine(User.Id);
                if (User.AccountType.Trim() == "Employer")
                {
                    CurrentUser = (EmployerUser)CurrentUser;

                    EmployerDashboard = new DEmployer();
                    this.Hide();
                    EmployerDashboard.Show();
                }
                else if(User.AccountType.Trim() == "Employee")
                {
                    CurrentUser = (EmployeeUser)CurrentUser;
                    EmployeeDashboard = new DEmployee();
                    this.Hide();
                    EmployeeDashboard.Show();
                }
                return;
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jobsearchcommon = new jobsearch();
            this.Hide();
            jobsearchcommon.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Password = textBox2.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
