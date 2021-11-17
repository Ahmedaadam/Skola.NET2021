using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Inlämning
{
    public static class Request
    {
        public static void GetDistinctCountries()
        {
            Console.WriteLine("How many countries are represented?");
            var input = Console.ReadLine();

            var database = new Database();

            var response = database.GetDataTable("SELECT COUNT (DISTINCT country) as NumberOfCountries " +
                "FROM[master].[dbo].[MOCK_DATA]");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"There is: {row["NumberOfCountries"]} countries represented.");
                    }
                }
            }

            Console.WriteLine("For next question press enter :)");
            Console.ReadLine();
            Console.Clear();


        }

        public static void GetDistinctPasswordsAndUsername()
        {
            Console.WriteLine("Are the username and passwords unique?");
            var input = Console.ReadLine();

            var database = new Database();

            var response1 = database.GetDataTable("SELECT count(*) as u " +
                "from[master].[dbo].[MOCK_DATA] " +
                "group by username, password " +
                "having count(*) > 1");

            if (response1 != null)
            {
                if (response1.Rows.Count > 0)
                {
                    Console.WriteLine("All Passwords and usernames are not unique");
                }
                if (response1.Rows.Count > 0)
                {
                    foreach (DataRow row in response1.Rows)
                    {
                        Console.WriteLine($"{row["passwords"]} {row["userName"]}");
                    }
                }

                else
                {
                    Console.WriteLine("All passwords and usernames are unique.");
                }
            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadLine();
            Console.Clear();
        }

        public static void GetFromTheNorthAndScandinavia()
        {
            Console.WriteLine("How many are from the north respectively from scandinavia?");
            var input = Console.ReadLine();

            var database = new Database();

            var response2 = database.GetDataTable("SELECT count(Distinct id) " +
                "as The_North_And_Scandinavia " +
                "from[master].[dbo].[MOCK_DATA] " +
                " where country in ('Sweden', 'Denmark', 'Norway', " +
                "'Finland', 'Iceland') " +
                "having count(*) > 0");

            if (response2 != null)
            {
                if (response2.Rows.Count > 0)
                {
                    foreach (DataRow row in response2.Rows)
                    {
                        Console.WriteLine($"There is {row["The_North_And_Scandinavia"]} people from " +
                            $"the north and scandinavia.");
                    }
                }
               
            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadLine();
            Console.Clear();
        }

        public static void GetMostCommonCountry()
        {

        }
    }

}

