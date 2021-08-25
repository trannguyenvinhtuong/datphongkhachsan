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
    public partial class Themks : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKHACHSAN_BLLDAL qlks = new QLKHACHSAN_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        public Themks()
        {
            InitializeComponent();


        }
        private string genarateID()
        {
            Random r = new Random();
            string so = r.Next(0, 100).ToString();
            string ma = "ks" + so + so;
            return ma;
        }

        private void Themks_Load(object sender, EventArgs e)
        {
            loadcbmaks();
            loadcbncc();
            loadcbdiadiem();
        }

        private void loadcbmaks()
        {
            cbmaks.Text = genarateID();
            cbmaks.Enabled = false;
        }

        private void loadcbncc()
        {
            var dl = from s in data.NCCs select new { tenncc = s.TENNCC, mancc = s.MANCC };
            cbmancc.DataSource = dl;
            cbmancc.ValueMember = "mancc";
            cbmancc.DisplayMember = "tencc";
        }

        private void loadcbdiadiem()
        {
            var dl = from s in data.HOME_DDNBs select new { madd = s.IDDIADIEM, tendd = s.TENDIADIEM };
            cbdiadiem.DisplayMember = "tendd";
            cbdiadiem.ValueMember = "madd";
            cbdiadiem.DataSource = dl;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bbiNew_ItemClick_1(object sender, ItemClickEventArgs e)
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
                bool result = qlks.themks(maks, mancc, tenks, slphong, sosao, tinh, quan, phuong, duong, diachi, "", "", "", "", "", mota, "", "", 0, diadiem);
                if (result == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadcbmaks();
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
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLKhachSan ks = new QLKhachSan();
            this.Hide();
            ks.Show();
        }
    }
}