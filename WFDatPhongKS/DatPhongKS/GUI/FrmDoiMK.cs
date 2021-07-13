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
    public partial class FrmDoiMK : DevExpress.XtraEditors.XtraForm
    {

        QL_NguoiDung nguoiDung = new QL_NguoiDung();

        public FrmDoiMK()
        {
            InitializeComponent();
        }

        private string _message;
        public FrmDoiMK(string Message) : this()
        {
            _message = Message;
            txttaikhoan.Text = _message;
        }

        private void FrmDoiMK_Load(object sender, EventArgs e)
        {
            this.nhanvienTableAdapter1.Fill(this.dataSet_QLDP1.NHANVIEN);            
        }

        // Nhúng form con vào pannel chính
        public void nhung(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmBackground bg = new FrmBackground();
            nhung(bg);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmatkhaucu.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblmatkhaucu.Text.ToLower());
                this.txtmatkhaucu.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtmatkhaumoi.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblmatkhaumoi.Text.ToLower());
                this.txtmatkhaumoi.Focus();
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
                MessageBox.Show("CHuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }

        public void ProcessConfig()
        {
            FrmCauHinh ch = new FrmCauHinh();
            ch.Show();
        }
        public void ProcessLogin()
        {
            RePass_Result result;
            result = (RePass_Result)nguoiDung.Check_User(txttaikhoan.Text, txtmatkhaucu.Text);
            //sai tên đăng nhập hoặc mật khẩu
            if (result == RePass_Result.Invalid)
            {
                MessageBox.Show("Sai " + lblmatkhaucu.Text);
                txtmatkhaucu.Clear();
            }
            //tài khoản bị khóa
            else if (txtmatkhaumoi.Text != txtnhaplai.Text)
            {
                MessageBox.Show(lblnhaplai.Text.ToLower() + " và " + lblmatkhaumoi.Text.ToLower() + " không trùng khớp");
                this.txtnhaplai.Clear();
                this.txtnhaplai.Focus();
            }
            else if (result == RePass_Result.Success)
            {
                String mk = txtmatkhaumoi.Text;
                string tk = txttaikhoan.Text;
                nhanvienTableAdapter1.Update_MK(mk, tk);
                MessageBox.Show("Thành công");
                txtmatkhaucu.Clear();
                txtmatkhaumoi.Clear();
                txtnhaplai.Clear();
                return;
            }
        }
    }
}