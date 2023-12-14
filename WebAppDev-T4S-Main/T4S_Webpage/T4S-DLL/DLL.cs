
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using T4S_MODEL;

namespace T4S_DLL
{
    public class DLL
    {
        public string addUser(SignUpModel model)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
            SqlCommand cmd = new SqlCommand("registerSP", conn);
            cmd.Parameters.AddWithValue("@fName", model.firstName);
            cmd.Parameters.AddWithValue("@lName", model.lastName); ;
            cmd.Parameters.AddWithValue("@userID", model.userName);
            cmd.Parameters.AddWithValue("@password", model.password);
            cmd.Parameters.AddWithValue("@email", model.email);
            

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            
            if (cmd.ExecuteNonQuery() > 0)
                model.message = "Sign up successful for " + model.firstName + " " + model.lastName;
            else
                model.message = "Sign up failed for " + model.firstName + " " + model.lastName;

            return model.message;
        }

        public string SigningIn(SignInModel model)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ToString());
            SqlCommand cmd = new SqlCommand("logINSP", conn);
            cmd.Parameters.AddWithValue("@userID", model.userName);
            cmd.Parameters.AddWithValue("@password", model.password);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                model.message = "Login Successful";

            }
            else
            {
                model.message = "Login Failed";
                return model.message;
            }
            return model.message;
        }
    }
}
