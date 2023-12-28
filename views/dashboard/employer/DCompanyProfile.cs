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
    public partial class DCompanyProfile : UserControl
    {
        private HelperF functions = new HelperF();
        private EmployerControllers eControllers = new EmployerControllers();
        private Company companyData;

        public DCompanyProfile()
        {
            InitializeComponent();
            
            Response<Company> res = eControllers.GetCompanyDetails(EmployerUser.Id);

            if(res.success == true )
            {
                companyData = res.Data;

                comboBox1.Text = companyData.teamSize;
                richTextBox1.Text = companyData.bio;
                textBox1.Text = companyData.name;
                textBox3.Text = companyData.phone;
                textBox4.Text = companyData.website;
                textBox5.Text = companyData.established;
            }else
            {
                companyData = new Company();
                companyData.Id = functions.GenerateUniqueHexValue();
            }
            

        }

        private void DCompanyProfile_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            companyData.teamSize = comboBox1.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            companyData.bio = richTextBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            companyData.name = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            companyData.phone = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            companyData.website = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            companyData.established = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Response<Company> res = eControllers.UpdateCompanyDetails(companyData);

            if(res.success)
            {
                companyData = res.Data;
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again");
            }
        }
    }
}
