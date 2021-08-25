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
    public partial class QLDichvu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDV_BLLDAL dv = new QLDV_BLLDAL();
        public QLDichvu()
        {
            InitializeComponent();            
        }
        

        private void QLDichvu_Load(object sender, EventArgs e)
        {
            dgvDV.DataSource = dv.lstdv();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemDV them = new ThemDV();
            this.Hide();
            them.Show();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic d = dgvDV.CurrentRow.DataBoundItem;
            string ma = d.MADV;
            SuaDV sua = new SuaDV(ma);
            this.Hide();
            sua.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic d = dgvDV.CurrentRow.DataBoundItem;
            string ma = d.MADV;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                bool results = dv.deletedv(ma);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            dgvDV.DataSource = dv.lstdv();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgvDV.DataSource = dv.lstdv();
        }
    }
}