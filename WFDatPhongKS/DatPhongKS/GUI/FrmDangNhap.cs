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
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", (DevExpress.Utils.DefaultBoolean)MessageBoxIcon.Warning);
            if (txtMK.Text == "")
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", (DevExpress.Utils.DefaultBoolean)MessageBoxIcon.Warning);
            /*if (dt.checkDangNhap(txtTK.Text, txtMK.Text) == false)
            {
                MessageBox.Show("Bạn đã nhập sai, vui lòng nhập lại", "Thông báo");
                return;
            }*/
            string tk = "AD01";
            int mk = 123456;
            if (txtTK.Text != tk.ToString() || txtMK.Text != mk.ToString())
            {
                XtraMessageBox.Show("Bạn đã nhập sai, vui lòng nhập lại", "Thông báo", (DevExpress.Utils.DefaultBoolean)MessageBoxIcon.Error);
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