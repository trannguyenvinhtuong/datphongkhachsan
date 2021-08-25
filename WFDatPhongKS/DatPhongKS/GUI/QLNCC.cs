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
    public partial class QLNCC : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLNCC_BLLDAL ncc = new QLNCC_BLLDAL();
        public QLNCC()
        {
            InitializeComponent();
        }

        private void QLNCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = ncc.lstncc();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Themncc them = new Themncc();
            this.Hide();
            them.Show();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic n = dgvNCC.CurrentRow.DataBoundItem;
            string ma = n.MANCC;
            Suancc sua = new Suancc(ma);
            this.Hide();
            sua.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic n = dgvNCC.CurrentRow.DataBoundItem;
            string ma = n.MANCC;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                bool results = ncc.xoancc(ma);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không thể xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dgvNCC.DataSource = ncc.lstncc();
            }
        }
    }
}