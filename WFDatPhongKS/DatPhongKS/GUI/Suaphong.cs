using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using BLL_DAL;

namespace GUI
{
    public partial class Suaphong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLPHONG_BLLDAL phong = new QLPHONG_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        private string maphong;
        private string ks, lp, lg;
        public Suaphong()
        {
            InitializeComponent();            
        }

        public Suaphong(string map, string maks, string loaip, string loaig)
        {
            maphong = map;
            ks = maks;
            lp = loaip;
            lg = loaig;
            InitializeComponent();
        }

        private void Suaphong_Load(object sender, EventArgs e)
        {
            loadcbkhachsan();
            loadcbloaip();
            loadtxt();
            loadmaphong();
            loadcbloaig();
        }

        private void loadcbkhachsan()
        {
            var dl = from s in data.KHACHSANs                     
                     select new { maks = s.MAKHACHSAN, tenks = s.TENKHACHSAN };
            cbmaks.DataSource = dl;
            cbmaks.ValueMember = "maks";
            cbmaks.DisplayMember = "tenks";
            cbmaks.SelectedValue = ks;
        }

        private void loadcbloaip()
        {
            var dl = from s in data.LOAIPHONGs select new { maloai = s.MALOAI, tenloai = s.TENLOAIPHONG };
            cblphong.DataSource = dl;
            cblphong.ValueMember = "maloai";
            cblphong.DisplayMember = "tenloai";
            cblphong.SelectedValue = lp;
        }

        private void loadtxt()
        {
            PHONG p = data.PHONGs.Where(n => n.MAPHONG == maphong).FirstOrDefault();
            txttenphong.Text = p.TENPHONG;
            txtdientich.Text = p.DIENTICH.ToString();
            txtquangcanh.Text = p.QUANGCANH;
            txtgia.Text = p.GIA.ToString();
            txtgiam.Text = p.GIAM.ToString();
            txtsogiuong.Text = p.SOGIUONG.ToString();
            txtsokhach.Text = p.SOKHACH.ToString();
            txtsoluong.Text = p.SOLUONG.ToString();            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLPhong p = new QLPhong();
            this.Hide();
            p.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadcbkhachsan();
            loadcbloaip();
            loadtxt();
            loadmaphong();
            loadcbloaig();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string tenp = txttenphong.Text.Trim();
            string dientich = txtdientich.Text.Trim();
            string quangcanh = txtquangcanh.Text.Trim();
            string gia = txtgia.Text.Trim();
            string giam = txtgiam.Text.Trim();
            string sogiuong = txtsogiuong.Text.Trim();
            string loaigiuong = cbloaigiuong.Text;
            string soluong = txtsoluong.Text.Trim();
            string sokhach = txtsokhach.Text.Trim();
            string maks = cbmaks.SelectedValue.ToString();
            string maloai = cblphong.SelectedValue.ToString();
            string maphong = cbmaphong.Text;
            if (tenp == "")
            {
                MessageBox.Show("Không được để trống tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dientich == "")
            {
                MessageBox.Show("Không được để trống diện tích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (quangcanh == "")
            {
                MessageBox.Show("Không được để trống quang cảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gia == "")
            {
                MessageBox.Show("Không được để trống giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (giam == "")
            {
                MessageBox.Show("Không được để trống giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sogiuong == "")
            {
                MessageBox.Show("Không được để trống số giường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (soluong == "")
            {
                MessageBox.Show("Không được để trống số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sokhach == "")
            {
                MessageBox.Show("Không được để trống số khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn lưu?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    int idientich = int.Parse(dientich);
                    int igia = int.Parse(gia);
                    float fgiam = float.Parse(giam);
                    int isogiuong = int.Parse(sogiuong);
                    int isoluong = int.Parse(soluong);
                    int isokhach = int.Parse(sokhach);
                    bool resuls = phong.suaphong(maks, maloai, maphong, tenp, idientich, quangcanh, igia, fgiam, "", "", "", "", "", isogiuong, loaigiuong, isoluong, isokhach);
                    if (resuls == true)
                    {
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        QLPhong phong = new QLPhong();
                        this.Hide();
                        phong.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void loadmaphong()
        {
            cbmaphong.Text = maphong;
            cbmaphong.Enabled = false;
        }

        private void loadcbloaig()
        {
            cbloaigiuong.Items.Add("Đôi");
            cbloaigiuong.Items.Add("Đơn");
            cbloaigiuong.SelectedItem = lg;
        }

    }
}