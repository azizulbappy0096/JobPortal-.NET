using JobPortal.database;
using JobPortal.models;
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
   
            if (String.IsNullOrEmpty(this.Email) || !IsEmailValid(this.Email))
            {
                MessageBox.Show("Invalid e-mail address, please try again");
                return;
            }

            if(this.Email == "employer@gmail.com" && this.Password == "demo")
            {
                EmployerDashboard = new DEmployer();
                this.Hide();
                EmployerDashboard.Show();
                CurrentUser = new EmployerUser(1, "Demo Employer", "employer@gmail.com", "demo", "employer", "019275123");
                return;
            }else if (this.Email == "employee@gmail.com" && this.Password == "demo")
            {
                EmployeeDashboard = new DEmployee();
                this.Hide();
                EmployeeDashboard.Show();
                CurrentUser = new EmployeeUser(2, "Demo Employee", "employee@gmail.com", "demo", "employee", "019275123");
                return;
            }

            MessageBox.Show("Invalid credentials, please try again");
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

        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
    }
}
