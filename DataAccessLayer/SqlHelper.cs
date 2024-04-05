using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace HHD.DataAccessLayer
{
    public class SqlHelper
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
        public static DataTable GetDataTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    adapter.SelectCommand.Parameters.Clear();
                    return dt;
                }
            }
        }
        public static int ExcuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return n;
                }

            }
        }

        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();             
                    return cmd.ExecuteScalar();
                }

            }
        }
    }
}