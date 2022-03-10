using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett namn");
            var input = Console.ReadLine();

            var sql = "Select top (10) first_name, last_name from people " +
                "WHERE first_name LIKE @param";
            var dt = GetDataTable(sql, "@param", "%" + input + "%");
            PrintRow(dt);

        }

        private static void PrintRow(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static DataTable GetDataTable(string sql, string paramName, string paramValue)
        {
            // Definerar connectionstring
            var connString = string.Format(Databas.ConnectionString, Databas.DatabaseName); // "server=(localhost)\\mssqllocalhost;intergrated security=true;database=people";
            
            // Skapa Datatable
            var dt = new DataTable();
            
            // Förbered koppling till databasen
            using (var connection = new SqlConnection(connString))
            {
                
                // Öppna koppling till databasen
                connection.Open();
                
                // Förbered kommando
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                  
                    //Förbered en adapter
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        // Kopierar databasdata till datatabell
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        //private static void ExecuteSQL(string sql, string paramName, string paramValue)
        //{
        //    // Definerar connectionstring
        //    var connString = string.Format(Databas.ConnectionString, Databas.DatabaseName); // "server=(localhost)\\mssqllocalhost;intergrated security=true;database=people";
           
        //    // Skapa Datatable
        //    var dt = new DataTable();
           
        //    // Förbered koppling till databasen
        //    using (var connection = new SqlConnection(connString))
        //    {
        //        // Öppna koppling till databasen
        //        connection.Open();

        //        // Förbered kommando
        //        using (var command = new SqlCommand(sql, connection))
        //        {
        //            command.Parameters.AddWithValue(paramName, paramValue);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}
//var ConnectionString = string.Format(Databas.ConnectionString, Databas.DatabaseName); // Databas.ConnectionString;

//using (var cnn = new SqlConnection(ConnectionString))
//{
//    cnn.Open();
//    Console.WriteLine($"Using database: {cnn.Database}");
//    var sql = @"SELECT [Id],[first_name],[age]
//    FROM [sqllesson].[dbo].[People]
//    WHERE [age] > 30 AND [age]< 50 ";

//    using (var command = new SqlCommand(sql, cnn))
//    {
//       // command.Parameters.AddWithValue("@input", "%ma%");

//        using (var adapter = new SqlDataAdapter(command))
//        {
//            var dt = new DataTable();
//            adapter.Fill(dt);
//            if (dt.Rows.Count > 0)
//            {
//                foreach (DataRow row in dt.Rows)
//                {
//                    Console.WriteLine($"{row["first_name"]} {row["age"]} ");
//                }
//            }
//        }
//    }
//    cnn.Close();

