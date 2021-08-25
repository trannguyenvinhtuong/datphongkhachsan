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
        string tendangnhap = "", tennv = "", matkhau = "", quyen = "";
        QL_NguoiDung nguoiDung = new QL_NguoiDung();
        string UID = FrmDangNhap.ID_USER;
        //SqlConnection conn = new SqlConnection(@"Data Source=B902702E395D455\WIN2K; ;Initial Catalog = QLDPKS; User = sa; Password=sa2012");
        public FrmMain()
        {
            InitializeComponent();
        }
        static string chucVu;


        public static string ChucVu1 { get => chucVu; set => chucVu = value; }

        public FrmMain(string chucvu)
        {
            InitializeComponent();
            ChucVu1 = chucvu;

            if (ChucVu1 == "False")
            {
                menu_employee.Visible = false;
                menu_Employees.Visible = false;
            }

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
            lbltendangnhap.Text = UID.ToString();
        }

        private void btnThoatNick_MouseClick(object sender, MouseEventArgs e)
        {
            Program.frmMain.Hide();
            Program.frmDangNhap.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmDatPhong dp = new FrmDatPhong();
            //nhung(dp);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraPhong tp = new FrmTraPhong();
            nhung(tp);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (quyen == "True")
            //{
            FrmNhanVien nv = new FrmNhanVien();
            nhung(nv);
            //}
            //else
            //{
            //    XtraMessageBox.Show("Admin mới có thể sử dụng chức năng này !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}                          
        }

        private void menu_employee_Click(object sender, EventArgs e)
        {



        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhachSan ks = new QLKhachSan();
            nhung(ks);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLPhong p = new QLPhong();
            nhung(p);
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDichvu d = new QLDichvu();
            nhung(d);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kSTiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKSTI k = new QLKSTI();
            nhung(k);
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNCC nc = new QLNCC();
            nhung(nc);
        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTienich ti = new QLTienich();
            nhung(ti);
        }

        private void menu_invoice_Click(object sender, EventArgs e)
        {
            QLHoadon hd = new QLHoadon();
            nhung(hd);
        }

        private void menu_Rooms_Click(object sender, EventArgs e)
        {
            QLPhong p = new QLPhong();
            nhung(p);
        }

        private void menu_Hotels_Click(object sender, EventArgs e)
        {
            QLKhachSan ks = new QLKhachSan();
            nhung(ks);
        }

        private void menu_Employees_Click(object sender, EventArgs e)
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
