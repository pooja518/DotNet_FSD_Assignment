using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=USHYDCPOOJA1; Database = sept2024Db; Integrated Security = true ";
            string cmdText = "INSERT INTO product VALUES(2007,'Clothes',600,20,'Clothing')";

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();

            Console.WriteLine("Conneted to Database");

            int n = cmd.ExecuteNonQuery();
            Console.WriteLine("No of rows affected :" + n);

            conn.Close();

            Console.ReadLine();

        }
    }
}
