using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataReader sqlDataReader;

            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=A_Zawodnicy;Integrated Security=True";

            connection = new SqlConnection(connectionString);

            command = new SqlCommand("select * from zawodnicy", connection);

            connection.Open();
            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {

                string wynik = (string)sqlDataReader.GetValue(2)+" "+ (string)sqlDataReader.GetValue(3);
                Console.WriteLine(wynik);
                
            }
            connection.Close();
            Console.ReadKey();

        }
    }
}
