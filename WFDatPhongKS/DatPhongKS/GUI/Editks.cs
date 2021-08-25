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
    public partial class Editks : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKHACHSAN_BLLDAL qlks = new QLKHACHSAN_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        private string makhachsan;
        private string diad, nhacc;
        public Editks()
        {
            InitializeComponent();
        }

        public Editks(string maks, string diadiem, string ncc)
        {
            makhachsan = maks;
            diad = diadiem;
            nhacc = ncc;
            InitializeComponent();
        }

        private void Editks_Load(object sender, EventArgs e)
        {
            loadcbmaks();
            loadcbncc();
            loadcbdiadiem();
            loadtxt();
        }

        private void loadcbmaks()
        {
            cbmaks.Text = makhachsan;
            cbmaks.Enabled = false;
        }

        private void loadcbncc()
        {
            var cc = from a in data.KHACHSANs
                     join b in data.NCCs
                     on a.MANCC equals b.MANCC
                     where a.MAKHACHSAN == makhachsan
                     select b.TENNCC.FirstOrDefault();
            var dl = from s in data.NCCs                     
                     select new { tenncc = s.TENNCC, mancc = s.MANCC };
            cbmancc.DataSource = dl;
            cbmancc.ValueMember = "mancc";
            cbmancc.DisplayMember = "tencc";
            cbmancc.SelectedValue = nhacc;
        }

        private void loadcbdiadiem()
        {
            
            var dlcb = from b in data.HOME_DDNBs
                       select new { madd = b.IDDIADIEM, tendd = b.TENDIADIEM };
            cbdiadiem.DisplayMember = "tendd";
            cbdiadiem.ValueMember = "madd";
            cbdiadiem.DataSource = dlcb;
            cbdiadiem.SelectedValue = diad;
       
            
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string maks = cbmaks.Text;
            string mancc = cbmancc.SelectedValue.ToString();
            string tenks = txttenks.Text.Trim();
            int slphong = int.Parse(txtslp.Text.Trim());
            int sosao = int.Parse(txtsosao.Text.Trim());
            string mota = txtmota.Text.Trim();
            string tinh = txttinh.Text.Trim();
            string quan = txtquan.Text.Trim();
            string phuong = txtphuong.Text.Trim();
            string duong = txtduong.Text.Trim();
            string diachi = txtdiachict.Text.Trim();
            string diadiem = cbdiadiem.SelectedValue.ToString();

            if (tenks == "")
            {
                MessageBox.Show("Không được để trống tên khách sạn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (slphong == 0)
            {
                MessageBox.Show("Không được để trống số lượng phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtsosao.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống số sao", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mota == "")
            {
                MessageBox.Show("Không được để trống mô tả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tinh == "")
            {
                MessageBox.Show("Không được để trống tỉnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (quan == "")
            {
                MessageBox.Show("Không được để trống quận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (phuong == "")
            {
                MessageBox.Show("Không được để trống phường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (duong == "")
            {
                MessageBox.Show("Không được để trống tên đường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (diachi == "")
            {
                MessageBox.Show("Không được để trống địa chỉ cụ thể", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn lưu?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {


                    bool result = qlks.suaks(maks, mancc, tenks, slphong, sosao, tinh, quan, phuong, duong, diachi, "", "", "", "", "", mota, "", "", 0, diadiem);
                    if (result == true)
                    {
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        QLKhachSan ks = new QLKhachSan();
                        this.Hide();
                        ks.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
        }

        private void loadtxt()
        {
            KHACHSAN ks = data.KHACHSANs.Where(n=>n.MAKHACHSAN==makhachsan).FirstOrDefault();
            txttenks.Text = ks.TENKHACHSAN;
            txtslp.Text = ks.SOLUONGPHONG.ToString();
            txtsosao.Text = ks.SOSAO.ToString();
            txtmota.Text = ks.MOTA;
            txttinh.Text = ks.TINH;
            txtquan.Text = ks.QUAN;
            txtphuong.Text = ks.PHUONG;
            txtduong.Text = ks.DUONG;
            txtdiachict.Text = ks.DIACHICUTHE;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            txttenks.Clear();
            txtslp.Clear();
            txtsosao.Clear();
            txtmota.Clear();
            txttinh.Clear();
            txtquan.Clear();
            txtphuong.Clear();
            txtduong.Clear();
            txtdiachict.Clear();
            loadcbmaks();
            loadcbncc();
            loadcbdiadiem();
            loadtxt();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLKhachSan ks = new QLKhachSan();
            this.Hide();
            ks.Show();
        }
    }
}