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
    public partial class QLKSTI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKSTIENICH_BLLDAL ksti = new QLKSTIENICH_BLLDAL();
        public QLKSTI()
        {
            InitializeComponent();           
        }     
       

        private void QLKSTI_Load(object sender, EventArgs e)
        {
            dgvKSTI.DataSource = ksti.lstksti();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgvKSTI.DataSource = ksti.lstksti();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Themksti them = new Themksti();
            this.Hide();
            them.Show();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic k = dgvKSTI.CurrentRow.DataBoundItem;
            string ma = k.MAKHACHSAN;
            int id = k.IDTIENICH;
            string sid = id.ToString();
            SuaKSTI sua = new SuaKSTI(ma, sid);
            this.Hide();
            sua.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic k = dgvKSTI.CurrentRow.DataBoundItem;
            string ma = k.MAKHACHSAN;
            int id = k.IDTIENICH;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                bool results = ksti.xoatienich(ma, id);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không thể xóa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dgvKSTI.DataSource = ksti.lstksti();
            }
        }
    }
}