using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;

namespace BTv2._0.repository
{
    class DBC
    {
        public readonly string ConnectionString = "datasource = localhost; port = 3306; username = root; password=; database = bt";
        
        MySqlConnection con;
        public MySqlCommand cmd;
        public DBC()
        {
            con = new MySqlConnection(ConnectionString);
        }
        public void ConnectDB()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }

            else
            {
                con.Close();
                con.Open();
            }
        }

        public void DisConnectDB()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            else { }
        }

        public void ExecuteQuery(string query)
        {
            cmd = new MySqlCommand(query, con);
            _ = cmd.ExecuteNonQuery();
        }
    }
}
