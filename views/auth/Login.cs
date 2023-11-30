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
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Show();
            this.Hide();
        }
    }
}
