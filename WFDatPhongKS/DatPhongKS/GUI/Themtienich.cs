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
    public partial class Themtienich : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLTIENICH_BLLDAL qlti = new QLTIENICH_BLLDAL();
        public Themtienich()
        {
            InitializeComponent();

        }

        private void Themtienich_Load(object sender, EventArgs e)
        {

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ten = txtten.Text.Trim();
            string icon = txticon.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Không được để trống tên tiện ích", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (icon == "")
            {
                MessageBox.Show("Không được để trống mã icon", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool results = qlti.themti(ten, icon);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QLTienich dv = new QLTienich();
                    dv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLTienich dv = new QLTienich();
            dv.Show();
            this.Hide();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            txticon.Clear();
            txtten.Clear();
        }
    }
}