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
    public partial class jobcard : UserControl
    {
        private string title {  get; set; }
        private string city { get; set; }
        private string country { get; set; }
        private string salary { get; set; }
        private string type { get; set; }
      
        public jobcard()
        {
            InitializeComponent();

        }

        public jobcard(string title, string city, string country, string salary, string type)
        {
            InitializeComponent();

            this.title = title;
            this.city = city;
                this.country = country;
            this.salary = salary;
            this.type = type;

            label1.Text = title;
            label3.Text = city + ", " + country;
            label5.Text = "$" + salary;
            label4.Text = type;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
             
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
