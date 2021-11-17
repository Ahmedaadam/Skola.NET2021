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
        }

       
    }
}
