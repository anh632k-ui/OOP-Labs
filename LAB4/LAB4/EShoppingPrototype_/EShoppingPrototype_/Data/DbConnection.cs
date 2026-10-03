using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EShoppingPrototype.Data
{
    public class DbConnection : IDisposable
    {
        private SqlConnection connection;

        public SqlConnection Open()
        {
            if (connection == null)
            {
                string chuoiKetNoi =
                    ConfigurationManager
                    .ConnectionStrings["EShoppingDB"]
                    .ConnectionString;

                connection = new SqlConnection(chuoiKetNoi);
            }

            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public void Close()
        {
            if (connection != null &&
                connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public void Dispose()
        {
            Close();

            if (connection != null)
                connection.Dispose();
        }
    }
}