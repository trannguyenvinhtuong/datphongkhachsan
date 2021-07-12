using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {

        QL_NguoiDung nguoiDung = new QL_NguoiDung();
        public FrmMain()
        {
            InitializeComponent();
            
        }

        public string _message;

        public FrmMain(string Message) : this()
        {
            _message = Message;
            lbltendangnhap.Text = _message;

        }


        // Nhúng form con vào pannel chính
        public void nhung(Form frm)
        {
            panelContent.Controls.Clear();//Xóa các control trong form cũ
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);//thêm form mới vào panel
            panelContent.Show();
        }

        

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2007 Blue";
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
                e.Cancel = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            skin();
        }

        private void btnThoatNick_MouseClick(object sender, MouseEventArgs e)
        {
            Program.frmMain.Hide();
            Program.frmDangNhap.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatPhong dp = new FrmDatPhong();
            nhung(dp);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraPhong tp = new FrmTraPhong();
            nhung(tp);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nhung(nv);
        }

        private void btnDoiMK_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FrmDoiMK dmk = new FrmDoiMK();
            nhung(dmk);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBackground bg = new FrmBackground();
            nhung(bg);
        }
    }
}
