using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using YkCalculator.Utility;

namespace YkCalculator.DAL
{
    public class MemberDal
    {
        public int Read(int memberId)
        {
            int resultMemberId = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = $"SELECT * From Member WHERE MemberId = @MemberId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MemberId", memberId);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        resultMemberId = Convert.ToInt32(dataReader["MemberId"]);
                    }
                }

                connection.Close();
            }

            return resultMemberId;
        }

        public int Insert()
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string sql = $"INSERT INTO Member (Phone) VALUES ('');SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }

            return id;
        }

        public int InsertMemberOrder(int orderId, int memberId)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string sql = $"INSERT INTO MemberOrder (MemberId, OrderId) VALUES (@MemberId, @OrderId);SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberId", memberId);
                    command.Parameters.AddWithValue("@OrderId", orderId);

                    connection.Open();
                    id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }

            return id;
        }
    }
}
