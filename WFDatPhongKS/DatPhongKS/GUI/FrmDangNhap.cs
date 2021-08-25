using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=B902702E395D455\WIN2K; ;Initial Catalog = QLDPKS; User = sa; Password=sa2012");
        QL_NguoiDung nguoiDung = new QL_NguoiDung();
        ConnectSQL conn = new ConnectSQL();
        public FrmDangNhap()
        {
            InitializeComponent();
            txtTK.Focus();
        }

        public static string ID_USER = "";

        private string getID()
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MANV = '" + txtTK.Text + "' and MATKHAU='" + txtMK.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MANV"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }


        public void ProcessLogin()
        {
            ID_USER = getID();
            DangNhap result;          
            result = nguoiDung.Check_User(txtTK.Text, txtMK.Text);
            //DangNhap_Quyen check;
            //string = nguoiDung.Check_Quyen_User(txtTK.Text);
            //sai tên đăng nhập hoặc mật khẩuQ
            QL_NguoiDung user = new QL_NguoiDung();

            DataTable dt = new DataTable();
            conn.GetData(" select * from NHANVIEN where MANV='" + txtTK.Text + "' and MATKHAU = '" + txtMK.Text + "'");

            //if (dt.Rows.Count > 0)
            //{
            //    Program.frmMain = new FrmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][10].ToString());
            //    Program.frmMain.Show();
            //    Program.frmDangNhap.Hide();

            //}


            if (result == DangNhap.Invalid)
            {
                XtraMessageBox.Show("Bạn đã nhập sai, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Focus();
                return;
            }
            //tài khoản bị khóa
            else if (result == DangNhap.Disable)
            {
                XtraMessageBox.Show("Tài khoản của bạn đã bị khoá, vui lòng liên hệ admin để mở khoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Focus();
                return;
            }
            else
            {
                if (ID_USER != "")
                {
                    MessageBox.Show("Xin Chào ID: " + ID_USER);
                }
                //Program.frmMain = new FrmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][10].ToString());
                if (nguoiDung.login(txtTK.Text, txtMK.Text) == true)
                {
                    //FrmMain b = new FrmMain(nguoiDung.Check_Quyen_User(txtTK.Text));
                    //this.Hide();
                    //b.ShowDialog();
                    //this.Show();
                    Program.frmMain = new FrmMain(nguoiDung.Check_Quyen_User(txtTK.Text));
                    Program.frmMain.Show();
                    Program.frmDangNhap.Hide();
                }

                //if (check == DangNhap_Quyen.staff)
                //{
                //    Program.frmDatPhong = new FrmDatPhong();
                //    Program.frmTraPhong = new FrmTraPhong();
                //    Program.frmTraPhong.Hide();
                //    Program.frmDatPhong.Hide();
                //}

                //Program.frmMain = new FrmMain();
                //Program.frmMain.Show();
                //Program.frmDangNhap.Hide();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //DangNhap result;
            //Chưa nhập thông tin
            //result = nguoiDung.Check_User(txtTK.Text, txtMK.Text);
            //if (txtTK.Text == "")
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtTK.Focus();
            //    return;
            //}

            //if (txtMK.Text == "")
            //{
            //    XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtTK.Focus();
            //    return;
            //}

            

            //Chưa nhập thông tin
            if (string.IsNullOrEmpty(txtTK.Text.Trim()))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMK.Text.Trim()))
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }
            //if (nguoiDung.login(txtTK.Text,txtMK.Text) == true)
            //{
            //    FrmMain b = new FrmMain(nguoiDung.Check_Quyen_User(txtTK.Text));               
            //    this.Hide();
            //    b.ShowDialog();
            //    this.Show();
            //}
            
            if (nguoiDung.Check_Config() == 0)
            {
                ProcessLogin();
            }
            if (nguoiDung.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (nguoiDung.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }

        public void ProcessConfig()
        {
            FrmCauHinh ch = new FrmCauHinh();
            ch.Show();

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}