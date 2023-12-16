using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.common
{
    public partial class jobsearch : Form
        
    {
        jobcard jobcardpage;
        public jobsearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jobcardpage == null)
            {
                jobcardpage = new jobcard();
                jobcardpage.Dock = DockStyle.Fill;
                panel2.Controls.Clear();
                panel2.Controls.Add(jobcardpage);
            }
            else
            {
                panel2.Controls.Clear();
                panel2.Controls.Add(jobcardpage);
            }
        }
    }
}
