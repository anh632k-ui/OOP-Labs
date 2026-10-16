using System;
using System.Data;
using System.Data.SqlClient;
namespace HoSoBenhAnPrototype {
    public sealed class KhamBenhRepository {
        public DataTable LayBacSi() { return GetTable(@"SELECT bs.MaBacSi,
            bs.HoTen + N' - ' + k.TenKhoa AS HienThi FROM BacSi bs JOIN Khoa k ON bs.MaKhoa=k.MaKhoa ORDER BY bs.MaBacSi"); }
        public DataTable LayThuoc() { return GetTable("SELECT MaThuoc,TenThuoc FROM Thuoc ORDER BY TenThuoc"); }
        public DataTable LayXetNghiem() { return GetTable("SELECT MaXetNghiem,TenXetNghiem FROM XetNghiem ORDER BY TenXetNghiem"); }
        public DataTable LayLichSu(int maHoSo) {
            using (var conn = Db.Open())
            using (var cmd = new SqlCommand(@"SELECT pk.MaPhieuKham,pk.NgayGioKham,pk.LoaiKham,
                  bs.HoTen AS BacSi,pk.ChanDoan,vp.SoTien AS VienPhi
                FROM PhieuKham pk JOIN BacSi bs ON bs.MaBacSi=pk.MaBacSi
                JOIN VienPhi vp ON vp.MaPhieuKham=pk.MaPhieuKham
                WHERE pk.MaHoSo=@Ma ORDER BY pk.NgayGioKham DESC", conn))
            using (var adapter = new SqlDataAdapter(cmd)) {
                cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maHoSo;
                var dt = new DataTable(); adapter.Fill(dt); return dt;
            }
        }
        private DataTable GetTable(string sql) {
            using (var conn = Db.Open()) using (var cmd = new SqlCommand(sql, conn))
            using (var adapter = new SqlDataAdapter(cmd)) {
                var dt = new DataTable(); adapter.Fill(dt); return dt;
            }
        }
        public int GhiNhan(KhamBenhData d) {
            using (var conn = Db.Open())
            using (var tx = conn.BeginTransaction()) {
                try {
                    int maHoSoExists;
                    using (var cmd = new SqlCommand(@"SELECT COUNT(*) FROM HoSoBenhAn
                            WHERE MaHoSo=@Ma", conn, tx)) {
                        cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = d.MaHoSo;
                        maHoSoExists = (int)cmd.ExecuteScalar();
                    }
                    if (maHoSoExists == 0) throw new InvalidOperationException("Mã hồ sơ không tồn tại.");
                    int maKhoa;
                    using (var cmd = new SqlCommand("SELECT MaKhoa FROM BacSi WHERE MaBacSi=@Ma", conn, tx)) {
                        cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = d.MaBacSi;
                        object o = cmd.ExecuteScalar();
                        if (o == null) throw new InvalidOperationException("Bác sĩ không tồn tại.");
                        maKhoa = (int)o;
                    }
                    int maKham;
                    using (var cmd = new SqlCommand(@"INSERT INTO PhieuKham
                        (MaHoSo,MaBacSi,MaKhoa,NgayGioKham,LoaiKham,TrieuChung,ThanNhiet,HuyetAp,ChanDoan,NgayXuatVien)
                        OUTPUT INSERTED.MaPhieuKham VALUES
                        (@HoSo,@BacSi,@Khoa,@Ngay,@Loai,@TrieuChung,@ThanNhiet,@HuyetAp,@ChanDoan,@XuatVien)", conn, tx)) {
                        cmd.Parameters.Add("@HoSo", SqlDbType.Int).Value = d.MaHoSo;
                        cmd.Parameters.Add("@BacSi", SqlDbType.Int).Value = d.MaBacSi;
                        cmd.Parameters.Add("@Khoa", SqlDbType.Int).Value = maKhoa;
                        cmd.Parameters.Add("@Ngay", SqlDbType.DateTime2).Value = d.NgayGioKham;
                        cmd.Parameters.Add("@Loai", SqlDbType.VarChar, 10).Value = d.LoaiKham;
                        cmd.Parameters.Add("@TrieuChung", SqlDbType.NVarChar, 1000).Value = d.TrieuChung;
                        var temp = cmd.Parameters.Add("@ThanNhiet", SqlDbType.Decimal);
                        temp.Precision = 4; temp.Scale = 1; temp.Value = (object)d.ThanNhiet ?? DBNull.Value;
                        cmd.Parameters.Add("@HuyetAp", SqlDbType.NVarChar, 20).Value = (object)d.HuyetAp ?? DBNull.Value;
                        cmd.Parameters.Add("@ChanDoan", SqlDbType.NVarChar, 1000).Value = d.ChanDoan;
                        cmd.Parameters.Add("@XuatVien", SqlDbType.DateTime2).Value = d.NgayXuatVien;
                        maKham = (int)cmd.ExecuteScalar();
                    }
                    using (var cmd = new SqlCommand(@"INSERT INTO VienPhi(MaPhieuKham,SoTien,NgayThanhToan,DaThanhToan)
                            VALUES (@Ma,@Tien,@Ngay,1)", conn, tx)) {
                        cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maKham;
                        var p = cmd.Parameters.Add("@Tien", SqlDbType.Decimal); p.Precision = 18; p.Scale = 2; p.Value = d.VienPhi;
                        cmd.Parameters.Add("@Ngay", SqlDbType.DateTime2).Value = d.NgayThanhToan;
                        cmd.ExecuteNonQuery();
                    }
                    foreach (var xn in d.XetNghiem) {
                        using (var cmd = new SqlCommand(@"INSERT INTO ChiDinhXetNghiem(MaPhieuKham,MaXetNghiem,KetQua)
                                VALUES(@Ma,@XetNghiem,@KetQua)", conn, tx)) {
                            cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maKham;
                            cmd.Parameters.Add("@XetNghiem", SqlDbType.Int).Value = xn.MaXetNghiem;
                            cmd.Parameters.Add("@KetQua", SqlDbType.NVarChar, 1000).Value = (object)xn.KetQua ?? DBNull.Value;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    if (d.Thuoc.Count > 0) {
                        int maToa;
                        using (var cmd = new SqlCommand(@"INSERT INTO ToaThuoc(MaPhieuKham,NgayKe)
                                OUTPUT INSERTED.MaToa VALUES (@Ma,@Ngay)", conn, tx)) {
                            cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = maKham;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime2).Value = d.NgayGioKham;
                            maToa = (int)cmd.ExecuteScalar();
                        }
                        foreach (var item in d.Thuoc) {
                            using (var cmd = new SqlCommand(@"INSERT INTO CT_ToaThuoc(MaToa,MaThuoc,SoLuong,LieuDung)
                                    VALUES(@MaToa,@MaThuoc,@SoLuong,@LieuDung)", conn, tx)) {
                                cmd.Parameters.Add("@MaToa", SqlDbType.Int).Value = maToa;
                                cmd.Parameters.Add("@MaThuoc", SqlDbType.Int).Value = item.MaThuoc;
                                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = item.SoLuong;
                                cmd.Parameters.Add("@LieuDung", SqlDbType.NVarChar, 255).Value = item.LieuDung;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    tx.Commit(); return maKham;
                } catch { tx.Rollback(); throw; }
            }
        }
    }
}
