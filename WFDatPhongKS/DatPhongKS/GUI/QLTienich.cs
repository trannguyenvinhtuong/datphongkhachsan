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
    public partial class QLTienich : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLTIENICH_BLLDAL ti = new QLTIENICH_BLLDAL();
        public QLTienich()
        {
            InitializeComponent();

        }
        
        private void QLTienich_Load(object sender, EventArgs e)
        {
            dgvTI.DataSource = ti.lsttienich();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Themtienich them = new Themtienich();
            this.Hide();
            them.Show();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic tt = dgvTI.CurrentRow.DataBoundItem;
            int ma = tt.IDTIENICH;
            string sma = ma.ToString();
            Suatienich sua = new Suatienich(sma);
            this.Hide();
            sua.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic d = dgvTI.CurrentRow.DataBoundItem;
            int ma = d.IDTIENICH;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                bool results = ti.xoati(ma);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                dgvTI.DataSource = ti.lsttienich();
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgvTI.DataSource = ti.lsttienich();
        }
    }
}