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
    public partial class ThemDV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDV_BLLDAL dv = new QLDV_BLLDAL();
        public ThemDV()
        {
            InitializeComponent();
        }    
            

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLDichvu dv = new QLDichvu();
            dv.Show();
            this.Hide();
        }

        private string genarateID()
        {
            Random r = new Random();
            string so = r.Next(0, 100).ToString();
            string ma = "dv" + so + so;
            return ma;
        }
        public void loadcbma()
        {
            cbmadv.Text = genarateID();
            cbmadv.Enabled = false;
        }

        private void ThemDV_Load(object sender, EventArgs e)
        {
            loadcbma();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadcbma();
            txttendv.Clear();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string madv = cbmadv.Text;
            string tendv = txttendv.Text.Trim();
            if (tendv == "")
            {
                MessageBox.Show("Không được để trống tên dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool results = dv.themdv(madv, tendv);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QLDichvu dv = new QLDichvu();
                    dv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}