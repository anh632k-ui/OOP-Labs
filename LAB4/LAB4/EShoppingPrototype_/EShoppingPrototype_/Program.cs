using System;
using System.Windows.Forms;
using EShoppingPrototype.UI;

namespace EShoppingPrototype_
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmGioHang(1));
        }
    }
}