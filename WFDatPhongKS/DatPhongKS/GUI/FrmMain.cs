using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();      
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

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
                e.Cancel = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
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
    }
}
