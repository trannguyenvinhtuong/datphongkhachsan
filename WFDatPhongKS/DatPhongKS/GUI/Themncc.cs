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
    public partial class Themncc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLNCC_BLLDAL qlncc = new QLNCC_BLLDAL();
        public Themncc()
        {
            InitializeComponent();
        }
        
        private void Themncc_Load(object sender, EventArgs e)
        {
            loadma();
        }

        private string genarateID()
        {
            Random r = new Random();
            string so = r.Next(0, 100).ToString();
            string ma = "dv" + so + so;
            return ma;
        }

        private void loadma()
        {
            cbmancc.Text = genarateID();
            cbmancc.Enabled = false;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            string mancc = cbmancc.Text;
            string tenncc = txttenncc.Text.Trim();
            if (tenncc == "")
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool results = qlncc.themncc(mancc, tenncc);
                if (results == true)
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QLNCC n = new QLNCC();
                    this.Hide();
                    n.Show();
                }
                else
                {
                    MessageBox.Show("Lỗi rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadma();
            txttenncc.Clear();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNCC n = new QLNCC();
            this.Hide();
            n.Show();
        }
    }
}