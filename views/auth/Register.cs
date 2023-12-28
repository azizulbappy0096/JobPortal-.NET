using JobPortal.controllers;
using JobPortal.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.auth
{
    public partial class Register : Form
    {

        private Auth AuthControllers = new Auth();
        private HelperF functions = new HelperF();

        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string accountType;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.password = textBox3.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.lastName = textBox4.Text;
        }

        private void RegisterTitle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.email) || !functions.IsEmailValid(this.email))
            {
                MessageBox.Show("Invalid e-mail address, please try again");
                return;
            }
            bool res = AuthControllers.Registration(firstName, lastName, email, accountType, password);

            if(res)
            {
                Login login = new Login();
                MessageBox.Show("Registration successfull");
                login.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.firstName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.email = textBox2.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.accountType = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.accountType = radioButton2.Text;
        }
    }
}
