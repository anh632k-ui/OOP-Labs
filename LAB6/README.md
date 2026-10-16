LAB6 - QUẢN LÝ HỒ SƠ BỆNH ÁN
Thông tin sinh viên
Sinh viên thực hiện: Bùi Thế Anh
Mã số sinh viên: 1250080004
Lớp: 12_CNPM1
---
1. Nội dung thực hiện
LAB6 thực hiện các nội dung chính:
Phân tích nghiệp vụ quản lý hồ sơ bệnh án của bệnh nhân tại bệnh viện.
Xác định các lớp, thuộc tính, phương thức và mối quan hệ giữa các lớp.
Xây dựng sơ đồ Class Diagram.
Xây dựng sơ đồ Use Case tổng quát.
Xây dựng sơ đồ Use Case phân rã quy trình đăng ký khám đến nhận toa thuốc.
Xây dựng sơ đồ Activity Diagram cho quy trình đăng ký, khám bệnh và nhận toa.
Xây dựng sơ đồ Sequence Diagram cho nghiệp vụ lập toa thuốc.
Thiết kế cơ sở dữ liệu SQL Server gồm 14 bảng.
Tạo dữ liệu danh mục mẫu phục vụ quá trình thực hành.
Thiết kế giao diện ứng dụng bằng C# WinForms với 2 form chức năng.
Kết nối ứng dụng với SQL Server để lưu và tra cứu hồ sơ.
Thực hiện thao tác đăng ký bệnh nhân, cấp hồ sơ và ghi nhận khám bệnh.
Kiểm tra kết quả thao tác và ghi nhận hình ảnh minh chứng trong báo cáo.
Phạm vi chương trình thực hành tập trung vào hai chức năng chính: đăng ký, cấp hồ sơ bệnh án và ghi nhận lần khám, xét nghiệm, toa thuốc. Các chức năng khác được thể hiện trong phần phân tích và thiết kế, chưa xây dựng thành form riêng.
---
2. Yêu cầu môi trường
Hệ điều hành: Windows 10 / Windows 11
IDE: Visual Studio 2022
Framework: .NET Framework 4.7.2
Workload Visual Studio: `.NET desktop development`
Ngôn ngữ lập trình: C#
Giao diện: Windows Forms
Hệ quản trị CSDL: Microsoft SQL Server
Công cụ quản trị CSDL: SQL Server Management Studio (SSMS)
Thư viện truy cập dữ liệu: `System.Data.SqlClient`
Reference: `System.Configuration`
---
3. Cấu trúc thư mục
```text
OOP-Labs/
│
└── LAB6/
    │
    ├── README.md
    ├── .gitignore
    ├── 1250080004_Baocao_LAB6_Quanlyhosobenhan.docx
    ├── HoSoBenhAn.sln
    ├── csdl.sql
    │
    └── HoSoBenhAn/
        ├── HoSoBenhAn.csproj
        ├── Program.cs
        ├── App.config
        ├── Db.cs
        ├── Models.cs
        ├── BenhNhanRepository.cs
        ├── BenhNhanService.cs
        ├── KhamBenhRepository.cs
        ├── KhamBenhService.cs
        ├── FrmBenhNhan.cs
        ├── FrmBenhNhan.Designer.cs
        ├── FrmBenhNhan.resx
        ├── FrmKhamBenh.cs
        ├── FrmKhamBenh.Designer.cs
        └── FrmKhamBenh.resx
```
Các file `.Designer.cs` lưu bố cục và các điều khiển giao diện; các file `.cs` tương ứng chứa phần xử lý thao tác. Có thể mở trực tiếp các form trong View Designer của Visual Studio mà không cần chạy chương trình.
Báo cáo Word gồm 5 sơ đồ UML và 2 hình ảnh minh chứng thao tác trên ứng dụng WinForms.
---
4. Các chức năng của hệ thống
4.1. Đăng ký bệnh nhân và cấp hồ sơ
Form: `FrmBenhNhan`
Nhập họ tên, ngày sinh, địa chỉ và số điện thoại bệnh nhân.
Chọn đường dẫn ảnh bệnh nhân.
Nhập lệ phí quản lý năm và xác nhận đã thu phí.
Đăng ký bệnh nhân, tạo phiếu đăng ký và cấp mã hồ sơ bệnh án.
Tra cứu hồ sơ theo mã hồ sơ, họ tên hoặc số điện thoại.
Hiển thị danh sách hồ sơ đã đăng ký.
Mở form ghi nhận khám bệnh từ giao diện đăng ký.
4.2. Ghi nhận khám bệnh, xét nghiệm và toa thuốc
Form: `FrmKhamBenh`
Nhập mã hồ sơ bệnh án và chọn bác sĩ khám.
Chọn loại khám: định kỳ hoặc điều trị.
Nhập ngày khám, triệu chứng, thân nhiệt, huyết áp và chẩn đoán.
Chọn xét nghiệm, nhập kết quả và cập nhật danh sách xét nghiệm.
Chọn thuốc, nhập số lượng, liều dùng và lập danh sách thuốc.
Nhập viện phí, ngày xuất viện và ngày thanh toán.
Xác nhận đã xuất viện, đã thanh toán trước khi ghi nhận hồ sơ.
Lưu thông tin lần khám và xem lịch sử khám bệnh theo mã hồ sơ.
Đối với khám định kỳ, chương trình đặt viện phí bằng 0. Thông tin lần khám chỉ được ghi nhận khi đã xác nhận xuất viện và thanh toán.
4.3. Các nghiệp vụ được phân tích và thiết kế
Ngoài hai form đã hiện thực, mô hình UML và cơ sở dữ liệu còn đề cập đến:
Quản lý lịch hẹn khám bệnh.
Quản lý thông tin bác sĩ và khoa điều trị.
Quản lý danh mục thuốc và xét nghiệm.
Theo dõi lệ phí quản lý theo năm.
Quản lý lịch sử khám và các lần điều trị.
Những nghiệp vụ trên chưa được xây dựng thành các form quản lý riêng trong phạm vi LAB6.
---
5. Cơ sở dữ liệu
Hệ thống sử dụng cơ sở dữ liệu:
`QLHoSoBenhAn_Bai5`
Cơ sở dữ liệu gồm 14 bảng:
`BenhNhan`
`PhieuDangKy`
`HoSoBenhAn`
`PhiQuanLyNam`
`Khoa`
`BacSi`
`PhieuKham`
`VienPhi`
`XetNghiem`
`ChiDinhXetNghiem`
`Thuoc`
`ToaThuoc`
`CT_ToaThuoc`
`LichHen`
Script tạo cơ sở dữ liệu và dữ liệu danh mục mẫu được lưu tại:
`LAB6/csdl.sql`
Script có các bản ghi mẫu cho khoa, bác sĩ, thuốc và xét nghiệm. Các bảng liên kết bằng khóa chính, khóa ngoại và có một số ràng buộc kiểm tra dữ liệu.
Lưu ý: Nên chạy script trên cơ sở dữ liệu mới. File SQL sử dụng lệnh `CREATE TABLE`, vì vậy chạy lại khi các bảng đã tồn tại có thể phát sinh lỗi. Cần sao lưu dữ liệu trước khi chỉnh sửa cơ sở dữ liệu đang sử dụng.
---
6. Hướng dẫn chạy chương trình
Bước 1. Khởi tạo cơ sở dữ liệu
Mở SQL Server Management Studio (SSMS).
Kết nối đến SQL Server trên máy.
Mở file `LAB6/csdl.sql`.
Thực thi script để tạo cơ sở dữ liệu `QLHoSoBenhAn_Bai5`, các bảng và dữ liệu danh mục mẫu.
Bước 2. Cấu hình kết nối
Mở file `LAB6/HoSoBenhAn/App.config` và kiểm tra chuỗi kết nối:
```xml
<connectionStrings>
  <add name="HoSoBenhAn"
       connectionString="Data Source=TEN_SQL_SERVER;Initial Catalog=QLHoSoBenhAn_Bai5;Integrated Security=True;TrustServerCertificate=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```
