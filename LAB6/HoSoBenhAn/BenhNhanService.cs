using System;
using System.Linq;
namespace HoSoBenhAnPrototype {
    public sealed class BenhNhanService {
        private readonly BenhNhanRepository repository = new BenhNhanRepository();
        public int DangKy(BenhNhanData data, bool daThuPhi) {
            if (string.IsNullOrWhiteSpace(data.HoTen) || string.IsNullOrWhiteSpace(data.DiaChi))
                throw new ArgumentException("Cần nhập họ tên và địa chỉ.");
            if (data.NgaySinh.Date >= DateTime.Today)
                throw new ArgumentException("Ngày sinh phải trước ngày hiện tại.");
            if (string.IsNullOrWhiteSpace(data.DienThoai) || data.DienThoai.Length < 9 || data.DienThoai.Length > 11
                || !data.DienThoai.All(char.IsDigit))
                throw new ArgumentException("Điện thoại phải có 9-11 chữ số.");
            if (string.IsNullOrWhiteSpace(data.DuongDanAnh) || !System.IO.File.Exists(data.DuongDanAnh))
                throw new ArgumentException("Cần chọn một ảnh 3x4 đang tồn tại.");
            if (!daThuPhi || data.PhiNam <= 0)
                throw new ArgumentException("Phải thu phí quản lý năm trước khi cấp hồ sơ.");
            return repository.DangKy(data);
        }
        public System.Data.DataTable TimKiem(string key) { return repository.TimKiem((key ?? "").Trim()); }
    }
}
