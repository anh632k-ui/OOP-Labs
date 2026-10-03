using System;
using System.Data;
using EShoppingPrototype.Adapters;
using EShoppingPrototype.Data;

namespace EShoppingPrototype.Services
{
    public class DatHangService
    {
        private DonHangRepository donHangRepo =
            new DonHangRepository();

        private GioHangRepository gioHangRepo =
            new GioHangRepository();

        private PaymentAdapter payment =
            new PaymentAdapter();

        private EmailAdapter email =
            new EmailAdapter();

        public DataTable LayLoaiGiaoHang()
        {
            return donHangRepo.GetLoaiGiaoHang();
        }

        public DataRow LayKhachHang(int maKH)
        {
            return donHangRepo.GetKhachHang(maKH);
        }

        public decimal LayTamTinh(int maKH)
        {
            return gioHangRepo.GetTongTien(maKH);
        }

        public decimal TinhPhiGiaoHang(
            int maLoai,
            decimal phiCoBan,
            decimal tamTinh)
        {
            // Chuyển phát nhanh miễn phí từ 1 triệu
            if (maLoai == 2 &&
                tamTinh >= 1000000)
                return 0;

            // Trong ngày miễn phí từ 5 triệu
            if (maLoai == 3 &&
                tamTinh >= 5000000)
                return 0;

            return phiCoBan;
        }

        public int DatHang(
            int maKH,
            int maLoai,
            string hoTen,
            string diaChi,
            string dienThoai,
            string emailKhach,
            decimal phiGiaoHang)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
                throw new Exception(
                    "Chưa nhập họ tên người nhận.");

            if (string.IsNullOrWhiteSpace(diaChi))
                throw new Exception(
                    "Chưa nhập địa chỉ.");

            if (string.IsNullOrWhiteSpace(dienThoai))
                throw new Exception(
                    "Chưa nhập điện thoại.");

            decimal tamTinh =
                gioHangRepo.GetTongTien(maKH);

            if (tamTinh <= 0)
                throw new Exception(
                    "Giỏ hàng đang trống.");

            decimal tong =
                tamTinh + phiGiaoHang;

            if (!payment.KiemTraThanhToan(tong))
                throw new Exception(
                    "Thanh toán thất bại.");

            int maDH = donHangRepo.TaoDonHang(
                maKH,
                maLoai,
                hoTen,
                diaChi,
                dienThoai,
                phiGiaoHang,
                tong);

            email.GuiXacNhan(
                emailKhach,
                maDH);

            return maDH;
        }
    }
}