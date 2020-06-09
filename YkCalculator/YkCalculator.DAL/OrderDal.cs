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
        public string ConstructSearchOrderQuery(SearchOrderCondition condition)
        {
            DateTime systemDefaultDate = new DateTime();

            string sql = "SELECT Id, CreatedOn, CreatedBy FROM OrderDetail";

            // Ensure there are some condition set
            if (condition.Username.Trim() != string.Empty ||
                condition.OrderId != 0 ||
                condition.OrderIdFrom != 0 ||
                condition.OrderIdTo != 0 ||
                condition.DateFrom != systemDefaultDate ||
                condition.DateTo != systemDefaultDate)
            {
                sql += " WHERE ";
            }

            if (condition.Username.Trim() != string.Empty)
            {
                UserDal userDal = new UserDal();
                User user = userDal.Read(condition.Username);
                if (!user.Admin)
                {
                    sql += "CreatedBy = @Username ";
                }
            }

            if (condition.OrderId != 0)
            {
                sql += "AND Id = @OrderId ";
            }
            else
            {
                if (condition.OrderIdFrom != 0)
                    sql += "AND Id >= @OrderIdFrom ";

                if (condition.OrderIdTo != 0)
                    sql += "AND Id <= @OrderIdTo ";
            }


            if (condition.DateFrom != systemDefaultDate)
            {
                sql += "AND CreatedOn >= @DateFrom ";
            }

            if (condition.DateTo != systemDefaultDate)
            {
                sql += "AND CreatedOn <= @DateTo ";
            }

            // Clean up
            if (!sql.Contains("="))
            {
                sql = sql.Replace("WHERE", string.Empty);
            }

            if (sql.Contains("WHERE AND"))
            {
                sql = sql.Replace("WHERE AND", "WHERE");
            }

            sql = sql + " ORDER BY CreatedOn DESC OFFSET @OffSet ROWS FETCH NEXT 50 ROWS ONLY";

            return sql;
        }

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
                        string createdBy = Convert.ToString(dataReader["CreatedBy"]);
                        double totalBeforeDiscount = Convert.ToDouble(dataReader["TotalBeforeDiscount"]);
                        double totalAfterDiscount = Convert.ToDouble(dataReader["TotalAfterDiscount"]);
                        int memberId = Convert.ToInt32(dataReader["MemberId"]);
                        double totalTailorKeping = Convert.ToInt32(dataReader["TotalTailorKeping"]);

                        bool pasangRumah = false;
                        if (dataReader["PasangRumah"] != DBNull.Value)
                        {
                            pasangRumah = Convert.ToBoolean(dataReader["PasangRumah"]);
                        }

                        string jsonQuotationId = Convert.ToString(dataReader["QuotationId"]);
                        if (!string.IsNullOrEmpty(jsonQuotationId))
                        {
                            List<string> quotationId = JsonSerializer.Deserialize<List<string>>(jsonQuotationId);

                            order.CreatedBy = createdBy;
                            order.CreatedOn = createdOn;
                            order.Id = id;
                            order.QuotationId = quotationId;
                            order.TotalBeforeDiscount = totalBeforeDiscount;
                            order.TotalAfterDiscount = totalAfterDiscount;
                            order.MemberId = memberId;
                            order.TotalTailorKeping = totalTailorKeping;
                            order.PasangRumah = pasangRumah;
                        }

                        LoadQuotationDetails(detail, order);
                    }
                }

                connection.Close();
            }

            return order;
        }

        private static void LoadQuotationDetails(bool detail, Order order)
        {
            if (detail)
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

        //public List<Order> ReadAll(int offset, string userId = "")
        //{
        //    List<Order> orders = new List<Order>();
        //    using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
        //    {
        //        connection.Open();
        //        string sql = string.Empty;
        //        if(userId != string.Empty)
        //            sql = $"SELECT Id, CreatedOn, CreatedBy FROM OrderDetail WHERE CreatedBy = @UserId";
        //        else
        //            sql = $"SELECT Id, CreatedOn, CreatedBy FROM OrderDetail";

        //        sql = sql + " ORDER BY CreatedOn DESC OFFSET @OffSet ROWS FETCH NEXT 50 ROWS ONLY";
        //        SqlCommand command = new SqlCommand(sql, connection);
        //        command.Parameters.AddWithValue("@UserId", userId);
        //        command.Parameters.AddWithValue("@OffSet", offset);
        //        using (SqlDataReader dataReader = command.ExecuteReader())
        //        {
        //            while (dataReader.Read())
        //            {
        //                Order order = new Order();
        //                order.Id = Convert.ToInt32(dataReader["Id"]);
        //                order.CreatedOn = Convert.ToDateTime(dataReader["CreatedOn"]);
        //                order.CreatedBy = Convert.ToString(dataReader["CreatedBy"]);
        //                orders.Add(order);
        //            }
        //        }

        //        connection.Close();
        //    }

        //    return orders;
        //}

        public List<Order> ReadAllByCondition(SearchOrderCondition condition)
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = ConstructSearchOrderQuery(condition);
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", condition.Username.Trim());
                command.Parameters.AddWithValue("@OffSet", condition.Offset);
                command.Parameters.AddWithValue("@OrderId", condition.OrderId);
                command.Parameters.AddWithValue("@OrderIdFrom", condition.OrderIdFrom);
                command.Parameters.AddWithValue("@OrderIdTo", condition.OrderIdTo);
                command.Parameters.AddWithValue("@DateFrom", condition.DateFrom);
                command.Parameters.AddWithValue("@DateTo", condition.DateTo);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Order order = new Order();
                        order.Id = Convert.ToInt32(dataReader["Id"]);
                        order.CreatedOn = Convert.ToDateTime(dataReader["CreatedOn"]);
                        order.CreatedBy = Convert.ToString(dataReader["CreatedBy"]);
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
                string sql = 
                    "INSERT INTO OrderDetail (QuotationId, CreatedBy, TotalBeforeDiscount, TotalAfterDiscount, MemberId, TotalTailorKeping, PasangRumah) " +
                    "VALUES (@QuotationId, @CreatedBy, @TotalBeforeDiscount, @TotalAfterDiscount, @MemberId, @TotalTailorKeping, @PasangRumah);" +
                    "SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@QuotationId", jsonQuotationId);
                    command.Parameters.AddWithValue("@CreatedBy", order.CreatedBy);
                    command.Parameters.AddWithValue("@TotalBeforeDiscount", order.TotalBeforeDiscount);
                    command.Parameters.AddWithValue("@TotalAfterDiscount", order.TotalAfterDiscount);
                    command.Parameters.AddWithValue("@MemberId", order.MemberId);
                    command.Parameters.AddWithValue("@TotalTailorKeping", order.TotalTailorKeping);
                    command.Parameters.AddWithValue("@PasangRumah", order.PasangRumah);
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
