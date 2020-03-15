using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.Json;
using YkCalculator.Model;
using YkCalculator.Utility;

namespace YkCalculator.DAL
{
    public class QuotationDal
    {
        public Output Read(int quotationId)
        {
            Output queryResult = new Output();
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
                        string calculation = Convert.ToString(dataReader["Calculation"]);
                        queryResult = JsonSerializer.Deserialize<Output>(calculation);
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

        public int Insert(Output output)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(Constant.ConnectionString))
            {
                string jsonOutput = JsonSerializer.Serialize(output);
                string sql = $"INSERT INTO Quotation (Calculation) VALUES (@JsonOutput);SELECT SCOPE_IDENTITY();"; 
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@JsonOutput", jsonOutput);
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
