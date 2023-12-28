using JobPortal.controllers;
using JobPortal.models;
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
    public partial class view : UserControl
    {
        EmployerControllers employerControllers = new EmployerControllers();
        private string _id;
        private string _title;
        private string _deadline;

        public view()
        {
            InitializeComponent();
        }

        public view(string title, string deadline, string id)
        {
            InitializeComponent();
            this._title = title;
            this._deadline = deadline;
            this._id = id;

            label1.Text = _deadline;
            label5.Text = _title;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Response<bool> res = employerControllers.DeleteJob(this._id);

            if(res.success)
            {
                this.Hide();
                MessageBox.Show("Job deleted successfully");
            }else
            {
                MessageBox.Show("Something went wrong");

            }
        }
    }
}
