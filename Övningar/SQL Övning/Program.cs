using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            //var conString = string.Format(Databas.ConnectionString, Databas.DatabaseName);
            //Console.WriteLine(conString);
            var ConnectionString = string.Format(Databas.ConnectionString, Databas.DatabaseName); // Databas.ConnectionString;

            using (var cnn = new SqlConnection(ConnectionString))
            {
                cnn.Open();
                Console.WriteLine($"Using database: {cnn.Database}");
                var sql = @"SELECT [Id],[first_name],[age]
                FROM [sqllesson].[dbo].[People]
                WHERE [age] > 30 AND [age]< 50 ";

                using (var command = new SqlCommand(sql, cnn))
                {
                   // command.Parameters.AddWithValue("@input", "%ma%");

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                Console.WriteLine($"{row["first_name"]} {row["age"]} ");
                            }
                        }
                    }
                }
                cnn.Close();
            }

        }
    }
}