Thay `TEN_SQL_SERVER` bằng tên SQL Server trên máy đang sử dụng. Cấu hình trên sử dụng xác thực Windows.
Bước 3. Chạy ứng dụng
Mở `LAB6/HoSoBenhAn.sln` bằng Visual Studio 2022.
Chọn `Build → Rebuild Solution` để biên dịch dự án.
Nhấn `F5` để chạy chương trình.
Tại `FrmBenhNhan`, nhập thông tin bệnh nhân và cấp hồ sơ.
Chọn chức năng mở form khám bệnh để truy cập `FrmKhamBenh`.
Nhập mã hồ sơ đã cấp để ghi nhận khám bệnh, xét nghiệm và toa thuốc.
Có thể mở `FrmBenhNhan.cs [Design]` và `FrmKhamBenh.cs [Design]` để xem, điều chỉnh giao diện trực tiếp trong Visual Studio.
---
7. Kiểm thử
Các nội dung kiểm tra thực hành gồm:
Đăng ký bệnh nhân với các thông tin bắt buộc.
Ghi nhận lệ phí năm và cấp mã hồ sơ bệnh án.
Tra cứu hồ sơ sau khi đăng ký.
Chọn bác sĩ và loại khám bệnh.
Nhập triệu chứng, chẩn đoán, nhiệt độ và huyết áp.
Thêm xét nghiệm và nhập kết quả.
Thêm thuốc, số lượng và liều dùng.
Kiểm tra viện phí bằng 0 đối với khám định kỳ.
Ghi nhận lần khám sau khi xác nhận xuất viện và thanh toán.
Xem lại lịch sử khám bệnh theo mã hồ sơ.
Hai hình ảnh trong báo cáo ghi nhận trường hợp cấp hồ sơ bệnh án thành công và ghi nhận phiếu khám thành công. Đây là minh chứng cho các thao tác đã thực hiện, không thay thế việc kiểm thử toàn bộ chức năng và trường hợp ngoại lệ.
---
8. Báo cáo thực hành
Tên file:
`1250080004_Baocao_LAB6_Quanlyhosobenhan.docx`
Báo cáo gồm:
Sơ đồ Class Diagram.
Sơ đồ Use Case tổng quát.
Sơ đồ Use Case phân rã quy trình đăng ký khám đến nhận toa thuốc.
Sơ đồ Activity Diagram.
Sơ đồ Sequence Diagram cho nghiệp vụ lập toa thuốc.
Giao diện `FrmBenhNhan` và kết quả cấp hồ sơ bệnh án.
Giao diện `FrmKhamBenh` và kết quả ghi nhận lần khám.
---
Công nghệ sử dụng
C#
Windows Forms
.NET Framework 4.7.2
Microsoft SQL Server
ADO.NET
UML
Visual Studio 2022
---
Sinh viên thực hiện: Bùi Thế Anh  
MSSV: 1250080004  
Lớp: 12_CNPM1
