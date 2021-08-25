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
    public partial class Suancc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string mancc;
        QLDPKSDataContext data = new QLDPKSDataContext();
        QLNCC_BLLDAL qlncc = new QLNCC_BLLDAL();
        public Suancc()
        {
            InitializeComponent();

        }       

        public Suancc(string ma)
        {
            mancc = ma;
            InitializeComponent();
        }

        private void Suancc_Load(object sender, EventArgs e)
        {
            loadncc();
            loadtxt();
        }

        private void loadncc()
        {
            cbmancc.Text = mancc;
            cbmancc.Enabled = false;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadncc();
            txttenncc.Clear();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ma = cbmancc.Text;
            string ten = txttenncc.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn lưu?", "Lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    bool results = qlncc.suacc(ma, ten);
                    if (results == true)
                    {
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        QLNCC q = new QLNCC();
                        this.Hide();
                        q.Show();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNCC q = new QLNCC();
            this.Hide();
            q.Show();
        }

        private void loadtxt()
        {
            NCC nc = data.NCCs.Where(n => n.MANCC == mancc).SingleOrDefault();
            txttenncc.Text = nc.TENNCC;
        }
    }
}