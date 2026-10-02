using System;
using System.Windows.Forms;

namespace FormDangKyDangNhap
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDangNhap());
        }
    }
}
