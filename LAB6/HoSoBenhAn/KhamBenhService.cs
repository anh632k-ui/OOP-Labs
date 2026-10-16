using System;
using System.Linq;
namespace HoSoBenhAnPrototype {
    public sealed class KhamBenhService {
        private readonly KhamBenhRepository repository = new KhamBenhRepository();
        public KhamBenhRepository Repository { get { return repository; } }
        public int GhiNhan(KhamBenhData d, bool daXuatVien, bool daThanhToan) {
            if (d.MaHoSo <= 0 || d.MaBacSi <= 0)
                throw new ArgumentException("Chưa chọn hồ sơ hoặc bác sĩ.");
            if (string.IsNullOrWhiteSpace(d.TrieuChung) || string.IsNullOrWhiteSpace(d.ChanDoan))
                throw new ArgumentException("Thiếu triệu chứng hoặc chẩn đoán.");
            if (!daXuatVien || !daThanhToan)
                throw new ArgumentException("Chỉ ghi nhận hồ sơ sau khi xuất viện và hoàn tất thanh toán.");
            if (d.NgayGioKham > DateTime.Now || d.NgayXuatVien < d.NgayGioKham || d.NgayThanhToan < d.NgayGioKham)
                throw new ArgumentException("Ngày giờ khám, xuất viện, thanh toán không hợp lệ.");
            if (d.VienPhi < 0 || (d.LoaiKham == "DinhKy" && d.VienPhi != 0))
                throw new ArgumentException("Khám định kỳ miễn phí (viện phí phải bằng 0).");
            if (d.Thuoc.GroupBy(x => x.MaThuoc).Any(g => g.Count() > 1) ||
                d.Thuoc.Any(x => x.SoLuong <= 0 || string.IsNullOrWhiteSpace(x.LieuDung)))
                throw new ArgumentException("Thuốc trùng hoặc thiếu số lượng / liều dùng.");
            if (d.XetNghiem.GroupBy(x => x.MaXetNghiem).Any(g => g.Count() > 1))
                throw new ArgumentException("Không nhập trùng xét nghiệm.");
            return repository.GhiNhan(d);
        }
    }
}
