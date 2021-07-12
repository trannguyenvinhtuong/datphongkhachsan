using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        QL_NguoiDung nguoiDung = new QL_NguoiDung();

        public FrmDangNhap()
        {
            InitializeComponent();
            txtTK.Focus();
        }


        public void ProcessLogin()
        {
            DangNhap result;          
            result = nguoiDung.Check_User(txtTK.Text, txtMK.Text);
            //DangNhap_Quyen check;
            //check = nguoiDung.Check_Quyen_User(txtTK.Text);
            //sai tên đăng nhập hoặc mật khẩu
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
                Program.frmMain = new FrmMain();
                Program.frmMain.Show();
                Program.frmDangNhap.Hide();
                //if (check == DangNhap_Quyen.staff)
                //{
                //    Program.frmDatPhong = new FrmDatPhong();
                //    Program.frmTraPhong = new FrmTraPhong();
                //    Program.frmTraPhong.Hide();
                //    Program.frmDatPhong.Hide();
                //}
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