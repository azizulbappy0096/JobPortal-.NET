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

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel7.Controls.Clear();
            panel7.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            profilepage = new MyProfile();
            addUserControl(profilepage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myresumepage = new MyResume();
            addUserControl(myresumepage);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            appliedjobpage = new appliedjobs();
            addUserControl(appliedjobpage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cvmanagerpage = new cvmanager();
            addUserControl(cvmanagerpage);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            changepasswordpage=new changepassword();
            addUserControl(changepasswordpage);
        }

        private void DEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
