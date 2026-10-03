using System;
using System.Data;
using System.Data.SqlClient;

namespace EShoppingPrototype.Data
{
    public class DonHangRepository
    {
        public DataTable GetLoaiGiaoHang()
        {
            string sql = @"
SELECT MaLoai, TenLoai, PhiCoBan, ThoiGianXuLy
FROM LOAI_GIAO_HANG
ORDER BY MaLoai";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());

                return table;
            }
        }

        public DataRow GetKhachHang(int maKH)
        {
            string sql = @"
SELECT HoTen, DiaChi, DienThoai, Email
FROM KHACH_HANG
WHERE MaKH = @MaKH";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());

                if (table.Rows.Count == 0)
                    return null;

                return table.Rows[0];
            }
        }

        public int TaoDonHang(
            int maKH,
            int maLoai,
            string hoTen,
            string diaChi,
            string dienThoai,
            decimal phiGiaoHang,
            decimal tongTien)
        {
            using (DbConnection db = new DbConnection())
            {
                SqlConnection cn = db.Open();
                SqlTransaction tran = cn.BeginTransaction();

                try
                {
                    string sqlDonHang = @"
INSERT INTO DON_HANG
(
    MaKH, MaLoai,
    HoTenNguoiNhan,
    DiaChiNhan,
    DienThoaiNhan,
    PhiGiaoHang,
    TongTien,
    TrangThai
)
VALUES
(
    @MaKH, @MaLoai,
    @HoTen, @DiaChi, @DienThoai,
    @Phi, @Tong,
    N'Đã thanh toán'
);

SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int maDH;

                    using (SqlCommand cmd =
                        new SqlCommand(sqlDonHang, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@DienThoai", dienThoai);
                        cmd.Parameters.AddWithValue("@Phi", phiGiaoHang);
                        cmd.Parameters.AddWithValue("@Tong", tongTien);

                        maDH = (int)cmd.ExecuteScalar();
                    }

                    string sqlChiTiet = @"
INSERT INTO CT_DON_HANG
(
    MaDH, MaSP, SoLuong, DonGia
)
SELECT
    @MaDH,
    ct.MaSP,
    ct.SoLuong,
    sp.GiaHienHanh
FROM GIO_HANG gh
JOIN CT_GIO_HANG ct
    ON gh.MaGio = ct.MaGio
JOIN SAN_PHAM sp
    ON ct.MaSP = sp.MaSP
WHERE gh.MaKH = @MaKH";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlChiTiet, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaDH", maDH);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlThanhToan = @"
INSERT INTO GIAO_DICH_THANH_TOAN
(
    MaDH,
    SoTien,
    TrangThai,
    MaThamChieu
)
VALUES
(
    @MaDH,
    @SoTien,
    N'Thành công',
    @MaThamChieu
)";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlThanhToan, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaDH", maDH);
                        cmd.Parameters.AddWithValue("@SoTien", tongTien);

                        cmd.Parameters.AddWithValue(
                            "@MaThamChieu",
                            "PAY-" + maDH.ToString("D6"));

                        cmd.ExecuteNonQuery();
                    }

                    string sqlXoaGio = @"
DELETE ct
FROM CT_GIO_HANG ct
JOIN GIO_HANG gh
    ON ct.MaGio = gh.MaGio
WHERE gh.MaKH = @MaKH";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlXoaGio, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return maDH;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}