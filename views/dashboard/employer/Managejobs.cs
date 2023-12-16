using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.views.dashboard.employer
{
    public partial class Managejobs : UserControl
    {
        view viewpage;
        public Managejobs()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewpage=new view();
            addUserControl(viewpage);
        }
    }
}
