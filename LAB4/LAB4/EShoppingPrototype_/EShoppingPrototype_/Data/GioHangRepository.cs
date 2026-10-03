using System;
using System.Data;
using System.Data.SqlClient;

namespace EShoppingPrototype.Data
{
    public class GioHangRepository
    {
        public DataTable GetByKhachHang(int maKH)
        {
            string sql = @"
SELECT
    sp.MaSP,
    sp.TenSP,
    sp.GiaHienHanh,
    ct.SoLuong,
    sp.GiaHienHanh * ct.SoLuong AS ThanhTien
FROM GIO_HANG gh
JOIN CT_GIO_HANG ct ON gh.MaGio = ct.MaGio
JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
WHERE gh.MaKH = @MaKH";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());

                return table;
            }
        }

        public decimal GetTongTien(int maKH)
        {
            string sql = @"
SELECT ISNULL(
    SUM(sp.GiaHienHanh * ct.SoLuong), 0
)
FROM GIO_HANG gh
JOIN CT_GIO_HANG ct ON gh.MaGio = ct.MaGio
JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
WHERE gh.MaKH = @MaKH";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                return Convert.ToDecimal(
                    cmd.ExecuteScalar()
                );
            }
        }

        public DataTable GetSanPham()
        {
            string sql = @"
SELECT
    MaSP,
    TenSP,
    GiaHienHanh
FROM SAN_PHAM
WHERE TinhTrang = N'Còn hàng'
ORDER BY TenSP";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());

                return table;
            }
        }

        public void AddItem(
            int maKH,
            int maSP,
            int soLuong)
        {
            string sql = @"
DECLARE @MaGio INT;

SELECT @MaGio = MaGio
FROM GIO_HANG
WHERE MaKH = @MaKH;

IF @MaGio IS NULL
BEGIN
    INSERT INTO GIO_HANG(MaKH)
    VALUES(@MaKH);

    SET @MaGio =
        CAST(SCOPE_IDENTITY() AS INT);
END;

IF EXISTS
(
    SELECT 1
    FROM CT_GIO_HANG
    WHERE MaGio = @MaGio
      AND MaSP = @MaSP
)
BEGIN
    UPDATE CT_GIO_HANG
    SET SoLuong = SoLuong + @SoLuong
    WHERE MaGio = @MaGio
      AND MaSP = @MaSP;
END
ELSE
BEGIN
    INSERT INTO CT_GIO_HANG
    (
        MaGio,
        MaSP,
        SoLuong
    )
    VALUES
    (
        @MaGio,
        @MaSP,
        @SoLuong
    );
END";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                cmd.Parameters.AddWithValue(
                    "@MaKH",
                    maKH
                );

                cmd.Parameters.AddWithValue(
                    "@MaSP",
                    maSP
                );

                cmd.Parameters.AddWithValue(
                    "@SoLuong",
                    soLuong
                );

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSoLuong(
            int maKH,
            int maSP,
            int soLuong)
        {
            string sql = @"
UPDATE ct
SET SoLuong = @SoLuong
FROM CT_GIO_HANG ct
JOIN GIO_HANG gh
    ON ct.MaGio = gh.MaGio
WHERE gh.MaKH = @MaKH
AND ct.MaSP = @MaSP";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                cmd.Parameters.AddWithValue(
                    "@SoLuong",
                    soLuong
                );

                cmd.Parameters.AddWithValue(
                    "@MaKH",
                    maKH
                );

                cmd.Parameters.AddWithValue(
                    "@MaSP",
                    maSP
                );

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteItem(
            int maKH,
            int maSP)
        {
            string sql = @"
DELETE ct
FROM CT_GIO_HANG ct
JOIN GIO_HANG gh
    ON ct.MaGio = gh.MaGio
WHERE gh.MaKH = @MaKH
AND ct.MaSP = @MaSP";

            using (DbConnection db = new DbConnection())
            using (SqlCommand cmd = new SqlCommand(sql, db.Open()))
            {
                cmd.Parameters.AddWithValue(
                    "@MaKH",
                    maKH
                );

                cmd.Parameters.AddWithValue(
                    "@MaSP",
                    maSP
                );

                cmd.ExecuteNonQuery();
            }
        }
    }
}