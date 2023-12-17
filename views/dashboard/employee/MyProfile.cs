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

namespace JobPortal.views.dashboard.employee
{
    public partial class MyProfile : UserControl
    {
        public string FullName {  get; private set; }
        public string Email { get; private set; }
        public string Phone {  get; private set; }
        public string JobTitle { get; private set; }
        public string Website { get; private set; }
        public string Experience { get; private set; }
        public byte Age { get; private set; }
        public string Languages { get; private set; }
        public string EducationLevel { get; private set; }
        public string Bio { get; private set; }

        public MyProfile()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            textBox1.Text = EmployeeUser.FullName;
            textBox2.Text = EmployeeUser.Email;
            textBox3.Text = EmployeeUser.Phone;
            textBox4.Text = "Demo Jobtitle";
            textBox5.Text = "http://example.com";
            comboBox1.Text = "1 year";
            textBox6.Text = "" + 20;
            textBox7.Text = "Bangla, English";
            textBox8.Text = "HSC";
            richTextBox1.Text = "Some info";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.FullName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Email = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Phone = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.JobTitle = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.Website = textBox5.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Experience = comboBox1.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.Age = Convert.ToByte(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.Languages = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.EducationLevel = textBox8.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Bio = richTextBox1.Text;
        }
    }
}
