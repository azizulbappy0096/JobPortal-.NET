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
        private DCompanyProfile companyProfilePage;
        private DEmployerJobPost jobPostPage;
        private changepassword changepasswordpage;

        public DEmployer()
        {
            InitializeComponent();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(companyProfilePage == null)
            {
                companyProfilePage = new DCompanyProfile();
                companyProfilePage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(companyProfilePage);
            }else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(companyProfilePage);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jobPostPage == null)
            {
                jobPostPage = new DEmployerJobPost();
                jobPostPage.Dock = DockStyle.Fill;
                panel9.Controls.Clear();
                panel9.Controls.Add(jobPostPage);
            }
            else
            {
                panel9.Controls.Clear();
                panel9.Controls.Add(jobPostPage);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           if(changepasswordpage == null)
            {
                changepasswordpage = new changepassword();
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
