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
    public partial class SuaDV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLDV_BLLDAL dv = new QLDV_BLLDAL();
        QLDPKSDataContext data = new QLDPKSDataContext();
        private string madv;
        public SuaDV()
        {
            InitializeComponent();           
        }

        public SuaDV(string ma)
        {
            madv = ma;
            InitializeComponent();
        }
        
        private void SuaDV_Load(object sender, EventArgs e)
        {
            loadcbma();
            loadtxt();
        }

        private void loadcbma()
        {
            cbmadv.Text = madv;
            cbmadv.Enabled = false;
        }

        private void loadtxt()
        {
            DICHVU d = data.DICHVUs.Where(n => n.MADV == madv).FirstOrDefault();
            txttendv.Text = d.TENDV;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadcbma();
            loadtxt();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLDichvu d = new QLDichvu();
            this.Hide();
            d.Show();
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
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn lưu?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    bool results = dv.suadv(madv, tendv);
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
}