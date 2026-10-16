using System;
using System.Collections.Generic;
namespace HoSoBenhAnPrototype {
    public sealed class BenhNhanData {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string DuongDanAnh { get; set; }
        public decimal PhiNam { get; set; }
    }
    public sealed class ThuocKeData {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public string LieuDung { get; set; }
    }
    public sealed class XetNghiemData {
        public int MaXetNghiem { get; set; }
        public string KetQua { get; set; }
    }
    public sealed class KhamBenhData {
        public int MaHoSo { get; set; }
        public int MaBacSi { get; set; }
        public DateTime NgayGioKham { get; set; }
        public string LoaiKham { get; set; }
        public string TrieuChung { get; set; }
        public decimal? ThanNhiet { get; set; }
        public string HuyetAp { get; set; }
        public string ChanDoan { get; set; }
        public DateTime NgayXuatVien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal VienPhi { get; set; }
        public List<ThuocKeData> Thuoc { get; } = new List<ThuocKeData>();
        public List<XetNghiemData> XetNghiem { get; } = new List<XetNghiemData>();
    }
}
