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
    public partial class QLKhachSan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKHACHSAN_BLLDAL qlks = new QLKHACHSAN_BLLDAL();
        public QLKhachSan()
        {
            InitializeComponent();

           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            Themks k = new Themks();
            this.Hide();
            k.Show();
        }

        private void QLKhachSan_Load(object sender, EventArgs e)
        {
            dgvKS.DataSource = qlks.lstks();   
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Themks them = new Themks();
            this.Hide();
            them.Show();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgvKS.DataSource = qlks.lstks();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic ks = dgvKS.CurrentRow.DataBoundItem;
            string maks = ks.MAKHACHSAN;
            string diadiem = ks.IDDIADIEM;
            string nhacc = ks.MANCC;
            Editks sua = new Editks(maks, diadiem, nhacc);
            this.Hide();
            sua.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic ks = dgvKS.CurrentRow.DataBoundItem;
            string maks = ks.MAKHACHSAN;
            bool result = qlks.deletekhachsan(maks);
            if(result == true)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Không thể xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvKS.DataSource = qlks.lstks();
        }
    }
}