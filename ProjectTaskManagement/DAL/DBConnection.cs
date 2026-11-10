using System.Data.SqlClient;

namespace ProjectTaskManagement.DAL
{
    public class DBConnection
    {
        private static string connectionString =
            @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=ProjectTaskDB;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}