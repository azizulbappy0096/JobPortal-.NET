using JobPortal.views.auth;
using JobPortal.views.common;
using JobPortal.views.dashboard.employer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.dashboard
{
    public partial class DEmployer : Form
    {
        private Login loginPage;
        private DCompanyProfile companyProfilePage;
        private DEmployerJobPost jobPostPage;
        private changepassword changepasswordpage;
        private allapplicants allapplicantsPage;
        private Managejobs managejobspage;
        private jobsearch jobSearchPage;

        public DEmployer()
        {
            InitializeComponent();
            
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel9.Controls.Clear();
            panel9.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            companyProfilePage = new DCompanyProfile();
            addUserControl(companyProfilePage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            jobPostPage = new DEmployerJobPost();
            addUserControl(jobPostPage);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (managejobspage == null)
            {
                managejobspage = new Managejobs();
                managejobspage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(managejobspage);
            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(managejobspage);
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            changepasswordpage = new changepassword();
            addUserControl(changepasswordpage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (allapplicantsPage == null) 
            {
                allapplicantsPage=new allapplicants();
                allapplicantsPage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(allapplicantsPage);


            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(allapplicantsPage);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            loginPage = new Login();
            this.Hide();
            loginPage.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jobSearchPage = new jobsearch();
            jobSearchPage.Show();
        }
    }
}
