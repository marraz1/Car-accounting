using Npgsql;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Car_accounting
{
    public class SqlDbConnect
    {
        //public private SqlDbConnection _con;
       /* private SqlCommand _cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;*/

        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Car";
        private static string Password = "postgres";
        private static string Port = "5434";

        public static NpgsqlConnection conn = null;

        public void Connection_open()
        {
            string connstring = String.Format(
                              "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                              Host,
                              User,
                              DBname,
                              Port,
                              Password);
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }
        public void Connection_close()
        {
            conn.Close();
        }

    }
}
