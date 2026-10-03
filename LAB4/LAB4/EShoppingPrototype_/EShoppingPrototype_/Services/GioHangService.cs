using System;
using System.Data;
using EShoppingPrototype.Data;

namespace EShoppingPrototype.Services
{
    public class GioHangService
    {
        private GioHangRepository repository =
            new GioHangRepository();

        public DataTable LayGioHang(int maKH)
        {
            return repository.GetByKhachHang(maKH);
        }

        public DataTable LayDanhSachSanPham()
        {
            return repository.GetSanPham();
        }

        public decimal TinhTongTien(int maKH)
        {
            return repository.GetTongTien(maKH);
        }

        public void ThemSanPham(
            int maKH,
            int maSP,
            int soLuong)
        {
            if (soLuong <= 0)
            {
                throw new Exception(
                    "Số lượng phải lớn hơn 0."
                );
            }

            repository.AddItem(
                maKH,
                maSP,
                soLuong
            );
        }

        public void CapNhatSoLuong(
            int maKH,
            int maSP,
            int soLuong)
        {
            if (soLuong <= 0)
            {
                throw new Exception(
                    "Số lượng phải lớn hơn 0."
                );
            }

            repository.UpdateSoLuong(
                maKH,
                maSP,
                soLuong
            );
        }

        public void XoaSanPham(
            int maKH,
            int maSP)
        {
            repository.DeleteItem(
                maKH,
                maSP
            );
        }
    }
}

//1250080004-Bùi Thế Anh