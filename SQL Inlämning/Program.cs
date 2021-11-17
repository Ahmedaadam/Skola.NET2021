using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Inlämning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How many countries are represented
            Request.GetDistinctCountries();
            // Are all usernames and passwords unique
            Request.GetDistinctPasswordsAndUsername();
            // How many are from the north respectively from scandinavia?
            Request.GetFromTheNorthAndScandinavia();
            // Whats the most common country in this database?
            Request.GetMostCommonCountry();
            // List the top 10 users whose name starts with L
            Request.GetTopTenUsers();
            // List all the users whose firstname and lastname starts with same letter
            Request.GetUserWithSameLetter();
        }

       
    }
}
