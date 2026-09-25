# LAB 2: HỆ THỐNG QUẢN LÝ THƯ VIỆN (QuanLyThuVienDB)

Dự án ứng dụng Desktop xây dựng trên nền tảng **Windows Forms (.NET 8.0)** kết hợp hệ quản trị cơ sở dữ liệu **Microsoft SQL Server**, phục vụ môn học **Phát triển phần mềm hướng đối tượng**.

---

## 👨‍💻 Thông Tin Sinh Viên

* **Họ và tên:** Bùi Thế Anh
* **MSSV:** 1250080004
* **Lớp:** 12_CNPM1
* **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng

---

## 🛠 Công Nghệ & Yêu Cầu Môi Trường

* **Ngôn ngữ:** C# (.NET 8.0 Windows Desktop SDK)
* **IDE khuyên dùng:** Microsoft Visual Studio 2022 (đã cài workload *.NET Desktop Development*)
* **Hệ quản trị CSDL:** Microsoft SQL Server 2019 / 2022 (hoặc SQL Server Express)
* **Công cụ quản lý CSDL:** SQL Server Management Studio (SSMS)
* **Thư viện kết nối CSDL:** `Microsoft.Data.SqlClient` (v5.x trở lên)

---

## 📁 Cấu Trúc Thư Mục Dự Án

```text
LAB2/
│
├── LAB2.sln                     # File Solution chính mở bằng Visual Studio
├── QuanLyThuVienDB.sql          # Kịch bản tạo Database, Tables, Ràng buộc & Dữ liệu mẫu
│
└── LAB2/                        # Mã nguồn Project C#
    ├── FrmQLThuVien.cs          # Form Menu điều hướng chính
    ├── FrmDanhMuc.cs            # Quản lý Danh mục (Nhân viên, Thể loại, Nhà xuất bản)
    ├── FrmDocGia.cs             # Quản lý Độc giả & Thẻ thư viện
    ├── FrmSach.cs               # Quản lý Đầu sách & Tồn kho
    ├── FrmMuonTra.cs            # Quản lý Phiếu mượn & Trả sách
    ├── FrmThongKe.cs            # Thống kê mượn/trả, quá hạn và xử lý phiếu phạt
    └── Program.cs               # Điểm khởi chạy ứng dụng (Main Entry Point)

```

---

## 🚀 Hướng Dẫn Cài Đặt & Chạy Ứng Dụng

Thực hiện lần lượt theo 4 bước sau để cài đặt và chạy ứng dụng trên máy mới:

### Bước 1: Khởi tạo Cơ sở dữ liệu (Database Setup)

* Mở SQL Server Management Studio (SSMS) và đăng nhập vào SQL Server của bạn.
* Mở file script `QuanLyThuVienDB.sql` (nằm ở thư mục gốc của bài tập).
* Nhấn Execute (F5) để chạy script.
* **Lưu ý:** Script đã được cấu hình tự động xóa bản cũ (nếu có), tạo Database mới mang tên QuanLyThuVienDB, thiết lập đầy đủ khóa chính/khóa ngoại và chèn sẵn dữ liệu mẫu.

### Bước 2: Mở Solution bằng Visual Studio

* Điều hướng đến thư mục dự án trên máy tính.
* Click đúp vào file `LAB2.sln` để mở dự án trên Visual Studio 2022.

### Bước 3: Cấu hình chuỗi kết nối CSDL (Connection String)

Nếu tên SQL Server của bạn khác với cấu hình mặc định trong code, vui lòng chỉnh sửa biến `connectionString` trong các file Form (`FrmDanhMuc.cs`, `FrmMuonTra.cs`, `FrmThongKe.cs`...):

```csharp
// Thay đổi giá trị Server bằng tên máy chủ SQL trên máy bạn (ví dụ: . hoặc localhost hoặc TÊN_SERVER_CỦA_BẠN)
private string connectionString = @"Server=.;Database=QuanLyThuVienDB;Trusted_Connection=True;TrustServerCertificate=True;";

```

### Bước 4: Biên dịch và Khởi chạy chương trình

* Nhấn tổ hợp phím Ctrl + Shift + B (hoặc chọn menu Build -> Rebuild Solution) để Visual Studio tự động khôi phục các gói NuGet và biên dịch mã nguồn.
* Nhấn phím F5 (hoặc nút Start) để khởi chạy ứng dụng.

---

## 📌 Các Chức Năng Chính Của Hệ Thống

| Phân hệ / Form | Mô tả chức năng |
| --- | --- |
| **FrmQLThuVien** | Giao diện trang chủ trung tâm, điều hướng truy cập nhanh vào tất cả các phân hệ nghiệp vụ. |
| **FrmDanhMuc** | TabControl tích hợp quản lý 3 danh mục nền tảng: Nhân viên, Thể loại sách và Nhà xuất bản (Thêm, Sửa, Xóa, Làm mới). |
| **FrmDocGia** | Tiếp nhận thông tin bạn đọc, quản lý phát hành và cập nhật thẻ thư viện (TheDocGia). |
| **FrmSach** | Quản lý kho sách, thông tin đầu sách, tác giả, nhà xuất bản, năm xuất bản và số lượng hiện có. |
| **FrmMuonTra** | Lập phiếu mượn sách, ghi nhận danh sách chi tiết các cuốn sách mượn (ChiTietPhieuMuon), xử lý trả sách và ghi nhận tình trạng sách. |
| **FrmThongKe** | Lọc dữ liệu theo mốc thời gian (Từ ngày - Đến ngày), tổng hợp KPI thống kê (Số lượt mượn, Số sách quá hạn, Sách hỏng/mất, Tổng tiền phạt thu được) và danh sách chi tiết các phiếu phạt (PhieuPhat). |

---

## 🔒 Xử Lý Ràng Buộc & Toàn Vẹn Dữ Liệu

* **Ràng buộc khóa chính / duy nhất:** Mã thể loại, mã NXB, mã độc giả không được trùng lặp. Đảm bảo tên thể loại là duy nhất (UNIQUE).
* **Ràng buộc khóa ngoại (Foreign Key):** Không cho phép xóa danh mục khi đang có sách liên kết; không cho phép xóa nhân viên/độc giả khi đang có giao dịch mượn sách.
* **Kiểm tra hợp lệ (Check Constraints):** Số lượng sách hiện có $\ge 0$, ngày hẹn trả phải lớn hơn hoặc bằng ngày mượn, phí phạt $\ge 0$.
