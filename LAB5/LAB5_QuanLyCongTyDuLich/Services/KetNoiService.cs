using System;
using QuanLyCongTyDuLich.Data;

namespace QuanLyCongTyDuLich.Services
{
    // Bổ sung cho LAB5: kiểm tra kết nối theo đúng luồng UI -> Service -> Data.
    public class KetNoiService
    {
        public KetQuaXuLy KiemTraKetNoi()
        {
            try
            {
                using (var cn = Db.OpenConnection())
                {
                    return KetQuaXuLy.Ok("Kết nối SQL Server thành công. CSDL: " + cn.Database + "; Server: " + cn.DataSource);
                }
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Chưa kết nối được CSDL. Kiểm tra App.config và SQL Server. Chi tiết: " + ex.Message);
            }
        }
    }
}
