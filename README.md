# OOP-Labs - Thực Hành Phát Triển Phần Mềm Hướng Đối Tượng

Kho lưu trữ mã nguồn các bài thực hành môn **Phương pháp phát triển phần mềm hướng đối tượng (OOAD)**.

* **Sinh viên thực hiện:** Bùi Thế Anh
* **Mã số sinh viên:** 1250080004[cite: 4]

---

## LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN

Ứng dụng quản lý khách sạn xây dựng trên nền tảng **C# Windows Forms**, tuân thủ kiến trúc phân tầng (UI $\rightarrow$ Service/Business Logic $\rightarrow$ Data Access $\rightarrow$ SQL Server).

### 1. Yêu cầu môi trường
* **Hệ điều hành:** Windows 10 / 11
* **Môi trường phát triển (IDE):** Visual Studio 2022 (cài đặt workload *.NET desktop development*)
* **Hệ quản trị CSDL:** Microsoft SQL Server (LocalDB / Express / Developer) và SQL Server Management Studio (SSMS)
* **Gói thư viện NuGet:** `System.Data.SqlClient`

---

### 2. Cấu trúc thư mục dự án

```text
OOP-Labs/
│
└── LAB3/
    ├── QLKhachSan.sql          # Script CSDL đầy đủ bảng, khóa, ràng buộc & dữ liệu mẫu
    └── Lab3_QLKhachSan/        # Mã nguồn dự án Visual Studio 2022
        ├── App.config          # Cấu hình chuỗi kết nối SQL Server
        ├── Program.cs          # Điểm khởi chạy ứng dụng (Main)
        ├── Data/
        │   └── Db.cs           # Tầng truy cập dữ liệu (Helper ADO.NET kết nối SQL)
        ├── Services/           # Tầng nghiệp vụ xử lý logic và Transaction
        │   ├── DanhMucService.cs
        │   ├── PhongTienNghiService.cs
        │   ├── DatPhongService.cs
        │   ├── DichVuService.cs
        │   ├── TraPhongService.cs
        │   └── ThongKeService.cs
        └── Forms/              # Tầng giao diện người dùng (WinForms)
            ├── FrmMain.cs            # Màn hình chính điều hướng
            ├── FrmDanhMuc.cs         # Quản lý khu vực, nhân viên, tiện nghi, dịch vụ
            ├── FrmPhongTienNghi.cs   # Quản lý phòng, thiết bị & lập phiếu lắp đặt
            ├── FrmDatPhong.cs        # Đặt/nhận phòng, khách hàng & người lưu trú
            ├── FrmDichVu.cs          # Ghi nhận dịch vụ (tự cộng dồn cùng ngày)
            ├── FrmTraPhong.cs        # Kiểm tra tiện nghi, đền bù, hóa đơn & thanh toán
            └── FrmThongKe.cs         # Báo cáo doanh thu và tổng hợp dịch vụ
