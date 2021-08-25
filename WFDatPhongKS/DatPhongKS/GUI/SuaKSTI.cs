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
    public partial class SuaKSTI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKSTIENICH_BLLDAL ksti = new QLKSTIENICH_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        private string maks, idtienich;
        public SuaKSTI()
        {
            InitializeComponent();            
        }
        
        public SuaKSTI(string ma, string id)
        {
            maks = ma;
            idtienich = id;
            InitializeComponent();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string maks = cbmaks.SelectedValue.ToString();
            string idti = cbtienich.SelectedValue.ToString();
            string ghichu = txtghichu.Text.Trim();
            int iid = int.Parse(idti);

            DialogResult r;
            r = MessageBox.Show("Bạn có muốn lưu?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                bool result = ksti.suatienich(maks, iid, ghichu);
                if (result == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QLKSTI ti = new QLKSTI();
                    ti.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đã có tiện ích !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void SuaKSTI_Load(object sender, EventArgs e)
        {
            loadcbmaks();
            loadidtienich();
        }

        private void loadcbmaks()
        {
            var dl = from s in data.KHACHSANs select new { maks = s.MAKHACHSAN, tenks = s.TENKHACHSAN };
            cbmaks.DataSource = dl;
            cbmaks.ValueMember = "maks";
            cbmaks.DisplayMember = "tenks";
            cbmaks.SelectedValue = maks;
            cbmaks.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLKSTI k = new QLKSTI();
            this.Hide();
            k.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadcbmaks();
            loadidtienich();
            txtghichu.Clear();
        }

        private void loadidtienich()
        {
            var dl = from s in data.TIENICHes select new { mati = s.IDTIENICH, tenti = s.TENTIENICH };
            cbtienich.DataSource = dl;
            cbtienich.ValueMember = "mati";
            cbtienich.DisplayMember = "tenti";
            cbtienich.SelectedValue = int.Parse(idtienich);
            cbtienich.Enabled = false;
        }
    }
}