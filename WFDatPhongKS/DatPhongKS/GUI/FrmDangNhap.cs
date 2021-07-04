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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap result;
            //Chưa nhập thông tin
            result = nguoiDung.Check_User(txtTK.Text, txtMK.Text);
            if (txtTK.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }    
                
            if (txtMK.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }    
                
            //sai tên đăng nhập hoặc mật khẩu
            if (result == DangNhap.Invalid)
            {
                XtraMessageBox.Show("Bạn đã nhập sai, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Focus();
                return;
            }
                //tài khoản bị khóa
            else if (result == DangNhap.Disabled)
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
            }
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
    }
}