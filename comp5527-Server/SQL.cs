using System;
using System.Data;
using System.Data.SqlClient;

namespace RestAPIDemoServer
{
    class SQL
    {
        public int executeSQL(SqlCommand cmd)
        {
            int result = 0;
            try
            {
                SqlConnection Conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Comp5527ConnectionString"].ConnectionString);
                Conn.Open(); //Open connection
                cmd.Connection = Conn;
                cmd.CommandTimeout = 86400000; //prevent if the data is too big it it too easy to timeout

                result = cmd.ExecuteNonQuery();
                cmd.Cancel();
                Conn.Close();
                Conn.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return result;
        }
        public DataTable executeSQLQuery(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection Conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Comp5527ConnectionString"].ConnectionString);
            Conn.Open(); //Open connection
            cmd.Connection = Conn;
            cmd.CommandTimeout = 86400000; //prevent if the data is too big it it too easy to timeout

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dt.Dispose();
            cmd.Cancel();
            Conn.Close();
            Conn.Dispose();
            return dt;
        }
    }
}
