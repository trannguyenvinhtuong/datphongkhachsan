using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class FrmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        DATPHONG_BLLDAL DatPhong_BLL = new DATPHONG_BLLDAL();
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        //public void loadDatPhong()
        //{
        //    dgvDatPhong.DataSource = DatPhong_BLL.show_DGVDatPhong();
        //}

		public void loadDatPhong()
		{
			var phong = from p in DatPhong_BLL.getDataDatPhong()
						 from lp in DatPhong_BLL.getDataLoaiPhong()
						 from bk in DatPhong_BLL.getDataBooking()
						 where p.MALOAI == lp.MALOAI && bk.MAPHONG == p.MAPHONG
						 select new
						 {
							 TenPhong = p.TENPHONG,
							 NgayVao = bk.NGAYVAO,
							 NgayDi = bk.NGAYDI,
							 TenLoaiPhong = lp.TENLOAIPHONG,
							 SoGiuong = p.SOGIUONG,
							 LoaiGiuong = p.LOAIGIUONG,
							 Gia = p.GIA
				 		};
			dgvDatPhong.DataSource = phong.ToList();
		}

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
			loadDatPhong();

		}
    }
}