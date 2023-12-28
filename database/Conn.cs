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
        public static SqlConnection connection;
        public Conn() {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\job_portal.mdf;Integrated Security=True;Connect Timeout=30;";


            connection = new SqlConnection(connectionString);
            
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    /*  string query = "select * from ussers";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();
                    while (reader.Read())
                    {
                        sb.Append(reader.GetInt32(0)+ " "+ reader.GetString(1) + " " + reader.GetString(3));
                        MessageBox.Show(sb.ToString());
                    }*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ErrorD: {ex.Message}");
                }
           


        }

        ~Conn()
        {
            // connection.Close();
        }
    }
}
