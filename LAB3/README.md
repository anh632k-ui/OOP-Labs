# OOP-Labs - Thực Hành Phát Triển Phần Mềm Hướng Đối Tượng

Kho lưu trữ mã nguồn các bài thực hành môn Phương pháp phát triển phần mềm hướng đối tượng .

* **Sinh viên thực hiện:** Bùi Thế Anh
* **Mã số sinh viên:** 1250080004

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
        │   └── Db.cs            # Tầng truy cập dữ liệu (Helper ADO.NET kết nối SQL)
        ├── Services/            # Tầng nghiệp vụ xử lý logic và Transaction
        │   ├── DanhMucService.cs
        │   ├── PhongTienNghiService.cs
        │   ├── DatPhongService.cs
        │   ├── DichVuService.cs
        │   ├── TraPhongService.cs
        │   └── ThongKeService.cs
        └── Forms/               # Tầng giao diện người dùng (WinForms)
            ├── FrmMain.cs            # Màn hình chính điều hướng
            ├── FrmDanhMuc.cs         # Quản lý khu vực, nhân viên, tiện nghi, dịch vụ
            ├── FrmPhongTienNghi.cs   # Quản lý phòng, thiết bị & lập phiếu lắp đặt
            ├── FrmDatPhong.cs        # Đặt/nhận phòng, khách hàng & người lưu trú
            ├── FrmDichVu.cs          # Ghi nhận dịch vụ (tự cộng dồn cùng ngày)
            ├── FrmTraPhong.cs        # Kiểm tra tiện nghi, đền bù, hóa đơn & thanh toán
            └── FrmThongKe.cs         # Báo cáo doanh thu và tổng hợp dịch vụ

```

---

### 3. Hướng dẫn cài đặt và chạy trên máy tính bất kỳ

Bất kỳ ai (giảng viên hoặc người khác) khi tải mã nguồn về đều có thể chạy chương trình thành công theo 5 bước sau:

#### Bước 1: Tải mã nguồn về máy

* **Cách 1 (Dùng Git):** Mở Terminal / PowerShell và gõ:
```bash
git clone https://github.com/anh632k-ui/OOP-Labs.git

```


* **Cách 2:** Bấm vào nút xanh Code trên trang GitHub $\rightarrow$ chọn Download ZIP $\rightarrow$ giải nén thư mục vừa tải về.

#### Bước 2: Khởi tạo Cơ sở dữ liệu (SQL Server)

* Mở SQL Server Management Studio (SSMS) và đăng nhập vào SQL Server trên máy bạn.
* Vào menu File $\rightarrow$ Open $\rightarrow$ File... (hoặc nhấn Ctrl + O) $\rightarrow$ chọn file QLKhachSan.sql nằm trong thư mục LAB3.
* Nhấn Execute (F5) để chạy toàn bộ file:
* SQL Server sẽ tự tạo Database tên là QuanLyKhachSan.
* Tự động sinh đầy đủ 18 bảng với các ràng buộc nghiệp vụ (Khóa chính, Khóa ngoại, Ràng buộc Unique, Check).
* Tự động nạp sẵn dữ liệu ban đầu cho các bảng Phòng, Dịch vụ, Nhân viên, Tiện nghi để có thể test ngay.



#### Bước 3: Cấu hình lại chuỗi kết nối (App.config)

Mỗi máy tính có tên SQL Server khác nhau, vì vậy cần sửa lại chuỗi kết nối trước khi khởi động:

* Vào thư mục LAB3/Lab3_QLKhachSan/, mở file App.config bằng Notepad hoặc Visual Studio.
* Sửa lại thuộc tính connectionString ở thẻ `<connectionStrings>` cho khớp với cấu hình máy bạn:
* **Trường hợp 1:** Dùng SQL Server cài bằng tài khoản Windows thông thường:
```xml
<connectionStrings>
  <add name="QuanLyKhachSanDB" 
       connectionString="Server=localhost;Database=QuanLyKhachSan;Trusted_Connection=True;TrustServerCertificate=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>

```


*(Thay localhost bằng . hoặc TÊN_MÁY_CỦA_BẠN).*
* **Trường hợp 2:** Dùng bản SQL Server Express:
```xml
connectionString="Server=.\SQLEXPRESS;Database=QuanLyKhachSan;Trusted_Connection=True;TrustServerCertificate=True;"

```


* **Trường hợp 3:** Dùng máy chủ ảo LocalDB đi kèm Visual Studio:
```xml
connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True;"

```



#### Bước 4: Mở dự án và phục hồi gói thư viện

* Khởi động Visual Studio 2022 (yêu cầu đã cài gói .NET desktop development).
* Chọn Open a project or solution $\rightarrow$ tìm và mở file Lab3_QLKhachSan.csproj.
* Nhấn tổ hợp phím Ctrl + Shift + B để Build:
* Visual Studio sẽ tự động tải (Restore) gói thư viện System.Data.SqlClient về nếu máy chưa có.
* Cửa sổ thông báo góc dưới báo Build: 1 succeeded, 0 failed là thành công.



#### Bước 5: Khởi chạy và trải nghiệm

* Nhấn phím F5 (hoặc nút Start màu xanh trên thanh công cụ) để chạy.
* Màn hình chính FrmMain xuất hiện, điều hướng đến đầy đủ 6 chức năng nghiệp vụ:
* **Danh mục:** Quản lý khu vực, nhân viên, tiện nghi, dịch vụ, quy định.
* **Phòng - Tiện nghi:** Quản lý phòng, danh sách tiện nghi và lập phiếu lắp đặt.
* **Đặt / Nhận phòng:** Chọn phòng theo sức chứa, kiểm tra chống trùng lịch, thêm người lưu trú.
* **Sử dụng dịch vụ:** Tự động gom nhóm và cộng dồn dịch vụ dùng cùng ngày theo phòng.
* **Trả phòng - Thanh toán:** Kiểm tra hư hại tiện nghi, lập phiếu đền bù, tính hóa đơn và thanh toán nhiều phương thức.
* **Thống kê:** Tổng hợp doanh thu, lượng phiếu và báo cáo tần suất dịch vụ.



---

### 4. Xử lý sự cố thường gặp (Troubleshooting)

* **Lỗi không kết nối được CSDL (A network-related or instance-specific error occurred...):**
* Kiểm tra lại tên Server trong App.config đã viết đúng với tên hiển thị khi đăng nhập SSMS chưa.
* Mở công cụ Services trên Windows, đảm bảo dịch vụ SQL Server (MSSQLSERVER) hoặc SQL Server (SQLEXPRESS) đang ở trạng thái Running.


* **Lỗi thiếu gói thư viện System.Data.SqlClient:**
* Mở menu Tools $\rightarrow$ NuGet Package Manager $\rightarrow$ Package Manager Console.
* Chạy lệnh: `Install-Package System.Data.SqlClient` và nhấn Enter.
