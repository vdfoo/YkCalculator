using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.Json;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.DAL
{
    public class MemberDal
    {
        public Member Read(int memberId)
        {
            Member result = new Member();
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
                        result.MemberId = Convert.ToInt32(dataReader["MemberId"]);
                        result.CreatedBy = Convert.ToString(dataReader["CreatedBy"]);
                        result.CreatedOn = Convert.ToDateTime(dataReader["CreatedOn"]);
                        string jsonMemberDetail = Convert.ToString(dataReader["Detail"]);
                        result.Detail = JsonSerializer.Deserialize<MemberDetail>(jsonMemberDetail);
                    }
                }

                connection.Close();
            }

            return result;
        }

        public List<Member> Search(string searchText)
        {
            List<Member> members = new List<Member>();
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = $"SELECT * From Member WHERE Detail LIKE @SearchText";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Member result = new Member();
                        result.MemberId = Convert.ToInt32(dataReader["MemberId"]);
                        result.CreatedBy = Convert.ToString(dataReader["CreatedBy"]);
                        result.CreatedOn = Convert.ToDateTime(dataReader["CreatedOn"]);
                        string jsonMemberDetail = Convert.ToString(dataReader["Detail"]);
                        result.Detail = JsonSerializer.Deserialize<MemberDetail>(jsonMemberDetail);

                        members.Add(result);
                    }
                }

                connection.Close();
            }

            return members;
        }

        public int Update(Member member)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonMemberDetail = JsonSerializer.Serialize(member.Detail);

                string sql = $"UPDATE Member SET Detail = @MemberDetail WHERE MemberId = @MemberId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberDetail", jsonMemberDetail);
                    command.Parameters.AddWithValue("@MemberId", member.MemberId);

                    connection.Open();
                    rowAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return rowAffected;
        }

        public int Delete(int memberId)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string sql = $"DELETE Member WHERE MemberId = @MemberId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberId", memberId);

                    connection.Open();
                    rowAffected = command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return rowAffected;
        }

        public int Insert(Member member)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonMemberDetail = JsonSerializer.Serialize(member.Detail);

                string sql = $"INSERT INTO Member (Detail, CreatedBy) VALUES (@MemberDetail, @CreatedBy);SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberDetail", jsonMemberDetail);
                    command.Parameters.AddWithValue("@CreatedBy", member.CreatedBy);

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
