USE master;
GO

IF DB_ID(N'EShoppingDB') IS NOT NULL
BEGIN
    ALTER DATABASE EShoppingDB
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

    DROP DATABASE EShoppingDB;
END
GO

CREATE DATABASE EShoppingDB;
GO

USE EShoppingDB;
GO

-- =========================================================
-- 1. TAI_KHOAN
-- =========================================================
CREATE TABLE TAI_KHOAN
(
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(255) NOT NULL
);
GO


-- =========================================================
-- 2. KHACH_HANG
-- Quan hệ 1-1 với TAI_KHOAN
-- =========================================================
CREATE TABLE KHACH_HANG
(
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    MaTK INT NOT NULL UNIQUE,

    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    SoGiayTo NVARCHAR(30) NULL,
    DiaChi NVARCHAR(255) NULL,
    DienThoai VARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,

    CONSTRAINT FK_KHACH_HANG_TAI_KHOAN
        FOREIGN KEY (MaTK)
        REFERENCES TAI_KHOAN(MaTK)
);
GO


-- =========================================================
-- 3. NHOM_SAN_PHAM
-- =========================================================
CREATE TABLE NHOM_SAN_PHAM
(
    MaNhom INT IDENTITY(1,1) PRIMARY KEY,
    TenNhom NVARCHAR(100) NOT NULL
);
GO


-- =========================================================
-- 4. SAN_PHAM
-- Quan hệ 1-n với NHOM_SAN_PHAM
-- =========================================================
CREATE TABLE SAN_PHAM
(
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    MaNhom INT NOT NULL,

    TenSP NVARCHAR(150) NOT NULL,
    NhaSanXuat NVARCHAR(100) NULL,
    MoTa NVARCHAR(MAX) NULL,
    ThongSoKyThuat NVARCHAR(MAX) NULL,

    GiaHienHanh DECIMAL(18,2) NOT NULL,
    TinhTrang NVARCHAR(30) NOT NULL,
    AnhMinhHoa NVARCHAR(255) NULL,

    CONSTRAINT CK_SAN_PHAM_GIA
        CHECK (GiaHienHanh >= 0),

    CONSTRAINT FK_SAN_PHAM_NHOM
        FOREIGN KEY (MaNhom)
        REFERENCES NHOM_SAN_PHAM(MaNhom)
);
GO


-- =========================================================
-- 5. GIO_HANG
-- Mỗi khách có tối đa 1 giỏ hàng
-- =========================================================
CREATE TABLE GIO_HANG
(
    MaGio INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL UNIQUE,
    NgayTao DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT FK_GIO_HANG_KHACH_HANG
        FOREIGN KEY (MaKH)
        REFERENCES KHACH_HANG(MaKH)
);
GO


-- =========================================================
-- 6. CT_GIO_HANG
-- Bảng trung gian GIO_HANG - SAN_PHAM
-- =========================================================
CREATE TABLE CT_GIO_HANG
(
    MaGio INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT NOT NULL,

    CONSTRAINT PK_CT_GIO_HANG
        PRIMARY KEY (MaGio, MaSP),

    CONSTRAINT CK_CT_GIO_HANG_SOLUONG
        CHECK (SoLuong > 0),

    CONSTRAINT FK_CT_GIO_HANG_GIO_HANG
        FOREIGN KEY (MaGio)
        REFERENCES GIO_HANG(MaGio)
        ON DELETE CASCADE,

    CONSTRAINT FK_CT_GIO_HANG_SAN_PHAM
        FOREIGN KEY (MaSP)
        REFERENCES SAN_PHAM(MaSP)
);
GO


-- =========================================================
-- 7. LOAI_GIAO_HANG
-- =========================================================
CREATE TABLE LOAI_GIAO_HANG
(
    MaLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL,
    PhiCoBan DECIMAL(18,2) NOT NULL,
    ThoiGianXuLy NVARCHAR(100) NULL,

    CONSTRAINT CK_LOAI_GIAO_HANG_PHI
        CHECK (PhiCoBan >= 0)
);
GO


-- =========================================================
-- 8. DON_HANG
-- =========================================================
CREATE TABLE DON_HANG
(
    MaDH INT IDENTITY(1,1) PRIMARY KEY,

    MaKH INT NOT NULL,
    MaLoai INT NOT NULL,

    NgayDat DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    HoTenNguoiNhan NVARCHAR(100) NOT NULL,
    DiaChiNhan NVARCHAR(255) NOT NULL,
    DienThoaiNhan VARCHAR(20) NOT NULL,

    PhiGiaoHang DECIMAL(18,2) NOT NULL DEFAULT 0,
    TongTien DECIMAL(18,2) NOT NULL,

    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã thanh toán',

    CONSTRAINT CK_DON_HANG_PHI
        CHECK (PhiGiaoHang >= 0),

    CONSTRAINT CK_DON_HANG_TONGTIEN
        CHECK (TongTien >= 0),

    CONSTRAINT FK_DON_HANG_KHACH_HANG
        FOREIGN KEY (MaKH)
        REFERENCES KHACH_HANG(MaKH),

    CONSTRAINT FK_DON_HANG_LOAI_GIAO_HANG
        FOREIGN KEY (MaLoai)
        REFERENCES LOAI_GIAO_HANG(MaLoai)
);
GO


-- =========================================================
-- 9. CT_DON_HANG
-- Bảng trung gian DON_HANG - SAN_PHAM
-- =========================================================
CREATE TABLE CT_DON_HANG
(
    MaDH INT NOT NULL,
    MaSP INT NOT NULL,

    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,

    CONSTRAINT PK_CT_DON_HANG
        PRIMARY KEY (MaDH, MaSP),

    CONSTRAINT CK_CT_DON_HANG_SOLUONG
        CHECK (SoLuong > 0),

    CONSTRAINT CK_CT_DON_HANG_DONGIA
        CHECK (DonGia >= 0),

    CONSTRAINT FK_CT_DON_HANG_DON_HANG
        FOREIGN KEY (MaDH)
        REFERENCES DON_HANG(MaDH)
        ON DELETE CASCADE,

    CONSTRAINT FK_CT_DON_HANG_SAN_PHAM
        FOREIGN KEY (MaSP)
        REFERENCES SAN_PHAM(MaSP)
);
GO


-- =========================================================
-- 10. GIAO_DICH_THANH_TOAN
-- Quan hệ 1 - 0..1 với DON_HANG
-- =========================================================
CREATE TABLE GIAO_DICH_THANH_TOAN
(
    MaGD INT IDENTITY(1,1) PRIMARY KEY,
    MaDH INT NOT NULL UNIQUE,

    SoTien DECIMAL(18,2) NOT NULL,
    ThoiGian DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    TrangThai NVARCHAR(50) NOT NULL,
    MaThamChieu NVARCHAR(100) NULL,

    CONSTRAINT CK_GIAO_DICH_SOTIEN
        CHECK (SoTien >= 0),

    CONSTRAINT FK_GIAO_DICH_DON_HANG
        FOREIGN KEY (MaDH)
        REFERENCES DON_HANG(MaDH)
);
GO