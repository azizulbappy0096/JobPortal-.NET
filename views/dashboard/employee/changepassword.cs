using JobPortal.controllers;
using JobPortal.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.dashboard.employee
{
    public partial class changepassword : UserControl
    {
        Auth authControllers = new Auth();
        private string cPassword { get; set; }
        private string nPassword { get; set; }
        private string ccPassword { get; set; }
        public changepassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cPassword = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nPassword = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ccPassword = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nPassword != ccPassword)
            {
                MessageBox.Show("New password and confirm password didn't match");
                return;
            }
            Response<bool> res = authControllers.UpdatePassword(User.Id, cPassword, nPassword);
            if (res.success)
            {
                MessageBox.Show("Password updated");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
