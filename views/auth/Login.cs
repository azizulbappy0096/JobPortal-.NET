using JobPortal.views.common;
using JobPortal.views.dashboard;
using JobPortal.views.dashboard.employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.auth
{
    public partial class Login : Form
    {
        private DEmployer EmployerDashboard;
        private DEmployee EmployeeDashboard;
        private jobsearch jobsearchcommon;
        public Login()
        {
            InitializeComponent();
 
        }



        private void LoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployerDashboard = new DEmployer();
            this.Hide();
            EmployerDashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeDashboard=new DEmployee();
            this.Hide();
            EmployeeDashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jobsearchcommon = new jobsearch();
            this.Hide();
            jobsearchcommon.Show();
        }
    }
}
