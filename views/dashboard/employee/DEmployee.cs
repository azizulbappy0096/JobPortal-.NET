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
    public partial class DEmployee : Form
    {
        MyProfile profilepage;
        MyResume myresumepage;
        appliedjobs appliedjobpage;
        cvmanager cvmanagerpage;
        changepassword changepasswordpage;

        public DEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(profilepage==null)
            {
                profilepage = new MyProfile();
                profilepage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(profilepage);

            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(profilepage);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myresumepage==null) 
            {
                myresumepage = new MyResume();
                myresumepage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(myresumepage);
            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(myresumepage);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (appliedjobpage == null)
            {
                appliedjobpage = new appliedjobs();
                appliedjobpage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(appliedjobpage);

            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(appliedjobpage);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cvmanagerpage == null)
            {
                cvmanagerpage = new cvmanager();
                cvmanagerpage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(cvmanagerpage);
            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(cvmanagerpage);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (changepasswordpage==null)
            {
                changepasswordpage=new changepassword();
                changepasswordpage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(changepasswordpage);

            }
            else
            {
                panel9.Controls.Clear();
               panel9.Controls.Add(changepasswordpage);
            }
        }
    }
}
