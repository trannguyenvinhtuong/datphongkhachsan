using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace GUI
{
    class QL_NguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.Connect == string.Empty)
                return 1;
            SqlConnection Sqlconn = new SqlConnection(Properties.Settings.Default.Connect);
            try
            {
                if (Sqlconn.State == System.Data.ConnectionState.Closed)
                    Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public DangNhap Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter(" select MANV,MATKHAU,HOATDONG from NHANVIEN where MANV='" + pUser + "' and MATKHAU = '" + pPass + "'", Properties.Settings.Default.Connect);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return DangNhap.Invalid;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return DangNhap.Disabled;// User không hoạt động
            }
            return DangNhap.Success; // Đăng nhập thành công
        }

    }
}
