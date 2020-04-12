using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.Json;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.DAL
{
    public class OrderDal
    {
        public Order Read(int orderId, bool detail = false)
        {
            Order order = new Order();
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = $"SELECT * From OrderDetail WHERE Id = @OrderId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@OrderId", orderId);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader["Id"]);
                        DateTime createdOn = Convert.ToDateTime(dataReader["CreatedOn"]);
                        int createdBy = Convert.ToInt32(dataReader["CreatedBy"]);
                        string jsonQuotationId = Convert.ToString(dataReader["QuotationId"]);
                        if (!string.IsNullOrEmpty(jsonQuotationId))
                        {
                            List<string> quotationId = JsonSerializer.Deserialize<List<string>>(jsonQuotationId);

                            order.CreatedBy = createdBy;
                            order.CreatedOn = createdOn;
                            order.Id = id;
                            order.QuotationId = quotationId;
                        }

                        if(detail)
                        {
                            QuotationDal dal = new QuotationDal();
                            List<Output> quotationDetails = new List<Output>();
                            foreach (string quotationId in order.QuotationId)
                            {
                                Output quotationDetail = dal.Read(Convert.ToInt32(quotationId));
                                quotationDetails.Add(quotationDetail);
                            }

                            order.QuotationDetail = quotationDetails;
                        }
                    }
                }

                connection.Close();
            }

            return order;
        }

        public List<Order> ReadAll(int userId = 0) 
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = string.Empty;
                if(userId != 0)
                    sql = $"SELECT Id, CreatedOn FROM OrderDetail WHERE CreatedBy = @UserId";
                else
                    sql = $"SELECT Id, CreatedOn FROM OrderDetail";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Order order = new Order();
                        order.Id = Convert.ToInt32(dataReader["Id"]);
                        order.CreatedOn = Convert.ToDateTime(dataReader["CreatedOn"]);
                        orders.Add(order);
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public int Insert(Order order)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonQuotationId = JsonSerializer.Serialize(order.QuotationId);
                string sql = "INSERT INTO OrderDetail (QuotationId, CreatedBy) VALUES (@QuotationId, @CreatedBy);SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@QuotationId", jsonQuotationId);
                    command.Parameters.AddWithValue("@CreatedBy", order.CreatedBy);
                    connection.Open();
                    id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }

            return id;
        }

        public int Update(Order order)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonQuotationId = JsonSerializer.Serialize(order.QuotationId);
                string sql = "UPDATE OrderDetail SET QuotationId = @QuotationId WHERE Id = @OrderId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@QuotationId", jsonQuotationId);
                    command.Parameters.AddWithValue("@OrderId", order.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return id;
        }
    }
}
