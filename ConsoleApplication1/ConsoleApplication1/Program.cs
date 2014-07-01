using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=cphs-sqldev-01;Database=Compass_CORE_DEV;User ID=usr_quartz;Password=Password1*;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
    }
}
