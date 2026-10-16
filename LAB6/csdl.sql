/* BÀI 5 - QUẢN LÝ HỒ SƠ BỆNH ÁN | SQL Server 2019+
   Chạy trên SSMS trước khi chạy ứng dụng WinForms.
   Chỉ dùng cho dữ liệu minh hoạ, không dùng dữ liệu bệnh nhân thực. */
IF DB_ID(N'QLHoSoBenhAn_Bai5') IS NULL
    CREATE DATABASE QLHoSoBenhAn_Bai5;
GO
USE QLHoSoBenhAn_Bai5;
GO
CREATE TABLE BenhNhan (
    MaBenhNhan INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(120) NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    NgaySinh DATE NOT NULL,
    DienThoai VARCHAR(15) NOT NULL,
    DuongDanAnh NVARCHAR(500) NOT NULL,
    CONSTRAINT CK_BN_DienThoai CHECK (LEN(DienThoai) BETWEEN 9 AND 11 AND DienThoai NOT LIKE '%[^0-9]%')
);
GO
CREATE TABLE PhieuDangKy (
    MaPhieuDangKy INT IDENTITY(1,1) PRIMARY KEY,
    MaBenhNhan INT NOT NULL UNIQUE REFERENCES BenhNhan(MaBenhNhan),
    NgayDangKy DATETIME2(0) NOT NULL DEFAULT SYSDATETIME()
);
GO
CREATE TABLE HoSoBenhAn (
    MaHoSo INT IDENTITY(1,1) PRIMARY KEY,
    MaBenhNhan INT NOT NULL UNIQUE REFERENCES BenhNhan(MaBenhNhan),
    NgayCap DATETIME2(0) NOT NULL DEFAULT SYSDATETIME()
);
GO
CREATE TABLE PhiQuanLyNam (
    MaPhiNam INT IDENTITY(1,1) PRIMARY KEY,
    MaHoSo INT NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
    Nam SMALLINT NOT NULL CHECK (Nam BETWEEN 2000 AND 2100),
    SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien > 0),
    NgayDong DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT UQ_PhiNam UNIQUE(MaHoSo,Nam)
);
GO
CREATE TABLE Khoa (
    MaKhoa INT IDENTITY(1,1) PRIMARY KEY,
    TenKhoa NVARCHAR(120) NOT NULL UNIQUE
);
GO
CREATE TABLE BacSi (
    MaBacSi INT IDENTITY(1,1) PRIMARY KEY,
    MaKhoa INT NOT NULL REFERENCES Khoa(MaKhoa),
    HoTen NVARCHAR(120) NOT NULL
);
GO
CREATE TABLE PhieuKham (
    MaPhieuKham INT IDENTITY(1,1) PRIMARY KEY,
    MaHoSo INT NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
    MaBacSi INT NOT NULL REFERENCES BacSi(MaBacSi),
    MaKhoa INT NOT NULL REFERENCES Khoa(MaKhoa),
    NgayGioKham DATETIME2(0) NOT NULL,
    LoaiKham VARCHAR(10) NOT NULL CHECK (LoaiKham IN ('DinhKy','DieuTri')),
    TrieuChung NVARCHAR(1000) NOT NULL,
    ThanNhiet DECIMAL(4,1) NULL,
    HuyetAp NVARCHAR(20) NULL,
    ChanDoan NVARCHAR(1000) NOT NULL,
    NgayXuatVien DATETIME2(0) NOT NULL,
    NgayGhiNhan DATETIME2(0) NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT CK_PhieuKham_Ngay CHECK (NgayXuatVien >= NgayGioKham)
);
GO
CREATE TABLE VienPhi (
    MaVienPhi INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuKham INT NOT NULL UNIQUE REFERENCES PhieuKham(MaPhieuKham),
    SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien >= 0),
    NgayThanhToan DATETIME2(0) NOT NULL,
    DaThanhToan BIT NOT NULL DEFAULT 1
);
GO
CREATE TABLE XetNghiem (
    MaXetNghiem INT IDENTITY(1,1) PRIMARY KEY,
    TenXetNghiem NVARCHAR(150) NOT NULL UNIQUE
);
GO
CREATE TABLE ChiDinhXetNghiem (
    MaChiDinh INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuKham INT NOT NULL REFERENCES PhieuKham(MaPhieuKham),
    MaXetNghiem INT NOT NULL REFERENCES XetNghiem(MaXetNghiem),
    KetQua NVARCHAR(1000) NULL,
    CONSTRAINT UQ_ChiDinh UNIQUE(MaPhieuKham,MaXetNghiem)
);
GO
CREATE TABLE Thuoc (
    MaThuoc INT IDENTITY(1,1) PRIMARY KEY,
    TenThuoc NVARCHAR(150) NOT NULL UNIQUE,
    DonVi NVARCHAR(30) NOT NULL
);
GO
CREATE TABLE ToaThuoc (
    MaToa INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuKham INT NOT NULL UNIQUE REFERENCES PhieuKham(MaPhieuKham),
    NgayKe DATETIME2(0) NOT NULL
);
GO
CREATE TABLE CT_ToaThuoc (
    MaToa INT NOT NULL REFERENCES ToaThuoc(MaToa),
    MaThuoc INT NOT NULL REFERENCES Thuoc(MaThuoc),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    LieuDung NVARCHAR(255) NOT NULL,
    CONSTRAINT PK_CT_ToaThuoc PRIMARY KEY(MaToa,MaThuoc)
);
GO
CREATE TABLE LichHen (
    MaLichHen INT IDENTITY(1,1) PRIMARY KEY,
    MaHoSo INT NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
    NgayGioHen DATETIME2(0) NOT NULL,
    LoaiHen VARCHAR(10) NOT NULL CHECK (LoaiHen IN ('DinhKy','DieuTri')),
    TrangThai VARCHAR(12) NOT NULL DEFAULT 'DaDat'
        CHECK (TrangThai IN ('DaDat','DaHuy','DaKham')),
    GhiChu NVARCHAR(255) NULL
);
GO
CREATE INDEX IX_BenhNhan_HoTen ON BenhNhan(HoTen);
CREATE INDEX IX_PhieuKham_HoSo_Ngay ON PhieuKham(MaHoSo,NgayGioKham DESC);
CREATE INDEX IX_LichHen_HoSo ON LichHen(MaHoSo,NgayGioHen);
GO
INSERT INTO Khoa(TenKhoa) VALUES (N'Nội tổng quát'),(N'Ngoại tổng quát');
INSERT INTO BacSi(MaKhoa,HoTen) VALUES (1,N'Bác sĩ Nguyễn Minh An'),(2,N'Bác sĩ Trần Minh Bình');
INSERT INTO Thuoc(TenThuoc,DonVi) VALUES (N'Paracetamol 500mg',N'viên'),(N'Vitamin C 500mg',N'viên'),(N'Oresol',N'gói');
INSERT INTO XetNghiem(TenXetNghiem) VALUES (N'Công thức máu'),(N'Đường huyết'),(N'Tổng phân tích nước tiểu');
GO
