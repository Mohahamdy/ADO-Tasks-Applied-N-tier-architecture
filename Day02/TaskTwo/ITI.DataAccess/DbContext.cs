using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ITI.DataAccess
{
    public static class DbContext
    {
        static SqlConnection con = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        public static DataTable Select(string command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand(command, con);
            adapter.SelectCommand = cmd;

            adapter.Fill(dt);

            return dt;
        }

        public static int ExecuteNonQuery(string command)
        {

            int rowsAffected = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(command, con);
                con.Open();

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                con.Close();
            }

            return rowsAffected;
        }

        public static object? ExecuteScalar(string command)
        {
            object? obj = null;

            try
            {
                SqlCommand cmd = new SqlCommand(command, con);
                con.Open();
                obj = cmd.ExecuteScalar();
            }
            catch { }
            finally
            {
                con.Close() ;
            }

            return obj;
        }
    }
}
