using System.Diagnostics;

namespace EShoppingPrototype.Adapters
{
    public class EmailAdapter
    {
        // LAB: không gửi email thật
        public void GuiXacNhan(
            string email,
            int maDH)
        {
            if (string.IsNullOrWhiteSpace(email))
                return;

            Debug.WriteLine(
                "Gửi email xác nhận đơn " +
                maDH +
                " tới " +
                email);
        }
    }
}