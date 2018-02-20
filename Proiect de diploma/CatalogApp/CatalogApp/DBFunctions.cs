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

        public static void Execute_SQL(string SQL_Text)

        {
            SqlConnection con_connection = Get_DB_Connection();

            SqlCommand cmd_Command = new SqlCommand(SQL_Text, con_connection);

            cmd_Command.ExecuteNonQuery();
        }
        
        public static void Close_DB_Connection()

        {
            string con_String = Properties.Settings.Default.ConnString;

            SqlConnection con_connection = new SqlConnection(con_String);

            if (con_connection.State != ConnectionState.Closed) con_connection.Close();
        }

        static private void Db_Update_Add_Record(string sURL, string sTitle)

        {
            sURL = sURL.Replace("'", "''");

            sTitle = sTitle.Replace("'", "''");

            string sSQL = "SELECT TOP 1 * FROM tbl_Details WHERE [URL] Like '" + sURL + "'";

            DataTable tbl = Get_DataTable(sSQL);

            if (tbl.Rows.Count == 0)

            {
                string sql_Add = "INSERT INTO tbl_Details ([URL],[Title],[dtScan]) VALUES('" + sURL + "','" + sTitle + "',SYSDATETIME())";

                Execute_SQL(sql_Add);
            }

            else

            {
                string ID = tbl.Rows[0]["IDDetail"].ToString();

                string sql_Update = "UPDATE tbl_Details SET [dtScan] = SYSDATETIME() WHERE IDDetail = " + ID;

                Execute_SQL(sql_Update);
            }
        }
    }
}
