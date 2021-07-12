using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static FrmDangNhap frmDangNhap = null;
        public static FrmMain frmMain = null;
        public static FrmDatPhong frmDatPhong = null;
        public static FrmTraPhong frmTraPhong = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap = new FrmDangNhap();
            Application.Run(frmDangNhap);
        }
    }
}
