using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1
{
    class Connexion
    {
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3308;username=root;password=;database=commande");
            
        public MySqlConnection getConnection()
        {
            return conn;
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }


    }

}