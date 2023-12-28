using JobPortal.controllers;
using JobPortal.models;
using JobPortal.views.common;
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
        EmployerControllers eControllers = new EmployerControllers();

        List<Job> jobs = new List<Job>();
        public Managejobs()
        {
            InitializeComponent();
            Response<List<Job>> res = eControllers.GetJobs(User.Id);
            view[] lists = new view[res.Data.Count];

            for (int i = 0; i < res.Data.Count; i++) 
            {
                
                    lists[i] = new view(res.Data[i].title, res.Data[i].deadline, res.Data[i].Id);
                    flowLayoutPanel1.Controls.Add(lists[i]);
                
            }

            if(!res.success)
            {
                MessageBox.Show("No job found");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
