
# LAB5 - QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT

## Thông tin sinh viên

- **Sinh viên thực hiện:** Bùi Thế Anh
- **Mã số sinh viên:** 1250080004
- **Lớp:** 12_CNPM1

---

## 1. Nội dung thực hiện

LAB5 thực hiện các nội dung chính:

- Phân tích nghiệp vụ quản lý công ty du lịch Văn Hóa Việt.
- Xây dựng 2 sơ đồ Use Case phân rã.
- Xây dựng 2 sơ đồ Activity Diagram.
- Xây dựng 2 sơ đồ Sequence Diagram.
- Phân tích và thiết kế cơ sở dữ liệu dựa trên mô hình ERD.
- Xây dựng cơ sở dữ liệu gồm 16 bảng bằng SQL Server.
- Sử dụng dữ liệu mẫu để kiểm tra các chức năng.
- Thiết kế giao diện ứng dụng bằng C# WinForms.
- Xây dựng 8 form chức năng và 1 form chính.
- Kết nối ứng dụng với SQL Server.
- Hiện thực các nghiệp vụ quản lý tour và khách du lịch.
- Kiểm thử chức năng và ghi nhận kết quả thực hiện.

---

## 2. Yêu cầu môi trường

- **Hệ điều hành:** Windows 10 / Windows 11
- **IDE:** Visual Studio 2022
- **Framework:** .NET Framework 4.7.2
- **Workload Visual Studio:** `.NET desktop development`
- **Ngôn ngữ lập trình:** C#
- **Hệ quản trị CSDL:** Microsoft SQL Server
- **Công cụ quản trị CSDL:** SQL Server Management Studio (SSMS)
- **Thư viện truy cập dữ liệu:** `System.Data.SqlClient`
- **Reference:** `System.Configuration`

---

## 3. Cấu trúc thư mục

```text
OOP-Labs/
│
└── LAB5/
    │
    ├── README.md
    │
    ├── 1250080004_Bao_cao_LAB5_Quan_ly_cong_ty_du_lich.docx
    │
    └── LAB5_QuanLyCongTyDuLich/
        │
        ├── QuanLyCongTyDuLich.sln
        ├── QuanLyCongTyDuLich.csproj
        ├── Program.cs
        ├── App.config
        │
        ├── Data/
        │   └── Db.cs
        │
        ├── Database/
        │   └── QuanLyCongTyDuLich.sql
        │
        ├── Services/
        │   ├── Models.cs
        │   ├── KetNoiService.cs
        │   ├── DanhMucService.cs
        │   ├── TourService.cs
        │   ├── ChuyenLeService.cs
        │   ├── DangKyLeService.cs
        │   ├── DangKyDoanService.cs
        │   ├── PhanCongService.cs
        │   ├── KetThucService.cs
        │   └── ThongKeService.cs
        │
        ├── Forms/
        │   ├── FrmMain.cs
        │   ├── FrmDanhMuc.cs
        │   ├── FrmTour.cs
        │   ├── FrmChuyenLe.cs
        │   ├── FrmDangKyLe.cs
        │   ├── FrmDangKyDoan.cs
        │   ├── FrmPhanCongHDV.cs
        │   ├── FrmKetThucKhaoSat.cs
        │   ├── FrmLuongThongKe.cs
        │   ├── FormHelper.cs
        │   └── ...
        │
        └── Tests/
            └── KiemTraDuLieu.sql
```

Các file `.Designer.cs` nằm trong thư mục `Forms/` cùng với các form tương ứng.

Báo cáo Word chứa 6 sơ đồ UML bổ sung và hình ảnh minh chứng quá trình thực hành.

---

## 4. Các chức năng của hệ thống

### 4.1. Quản lý danh mục

Form: `FrmDanhMuc`

- Quản lý phương tiện du lịch.
- Quản lý điểm bán vé.
- Quản lý hướng dẫn viên.
- Quản lý điểm tham quan.
- Thêm mới và hiển thị dữ liệu danh mục.

### 4.2. Quản lý tour và hành trình

Form: `FrmTour`

- Quản lý thông tin tour du lịch.
- Quản lý các điểm dừng trong hành trình.
- Quản lý phương tiện theo từng chặng.
- Quản lý các điểm tham quan thuộc tour.
- Theo dõi trạng thái mở bán của tour.

### 4.3. Quản lý lịch chuyến khách lẻ

Form: `FrmChuyenLe`

- Chọn tour đang mở bán.
- Tạo lịch chuyến khách lẻ.
- Tính ngày về dựa trên số ngày của tour.
- Quản lý trạng thái đăng ký chuyến.
- Đóng đăng ký chuyến khi cần thiết.

### 4.4. Đăng ký khách lẻ

Form: `FrmDangKyLe`

- Chọn chuyến khách lẻ.
- Nhập thông tin người đăng ký.
- Chọn điểm bán vé.
- Nhập số lượng khách.
- Tính tiền vé và ghi nhận đăng ký.

### 4.5. Đăng ký khách theo đoàn

Form: `FrmDangKyDoan`

