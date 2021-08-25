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
    public partial class QLPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLPHONG_BLLDAL phong = new QLPHONG_BLLDAL();
        public QLPhong()
        {
            InitializeComponent();           
        }
        

        private void QLPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = phong.lstphong();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgvPhong.DataSource = phong.lstphong();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic phong = dgvPhong.CurrentRow.DataBoundItem;
            string maphong = phong.MAPHONG;
            string maks = phong.MAKHACHSAN;
            string maloai = phong.MALOAI;
            string loaig = phong.LOAIGIUONG;
            Suaphong sua = new Suaphong(maphong, maks, maloai, loaig);
            this.Hide();
            sua.Show();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Themphong p = new Themphong();
            this.Hide();
            p.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {

                dynamic p = dgvPhong.CurrentRow.DataBoundItem;
                string map = p.MAPHONG;
                bool results = phong.deletephong(map);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không thể xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             dgvPhong.DataSource = phong.lstphong();
            
        }
    }
}