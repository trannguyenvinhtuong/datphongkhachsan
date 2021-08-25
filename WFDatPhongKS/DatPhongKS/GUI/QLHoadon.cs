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
    public partial class QLHoadon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        HOADON_DLLDAL hoadon = new HOADON_DLLDAL();
        public QLHoadon()
        {
            InitializeComponent();            
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLHoadon_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = hoadon.lsthd();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgvHD.DataSource = hoadon.lsthd();
        }
    }
}