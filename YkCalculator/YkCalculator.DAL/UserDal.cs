using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.DAL
{
    public class UserDal
    {
        public User Read(string username)
        {
            User user = new User();
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = $"SELECT TOP 1 * FROM UserDetail WHERE Username = @Username";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    dataReader.Read();
                    user.Username = Convert.ToString(dataReader["Username"]);
                    user.Name = Convert.ToString(dataReader["Name"]);
                    user.Password = Convert.ToString(dataReader["Password"]);
                    user.Admin = Convert.ToBoolean(dataReader["Admin"]);
                }

                connection.Close();
            }

            return user;
        }
    }
}
