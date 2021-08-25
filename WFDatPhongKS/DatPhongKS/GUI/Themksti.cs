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
    public partial class Themksti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKSTIENICH_BLLDAL ksti = new QLKSTIENICH_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        public Themksti()
        {
            InitializeComponent();
        }
      

        private void Themksti_Load(object sender, EventArgs e)
        {
            loadks();
            loadtienich();
        }

        private void loadks()
        {
            var dl = from s in data.KHACHSANs select new { maks = s.MAKHACHSAN, tenks = s.TENKHACHSAN };
            cbmaks.DataSource = dl;
            cbmaks.ValueMember = "maks";
            cbmaks.DisplayMember = "tenks";

        }

        private void loadtienich()
        {
            var dl = from s in data.TIENICHes select new { mati = s.IDTIENICH, tenti = s.TENTIENICH };
            cbtienich.DataSource = dl;
            cbtienich.ValueMember = "mati";
            cbtienich.DisplayMember = "tenti";
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadks();
            loadtienich();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string maks = cbmaks.SelectedValue.ToString();
            string mati = cbtienich.SelectedValue.ToString();
            string ghichu = txtghichu.Text.Trim();
            int imati = int.Parse(mati);
            bool result = ksti.themtienich(maks, imati, ghichu);
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLKSTI ti = new QLKSTI();
            ti.Show();
            this.Hide();
        }
    }
}