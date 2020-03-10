using System;
using YkCalculator.Model;
using System.Text.Json;
using YkCalculator.Utility;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace YkCalculator.DAL
{
    public class Quotation
    {
        public Input Read(int quotationId)
        {
            Input queryResult = new Input();
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sql = $"SELECT * From Quotation WHERE Id = @QuotationId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@QuotationId", quotationId);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader["Id"]);
                        DateTime createdOn = Convert.ToDateTime(dataReader["CreatedOn"]);
                        string calculation = Convert.ToString(dataReader["Calculation"]);
                        queryResult = JsonSerializer.Deserialize<Input>(calculation);
                        string image = Convert.ToString(dataReader["Image"]);
                        if (!string.IsNullOrEmpty(image))
                        {
                            List<string> images = JsonSerializer.Deserialize<List<string>>(image);
                        }
                    }
                }

                connection.Close();
            }

            return queryResult;
        }

        public int Insert(Input input)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonInput = JsonSerializer.Serialize(input);
                string sql = $"INSERT INTO Quotation (Calculation) VALUES (@JsonInput);SELECT SCOPE_IDENTITY();"; 
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@JsonInput", jsonInput);
                    connection.Open();
                    id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }

            return id;
        }

        public void Update(int quotationId, List<string> image)
        {
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonImage = JsonSerializer.Serialize(image);
                string sql = $"UPDATE Quotation SET Image = @Image WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Image", jsonImage);
                    command.Parameters.AddWithValue("@Id", quotationId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
