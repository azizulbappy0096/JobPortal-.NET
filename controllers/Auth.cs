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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JobPortal.controllers
{
    internal class Auth:IAuth
    {
        private HelperF functions = new HelperF();

        public bool Registration(string firstName, string lastName, string email, string accountType, string password)
        {
            try
            {
                string query = "insert into ussers (id, firstName, lastName, email, password, accountType) values (@v1, @v2, @v3, @v4, @v5, @v6)";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", functions.GenerateUniqueHexValue());
                cmd.Parameters.AddWithValue("@v2", firstName);
                cmd.Parameters.AddWithValue("@v3", lastName);
                cmd.Parameters.AddWithValue("@v4", email);
                cmd.Parameters.AddWithValue("@v5", password);
                cmd.Parameters.AddWithValue("@v6", accountType);

                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine("Reg: " + rowsAffected);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Response<User> Login(string email, string password)
        {
            EError err;
            Response<User> res;
            User user;

            int disable;
            string id;
            string firstName;
            string lastName;
            string phone;
            string accountType;
            string uEmail;

            try
            {
                string query = "select * from ussers where email=@v1 and password=@v2";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", email);
                cmd.Parameters.AddWithValue("@v2", password);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    disable = Convert.ToInt32(reader["disable"]);
                    id = reader["ID"].ToString();
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();
                    phone = reader["phone"].ToString();
                    accountType = reader["accountType"].ToString();
                    uEmail = reader["email"].ToString();
                   
                    reader.Close();
                    if (disable == 1)
                    {
                        user = new User();
                        err = new EError("Your account has been disabled!");
                        res = new Response<User>("error", false, err, user);
                        return res;
                    }
                    else
                    {
                        user = new User(id, firstName, lastName, email, accountType, phone);
                        err = new EError("");
                        res = new Response<User>("error", true, err, user);
                        return res;
                    }
                }
                reader.Close();
                user = new User();
                err = new EError("Please try again");
                res = new Response<User>("error", false, err, user);
                return res;

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
                user = new User();
                err = new EError(ex.Message);
                res = new Response<User>("error", false, err, user);
                return res;
            }
        }

        public Response<bool> UpdatePassword(string userId, string cPassword, string nPassword)
        {
            EError err;
            Response<bool> res;
          

            try
            {
                string query = "select password from ussers where id=@v1 and password=@v2";
                SqlCommand cmd = new SqlCommand(query, Conn.connection);

                cmd.Parameters.AddWithValue("@v1", userId);
                cmd.Parameters.AddWithValue("@v2", cPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    reader.Close();
                    query = "update ussers set password=@v1 where id=@v1";
                    cmd = new SqlCommand(query, Conn.connection);

                    cmd.Parameters.AddWithValue("@v1", nPassword);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        err = new EError("");
                        res = new Response<bool>("error", true, err, true);
                        return res;
                    }else
                    {
                        err = new EError("Invalid current password");
                        res = new Response<bool>("error", false, err, false);
                        return res;
                    }

                }else
                {
                    err = new EError("Invalid");
                    res = new Response<bool>("error", false, err, false);
                    return res;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
              
                err = new EError(ex.Message);
                res = new Response<bool>("error", false, err, false);
                return res;
            }
        }


    }
}
