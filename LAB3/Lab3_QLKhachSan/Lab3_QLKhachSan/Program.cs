using System;
using System.Windows.Forms;

namespace Lab3_QLKhachSan
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của toàn bộ chương trình.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Gọi chạy Form chính
            Application.Run(new FrmMain());
        }
    }
}