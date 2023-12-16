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

        public DEmployer()
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

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
