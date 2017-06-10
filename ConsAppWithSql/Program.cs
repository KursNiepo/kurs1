using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppWithSql
{
    class Program
    {
        static void Main(string[] args) {
            SqlConnection connection = 
              new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand command = connection.CreateCommand();
            string sqlQuery = @"SELECT top 20 [CompanyName],[ContactName],[ContactTitle]
                                        ,[Address],[City] FROM[NORTHWND].[dbo].[Customers]";
            command.CommandText = sqlQuery;
            connection.Open();
            SqlDataReader rd = command.ExecuteReader();
            if (rd.HasRows) {
                while (rd.Read()) {
                    Console.WriteLine("{0}\t {1}\t {2}",rd.GetString(0),rd.GetString(1),
                        rd.GetString(2));
                }
            }
            Console.ReadKey();
            connection.Close();
        }
    }
}
