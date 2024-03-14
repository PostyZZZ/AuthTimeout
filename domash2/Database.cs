using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domash2
{
    internal class Database
    {
        private NpgsqlConnection connection;


        public Database()
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=authlbl;";
            connection = new NpgsqlConnection(connectionString);
        }


        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }


        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
    }
}