using JobPortal.controllers;
using JobPortal.models;
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

namespace JobPortal.views.common
{
    public partial class jobsearch : Form
        
    {
        private Common commonController = new Common();
        private List<Job> jobs = new List<Job>();

        private string _location {  get; set; }
        public jobsearch()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            Response<List<Job>> res = commonController.GetJobs();
            jobcard[] lists = new jobcard[res.Data.Count];
          
            for (int i = 0; i < res.Data.Count; i++)
            {

                lists[i] = new jobcard(res.Data[i].title, res.Data[i].city, res.Data[i].country, res.Data[i].salary, res.Data[i].type);
                flowLayoutPanel1.Controls.Add(lists[i]);

            }

            if (!res.success)
            {
                MessageBox.Show("No job found");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(_location))
            {
                MessageBox.Show("Invalid: location field is empty");
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            Response<List<Job>> res = commonController.GetJobsByQuery(_location);
            jobcard[] lists = new jobcard[res.Data.Count];

            for (int i = 0; i < res.Data.Count; i++)
            {

                lists[i] = new jobcard(res.Data[i].title, res.Data[i].city, res.Data[i].country, res.Data[i].salary, res.Data[i].type);
                flowLayoutPanel1.Controls.Add(lists[i]);

            }

            if (!res.success)
            {
                MessageBox.Show("No job found");
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _location = textBox2.Text;
        }
    }
}
