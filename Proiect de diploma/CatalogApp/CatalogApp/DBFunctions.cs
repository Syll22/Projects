using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogApp
{
    public static class DBFunctions
    {
        public static SqlConnection Get_DB_Connection()

        {
            string con_String = Properties.Settings.Default.ConnString;

            SqlConnection con_connection = new SqlConnection(con_String);

            if (con_connection.State != ConnectionState.Open) con_connection.Open();

            return con_connection;
        }

        public static DataTable Get_DataTable(string SQL_Text)

        {
            SqlConnection con_connection = Get_DB_Connection();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, con_connection);

            adapter.Fill(table);

            return table;
        }

        public static int Execute_SQL(string SQL_Text)

        {
            SqlConnection con_connection = Get_DB_Connection();

            SqlCommand cmd_Command = new SqlCommand(SQL_Text, con_connection);

            int result = cmd_Command.ExecuteNonQuery();

            return result;
        }
        
        public static void Close_DB_Connection()

        {
            string con_String = Properties.Settings.Default.ConnString;

            SqlConnection con_connection = new SqlConnection(con_String);

            if (con_connection.State != ConnectionState.Closed) con_connection.Close();
        }
    }
}
