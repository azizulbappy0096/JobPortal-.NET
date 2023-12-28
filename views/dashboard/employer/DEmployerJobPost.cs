using JobPortal.controllers;
using JobPortal.models;
using JobPortal.utils;
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
    public partial class DEmployerJobPost : UserControl
    {
        HelperF functions = new HelperF();
        EmployerControllers econtrollers = new EmployerControllers();
        private Job jobDetails;
        public DEmployerJobPost()
        {
            InitializeComponent();
            jobDetails = new Job();
            jobDetails.Id = functions.GenerateUniqueHexValue();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            jobDetails.title = textBox6.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            jobDetails.description = richTextBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            jobDetails.specialisms = textBox4.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.type = comboBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.salary = comboBox1.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.experience = comboBox3.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.qualification = comboBox5.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.gender = comboBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            jobDetails.deadline = textBox3.Text;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.country = comboBox7.Text;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobDetails.city = comboBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            jobDetails.address = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Response<Job> res = econtrollers.PostJob(jobDetails);

            if(res.success)
            {
                MessageBox.Show("Job posted");
            }else
            {
                MessageBox.Show("Something went wrong, please try again!");
            }
        }
    }
}
