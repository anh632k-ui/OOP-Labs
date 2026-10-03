# LAB4 - HỆ THỐNG e-SHOPPING

Bài thực hành phân tích, thiết kế và hiện thực một phần hệ thống **e-SHOPPING** bằng **C# Windows Forms**, **SQL Server** và các mô hình UML.

Ứng dụng mẫu được xây dựng theo kiến trúc:

**UI → Service / Adapter → Data → SQL Server**

Trong đó các hệ thống bên ngoài được tách qua lớp Adapter gồm:

- Hệ thống quản lý sản phẩm
- Hệ thống thanh toán trực tuyến
- Dịch vụ email

---

## Thông tin sinh viên

- **Sinh viên thực hiện:** Bùi Thế Anh
- **Mã số sinh viên:** 1250080004
- **Lớp:** 12_CNPM1

---

## 1. Nội dung thực hiện

LAB4 thực hiện các nội dung chính:

- Phân tích nghiệp vụ hệ thống e-SHOPPING.
- Xây dựng sơ đồ Use Case tổng quát và phân rã Use Case.
- Xây dựng sơ đồ lớp phân tích.
- Xây dựng sơ đồ trạng thái.
- Xây dựng sơ đồ tuần tự.
- Xây dựng sơ đồ lớp thiết kế.
- Phân rã chức năng hệ thống.
- Xây dựng sơ đồ hoạt động.
- Chuyển mô hình lớp sang cơ sở dữ liệu quan hệ.
- Xây dựng cơ sở dữ liệu bằng SQL Server.
- Hiện thực ứng dụng mẫu bằng C# WinForms.
- Kiểm thử và truy vết yêu cầu.

---

## 2. Yêu cầu môi trường

- **Hệ điều hành:** Windows 10 / Windows 11
- **IDE:** Visual Studio 2022
- **Framework:** .NET Framework 4.7.2
- **Workload Visual Studio:** `.NET desktop development`
- **Hệ quản trị CSDL:** Microsoft SQL Server
- **Công cụ quản trị CSDL:** SQL Server Management Studio (SSMS)
- **Thư viện truy cập dữ liệu:** `System.Data.SqlClient`
- **Reference cần sử dụng:** `System.Configuration`

---

## 3. Cấu trúc thư mục

```text
OOP-Labs/
│
└── LAB4/
    │
    ├── README.md
    │
    ├── EShoppingDB.sql
    │
    ├── LAB4_1250080004_BuiTheAnh.docx
    │
    └── LAB4/
        └── EShoppingPrototype_/
            │
            ├── App.config
            ├── Program.cs
            │
            ├── Adapters/
            │   ├── ProductAdapter.cs
            │   ├── PaymentAdapter.cs
            │   └── EmailAdapter.cs
            │
            ├── Data/
            │   ├── DbConnection.cs
            │   ├── GioHangRepository.cs
            │   └── DonHangRepository.cs
            │
            ├── Services/
            │   ├── GioHangService.cs
            │   └── DatHangService.cs
            │
            └── UI/
                ├── FrmGioHang.cs
                └── FrmThanhToan.cs
