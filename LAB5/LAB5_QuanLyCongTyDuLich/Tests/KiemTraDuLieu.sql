USE QuanLyCongTyDuLich;
GO
-- 1. Đảm bảo CSDL đã có 16 bảng từ bài 6.
SELECT COUNT(*) AS SoBang FROM sys.tables WHERE name IN
('Tour','PhuongTien','DiemThamQuan','DiemBanVe','HuongDanVien',
 'TourDiemDung','TourPhuongTien','TourDiemThamQuan','ChuyenLe',
 'DoanKhach','DangKyDoan','ThanhVienDoan','DangKyLe',
 'PhanCongHDV','ThanhToanDoan','KhaoSat');

-- 2. Kiểm tra T001, dữ liệu mẫu và các chuyến đã tạo.
SELECT MaTour, TenTour, SoNgay, SoDem, DonGiaKhach FROM Tour WHERE MaTour='T001';
SELECT MaChuyen, MaTour, NgayDi, NgayVe, TrangThai FROM ChuyenLe ORDER BY MaChuyen;

-- 3. Kiểm tra sau khi hủy một phiếu đoàn.
SELECT SoDKDoan, TienCoc, TrangThai, NgayDi FROM DangKyDoan ORDER BY SoDKDoan;
SELECT MaPC, MaHDV, SoDKDoan, NgayBatDau, NgayKetThuc FROM PhanCongHDV ORDER BY MaPC;
GO
