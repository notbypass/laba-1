using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.70.5;port=3306;username=appuser;password=pass;database=avto");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public static  MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection("server=192.168.70.5;port=3306;username=appuser;password=pass;database=avto");
            return conn;
        }

    }
}



