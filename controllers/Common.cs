using JobPortal.database;
using JobPortal.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.controllers
{
    internal class Common
    {
        public Response<List<Job>> GetJobs()
        {
            EError err;
            Response<List<Job>> res;
            List<Job> jobs = new List<Job>();

            try
            {
                string query = "select * from jobs where disable=0";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["Id"].ToString();
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    string specialisms = reader["specialisms"].ToString();
                    string type = reader["type"].ToString();
                    string experience = reader["experience"].ToString();
                    string qualification = reader["qualification"].ToString();
                    string gender = reader["gender"].ToString();
                    string country = reader["country"].ToString();
                    string city = reader["city"].ToString();
                    string address = reader["address"].ToString();
                    string deadline = reader["deadline"].ToString();
                    string salary = reader["salary"].ToString();

                    jobs.Add(new Job(id, title, description, specialisms, type, salary, experience, qualification, gender, country, city, address, deadline));
                }

                reader.Close();

                err = new EError("");
                res = new Response<List<Job>>("success", true, err, jobs);
                return res;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                err = new EError(ex.Message);
                res = new Response<List<Job>>("error", false, err, jobs);
                return res;
            }
        }

        public Response<List<Job>> GetJobsByQuery(string qcity)
        {
            EError err;
            Response<List<Job>> res;
            List<Job> jobs = new List<Job>();

            try
            {
                string query = "select * from jobs where disable=0 and city=@v1";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", qcity);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["Id"].ToString();
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    string specialisms = reader["specialisms"].ToString();
                    string type = reader["type"].ToString();
                    string experience = reader["experience"].ToString();
                    string qualification = reader["qualification"].ToString();
                    string gender = reader["gender"].ToString();
                    string country = reader["country"].ToString();
                    string city = reader["city"].ToString();
                    string address = reader["address"].ToString();
                    string deadline = reader["deadline"].ToString();
                    string salary = reader["salary"].ToString();

                    jobs.Add(new Job(id, title, description, specialisms, type, salary, experience, qualification, gender, country, city, address, deadline));
                }

                reader.Close();

                err = new EError("");
                res = new Response<List<Job>>("success", true, err, jobs);
                return res;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                err = new EError(ex.Message);
                res = new Response<List<Job>>("error", false, err, jobs);
                return res;
            }
        }
    }
}
