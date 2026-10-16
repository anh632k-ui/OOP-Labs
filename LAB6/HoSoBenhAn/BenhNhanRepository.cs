using System;
using System.Data;
using System.Data.SqlClient;
namespace HoSoBenhAnPrototype {
    public sealed class BenhNhanRepository {
        public int DangKy(BenhNhanData data) {
            using (var conn = Db.Open())
            using (var tx = conn.BeginTransaction()) {
                try {
                    int maBenhNhan;
                    using (var cmd = new SqlCommand(@"INSERT INTO BenhNhan(HoTen,DiaChi,NgaySinh,DienThoai,DuongDanAnh)
                        OUTPUT INSERTED.MaBenhNhan VALUES(@HoTen,@DiaChi,@NgaySinh,@DienThoai,@Anh)", conn, tx)) {
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 120).Value = data.HoTen;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = data.DiaChi;
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = data.NgaySinh.Date;
                        cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = data.DienThoai;
                        cmd.Parameters.Add("@Anh", SqlDbType.NVarChar, 500).Value = data.DuongDanAnh;
                        maBenhNhan = (int)cmd.ExecuteScalar();
                    }
                    using (var cmd = new SqlCommand("INSERT INTO PhieuDangKy(MaBenhNhan) VALUES(@Ma)", conn, tx)) {
                        cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maBenhNhan;
                        cmd.ExecuteNonQuery();
                    }
                    int maHoSo;
                    using (var cmd = new SqlCommand(@"INSERT INTO HoSoBenhAn(MaBenhNhan)
                        OUTPUT INSERTED.MaHoSo VALUES(@Ma)", conn, tx)) {
                        cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maBenhNhan;
                        maHoSo = (int)cmd.ExecuteScalar();
                    }
                    using (var cmd = new SqlCommand(@"INSERT INTO PhiQuanLyNam(MaHoSo,Nam,SoTien)
                        VALUES(@MaHoSo,@Nam,@Tien)", conn, tx)) {
                        cmd.Parameters.Add("@MaHoSo", SqlDbType.Int).Value = maHoSo;
                        cmd.Parameters.Add("@Nam", SqlDbType.SmallInt).Value = DateTime.Today.Year;
                        var p = cmd.Parameters.Add("@Tien", SqlDbType.Decimal);
                        p.Precision = 18; p.Scale = 2; p.Value = data.PhiNam;
                        cmd.ExecuteNonQuery();
                    }
                    tx.Commit();
                    return maHoSo;
                } catch { tx.Rollback(); throw; }
            }
        }
        public DataTable TimKiem(string tuKhoa) {
            const string sql = @"SELECT hs.MaHoSo, 'HS'+RIGHT('000000'+CONVERT(VARCHAR(12),hs.MaHoSo),6) AS MaHienThi,
                bn.HoTen, bn.NgaySinh, bn.DienThoai, bn.DiaChi,
                (SELECT MAX(p.Nam) FROM PhiQuanLyNam p WHERE p.MaHoSo=hs.MaHoSo) AS NamDongPhi
                FROM HoSoBenhAn hs JOIN BenhNhan bn ON bn.MaBenhNhan=hs.MaBenhNhan
                WHERE @TuKhoa='' OR bn.HoTen LIKE @Mau OR bn.DienThoai LIKE @Mau
                  OR CONVERT(VARCHAR(12),hs.MaHoSo)=@TuKhoa
                  OR 'HS'+RIGHT('000000'+CONVERT(VARCHAR(12),hs.MaHoSo),6)=@TuKhoa
                ORDER BY hs.MaHoSo DESC";
            using (var conn = Db.Open())
            using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd)) {
                cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 120).Value = tuKhoa;
                cmd.Parameters.Add("@Mau", SqlDbType.NVarChar, 122).Value = "%" + tuKhoa + "%";
                var dt = new DataTable(); adapter.Fill(dt); return dt;
            }
        }
    }
}