- Quản lý thông tin đoàn khách.
- Lập phiếu đăng ký tour theo đoàn.
- Nhập số lượng người và thông tin tiền cọc.
- Kiểm tra danh sách thành viên khi mua bảo hiểm.
- Hủy đăng ký đoàn theo quy định mất tiền cọc.

### 4.6. Phân công hướng dẫn viên

Form: `FrmPhanCongHDV`

- Chọn hướng dẫn viên đang làm việc.
- Phân công hướng dẫn viên cho chuyến lẻ hoặc đoàn.
- Theo dõi thời gian thực hiện tour.
- Ghi nhận thù lao hướng dẫn viên.

### 4.7. Kết thúc tour và khảo sát

Form: `FrmKetThucKhaoSat`

- Ghi nhận thanh toán sau tour đối với khách đoàn.
- Theo dõi số tiền còn phải thanh toán.
- Quản lý phiếu khảo sát khách hàng.
- Ghi nhận điểm đánh giá và góp ý.

### 4.8. Quản lý lương và thống kê

Form: `FrmLuongThongKe`

- Tính lương hướng dẫn viên theo tháng và năm.
- Tổng hợp lương cơ bản và thù lao theo tour.
- Thống kê đăng ký khách lẻ và khách đoàn.
- Thống kê phiếu đoàn đã hủy.
- Thống kê thanh toán và phản hồi khảo sát.

---

## 5. Cơ sở dữ liệu

Hệ thống sử dụng cơ sở dữ liệu:

`QuanLyCongTyDuLich`

Cơ sở dữ liệu gồm 16 bảng:

1. `Tour`
2. `PhuongTien`
3. `DiemThamQuan`
4. `DiemBanVe`
5. `HuongDanVien`
6. `TourDiemDung`
7. `TourPhuongTien`
8. `TourDiemThamQuan`
9. `ChuyenLe`
10. `DoanKhach`
11. `DangKyDoan`
12. `ThanhVienDoan`
13. `DangKyLe`
14. `PhanCongHDV`
15. `ThanhToanDoan`
16. `KhaoSat`

Script tạo cơ sở dữ liệu và thêm dữ liệu mẫu được lưu tại:

`Database/QuanLyCongTyDuLich.sql`

**Lưu ý:** Script có các lệnh xóa và tạo lại bảng. Cần sao lưu dữ liệu trước khi chạy lại trên CSDL đã sử dụng.

---

## 6. Hướng dẫn chạy chương trình

### Bước 1. Khởi tạo cơ sở dữ liệu

- Mở SQL Server Management Studio (SSMS).
- Kết nối đến SQL Server.
- Mở file `Database/QuanLyCongTyDuLich.sql`.
- Thực thi script để tạo các bảng và dữ liệu mẫu.

### Bước 2. Cấu hình kết nối

Mở file `App.config` và kiểm tra chuỗi kết nối:

```xml
<connectionStrings>
  <add name="QuanLyCongTyDuLichDB"
       connectionString="Data Source=TEN_SQL_SERVER;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Thay `TEN_SQL_SERVER` bằng tên SQL Server trên máy đang sử dụng.

### Bước 3. Chạy ứng dụng

- Mở `QuanLyCongTyDuLich.sln` bằng Visual Studio 2022.
- Chọn `Build → Rebuild Solution`.
- Nhấn `F5` để chạy chương trình.
- Tại `FrmMain`, sử dụng chức năng kiểm tra kết nối CSDL.
- Truy cập các form để thực hiện nghiệp vụ.

---

## 7. Kiểm thử

Các nội dung kiểm thử thực hành gồm:

- Thêm phương tiện, điểm bán vé, hướng dẫn viên và điểm tham quan.
- Kiểm tra danh sách dữ liệu sau khi thêm mới.
- Hiển thị thông tin tour và đăng ký khách lẻ.
- Lập phiếu đăng ký đoàn.
- Kiểm tra điều kiện mua bảo hiểm cho đoàn.
- Xác nhận hủy đăng ký đoàn và cập nhật trạng thái mất cọc.
- Ghi nhận thanh toán sau tour.
- Ghi nhận phản hồi khảo sát khách hàng.
- Tính lương hướng dẫn viên theo tháng.
- Thống kê hoạt động theo khoảng thời gian.

File `Tests/KiemTraDuLieu.sql` hỗ trợ kiểm tra dữ liệu trên SQL Server.

Các hình ảnh minh chứng và kết quả thực hiện được trình bày trong báo cáo Word của LAB5.

---

## 8. Báo cáo thực hành

**Tên file:**

`1250080004_Bao_cao_LAB5_Quan_ly_cong_ty_du_lich.docx`

Báo cáo gồm:
- Sơ đồ Use Case phân rã.
- Sơ đồ Activity Diagram.
- Sơ đồ Sequence Diagram.
- Giao diện các chức năng WinForms.
- Hình ảnh thao tác và kết quả kiểm thử.

---

## Công nghệ sử dụng

- C#
- Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server
- ADO.NET
- UML
- Visual Studio 2022

---

**Sinh viên thực hiện:** Bùi Thế Anh  
**MSSV:** 1250080004  
**Lớp:** 12_CNPM1
