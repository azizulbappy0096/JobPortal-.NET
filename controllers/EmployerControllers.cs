using JobPortal.database;
using JobPortal.models;
using JobPortal.services;
using JobPortal.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JobPortal.controllers
{
    internal class EmployerControllers:IEmployer
    {
        public Response<Company> GetCompanyDetails(string userId)
        {
            EError err;
            Response<Company> res;
            Company company;

            try
            {
                string query = "select * from company where \"user\"=@v1";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int disable = Convert.ToInt32(reader["disable"]);
                    string id = reader["ID"].ToString();
                    string name = reader["name"].ToString();
                    string phone = reader["phone"].ToString();
                    string website = reader["website"].ToString();
                    string established = reader["established"].ToString();
                    string teamSize = reader["teamSize"].ToString();
                    string bio = reader["bio"].ToString();

                    reader.Close();
                    if (disable == 1)
                    {
                        company = new Company();
                        err = new EError("Company info not found");
                        res = new Response<Company>("error", false, err, company);
                        return res;
                    }
                    else
                    {
                        company = new Company(id, name, phone, website, established, teamSize, bio);
                        err = new EError("");
                        res = new Response<Company>("error", true, err, company);
                        return res;
                    }
                }

                reader.Close();
                company = new Company();
                err = new EError("Please try again");
                res = new Response<Company>("error", false, err, company);
                return res;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                company = new Company();
                err = new EError(ex.Message);
                res = new Response<Company>("error", false, err, company);
                return res;
            }
        }

        public Response<Company> UpdateCompanyDetails(Company cData)
        {
            EError err;
            Response<Company> res;
            Company company;

            try
            {
                string query = "select * from company where id=@v1";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", cData.Id);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if(reader.Read())
                {
                    reader.Close();

                    query = "update company set name=@v1, phone=@v2, website=@v3, established=@v4, teamSize=@v5, bio=@v6 where id=@v7";
                    cmd = new SqlCommand(query, Conn.connection);

                    cmd.Parameters.AddWithValue("@v7", cData.Id);
                    cmd.Parameters.AddWithValue("@v1", cData.name);
                    cmd.Parameters.AddWithValue("@v2", cData.phone);
                    cmd.Parameters.AddWithValue("@v3", cData.website);
                    cmd.Parameters.AddWithValue("@v4", cData.established);
                    cmd.Parameters.AddWithValue("@v5", cData.teamSize);
                    cmd.Parameters.AddWithValue("@v6", cData.bio);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        company = new Company();
                        err = new EError("");
                        res = new Response<Company>("error", true, err, company);
                        return res;
                    }else
                    {
                        company = new Company();
                        err = new EError("Couldn't update company info, please try again");
                        res = new Response<Company>("error", false, err, company);
                        return res;
                    }
                }else
                {
                    reader.Close();

                    query = "insert into company (Id, name, phone, website, established, teamSize, bio, \"user\") values(@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8)";
                    cmd = new SqlCommand(query, Conn.connection);

                    cmd.Parameters.AddWithValue("@v1", cData.Id);
                    cmd.Parameters.AddWithValue("@v2", cData.name);
                    cmd.Parameters.AddWithValue("@v3", cData.phone);
                    cmd.Parameters.AddWithValue("@v4", cData.website);
                    cmd.Parameters.AddWithValue("@v5", cData.established);
                    cmd.Parameters.AddWithValue("@v6", cData.teamSize);
                    cmd.Parameters.AddWithValue("@v7", cData.bio);
                    cmd.Parameters.AddWithValue("@v8", User.Id);


                    cmd.ExecuteNonQuery();

                }

                reader.Close();
                company = new Company();
                err = new EError("Please try again");
                res = new Response<Company>("error", false, err, company);
                return res;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                company = new Company();
                err = new EError(ex.Message);
                res = new Response<Company>("error", false, err, company);
                return res;
            }
        }

        public Response<Job> PostJob(Job job)
        {
            EError err;
            Response<Job> res;
            Job jobe;

            try
            {
                string query = "insert into jobs (Id, title, description, specialisms, type, salary, experience, qualification, gender, country, city, address, deadline, \"user\") values(@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9, @v10, @v11, @v12, @v13, @v14)";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);
                Console.WriteLine(job.Id);
                Console.WriteLine(job.title);
                cmd.Parameters.AddWithValue("@v1", job.Id);
                cmd.Parameters.AddWithValue("@v2", job.title);
                cmd.Parameters.AddWithValue("@v3", job.description);
                cmd.Parameters.AddWithValue("@v4", job.specialisms);
                cmd.Parameters.AddWithValue("@v5", job.type);
                cmd.Parameters.AddWithValue("@v6", job.salary);
                cmd.Parameters.AddWithValue("@v7", job.experience);
                cmd.Parameters.AddWithValue("@v8", job.qualification);
                cmd.Parameters.AddWithValue("@v9", job.gender);
                cmd.Parameters.AddWithValue("@v10", job.country);
                cmd.Parameters.AddWithValue("@v11", job.city);
                cmd.Parameters.AddWithValue("@v12", job.address);
                cmd.Parameters.AddWithValue("@v13", job.deadline);
                cmd.Parameters.AddWithValue("@v14", User.Id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    jobe = new Job();
                    err = new EError("");
                    res = new Response<Job>("error", true, err, jobe);
                    return res;
                }
                else
                {
                    jobe = new Job();
                    err = new EError("Couldn't post, internal error");
                    res = new Response<Job>("error", false, err, jobe);
                    return res;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                jobe = new Job();
                err = new EError(ex.Message);
                res = new Response<Job>("error", false, err, jobe);
                return res;
            }
        }

        public Response<List<Job>> GetJobs(string userId)
        {
            EError err;
            Response<List<Job>> res;
            List<Job> jobs = new List<Job>();

            try
            {
                string query = "select * from jobs where \"user\"=@v1 and disable=0";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", EmployerUser.Id);
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

        public Response<bool> DeleteJob(string jobId)
        {
            EError err;
            Response<bool> res;
            
            try
            {
                string query = "update jobs set disable=1 where Id=@v1";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", jobId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    err = new EError("");
                    res = new Response<bool>("error", true, err, true);
                    return res;
                }
                else
                {
                    err = new EError("Wrong");
                    res = new Response<bool>("error", false, err, false);
                    return res;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                err = new EError(ex.Message);
                res = new Response<bool>("error", false, err, false);
                return res;
            }
        }
    }
}
