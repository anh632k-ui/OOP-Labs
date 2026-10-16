using System.Configuration;
using System.Data.SqlClient;
namespace HoSoBenhAnPrototype {
    internal static class Db {
        internal static SqlConnection Open() {
            var cs = ConfigurationManager.ConnectionStrings["HoSoBenhAn"];
            if (cs == null) throw new ConfigurationErrorsException("Thiếu chuỗi kết nối HoSoBenhAn trong App.config.");
            var conn = new SqlConnection(cs.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
