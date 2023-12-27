using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal.database
{
    internal class Conn
    {
        public static SqlConnection con;
        public Conn() {

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\job_portal.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            
        }

        ~Conn()
        {
            con.Close();
        }
    }
}
