using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Övning
{
    public static class Databas
    {
        public static string ConnectionString { get; set; } = @"Data Source=localhost;Integrated Security=true;database={0}";
        public static string DatabaseName { get; set; } = "sqllesson";
    }
}
