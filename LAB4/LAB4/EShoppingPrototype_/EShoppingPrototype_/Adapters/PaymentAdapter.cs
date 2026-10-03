namespace EShoppingPrototype.Adapters
{
    public class PaymentAdapter
    {
        // LAB: mô phỏng dịch vụ thanh toán bên ngoài
        public bool KiemTraThanhToan(decimal soTien)
        {
            return soTien > 0;
        }
    }
}