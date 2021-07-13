using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Xml;

namespace GUI
{
    class QL_NguoiDung
    {
        SqlConnection con = new SqlConnection(@"Data Source=B902702E395D455\WIN2K; ;Initial Catalog = QLDPKS; User = sa; Password=sa2012");
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
                return DangNhap.Disable;// User không hoạt động
            }
            return DangNhap.Success; // Đăng nhập thành công
        }
        //public string layChucVu(string taiKhoan, string matKhau)
        //{
        //    string id = "";

        //    SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MANV = '" + taiKhoan + "' and MatKhau = '" + matKhau + "'", cnn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt != null)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {

        //            id = dr["CHUCVU"].ToString();
        //        }
        //    }


        //    return id;
        //}
        public bool login(string taiKhoan, string matKhau)
        {

            string sqlAcount = "select MaNV, MatKhau from NhanVien where MANV = '" + taiKhoan + "' and MatKhau = '" + matKhau + "'";
            SqlCommand cmd = new SqlCommand(sqlAcount, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Check_Quyen_User(string pUser)
        {
            string id = "";
            SqlDataAdapter daUser = new SqlDataAdapter(" select QUYEN from NHANVIEN where MANV='" + pUser + "'", Properties.Settings.Default.Connect);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            //if (dt.Rows.Count == 0)
            //    return DangNhap_Quyen.Invalid;
            //else if (dt.Rows[0][1].ToString() == "False")
            //{
            //    return DangNhap_Quyen.staff;// User là staff
            //}
            //return DangNhap_Quyen.admin; // User là admin
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    id = dr["Quyen"].ToString();
                }
            }


            return id;
        }

        //cấu hình
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;

        }
        public DataTable GetAuthentication()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;

        }
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            string conn = @"Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";Persist Security Info=True;User ID=" + pUser + ";Password=" + pPass;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conn))
                {
                    sqlConn.Open();
                    DataTable tblDatabases = sqlConn.GetSchema("Databases");
                    sqlConn.Close();

                    foreach (DataRow row in tblDatabases.Rows)
                    {
                        list.Add(row["database_name"].ToString());
                    }
                }
                return list;
            }
            catch
            {
                XtraMessageBox.Show("Thông tin cấu hình chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public List<string> GetDatabaseNameWindows(string pServerName)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            string conn = @"Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";Integrated Security=True";
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(conn))
                {
                    sqlConn.Open();
                    DataTable tblDatabases = sqlConn.GetSchema("Databases");
                    sqlConn.Close();

                    foreach (DataRow row in tblDatabases.Rows)
                    {
                        list.Add(row["database_name"].ToString());
                    }
                }
                return list;
            }
            catch
            {
                MessageBox.Show("Thông tin cấu hình chưa chính xác");
                return null;
            }

        }

        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            GUI.Properties.Settings.Default.Connect = "Data Source=" + pServerName
            + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();
        }


        public bool ChangeConnectionStringApp(string Name, string value, string providerName, string AppName)
        {
            bool retVal = false;
            try
            {

                string FILE_NAME = string.Concat(Application.StartupPath, "\\", AppName.Trim(), ".exe.Config"); //the application configuration file name
                XmlTextReader reader = new XmlTextReader(FILE_NAME);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                reader.Close();
                string nodeRoute = string.Concat("connectionStrings/add");

                XmlNode cnnStr = null;
                XmlElement root = doc.DocumentElement;
                XmlNodeList Settings = root.SelectNodes(nodeRoute);

                for (int i = 0; i < Settings.Count; i++)
                {
                    cnnStr = Settings[i];
                    if (cnnStr.Attributes["name"].Value.Equals(Name))
                        break;
                    cnnStr = null;
                }

                cnnStr.Attributes["connectionString"].Value = value;
                cnnStr.Attributes["providerName"].Value = providerName;
                doc.Save(FILE_NAME);
                retVal = true;
            }
            catch
            {
                retVal = false;

            }
            return retVal;
        }

    }
}
