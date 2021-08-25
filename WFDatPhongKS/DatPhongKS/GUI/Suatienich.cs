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
    public partial class Suatienich : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string ma;
        QLTIENICH_BLLDAL qlti = new QLTIENICH_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        public Suatienich()
        {
            InitializeComponent();
        }
        
        public Suatienich(string matt)
        {
            ma = matt;
            InitializeComponent();
        }

        private void Suatienich_Load(object sender, EventArgs e)
        {
            loadma();
            loadtxt();
        }

        private void loadma()
        {
            cbma.Text = ma;
            cbma.Enabled = false;
        }

        private void loadtxt()
        {
            int id = int.Parse(ma);
            TIENICH t = data.TIENICHes.Where(n => n.IDTIENICH == id).FirstOrDefault();
            txtten.Text = t.TENTIENICH;
            txticon.Text = t.ICON;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLTienich t = new QLTienich();
            this.Hide();
            t.Show();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadma();
            loadtxt();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ma = cbma.Text;
            string ten = txtten.Text.Trim();
            string icon = txticon.Text.Trim();
            int ima = int.Parse(ma);
            if (ten == "")
            {
                MessageBox.Show("Không được để trống tên tiện ích", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (icon == "")
            {
                MessageBox.Show("Không được để trống icon", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn lưu?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    bool results = qlti.suati(ima, ten, icon);
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
        }
    }
}