using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DATPHONG_BLLDAL
    {
        QLDPKSDataContext QLDP = new QLDPKSDataContext();
        public object show_DGVDatPhong()
        {
            return from p in QLDP.PHONGs
                   join lp in QLDP.LOAIPHONGs on p.MALOAI equals lp.MALOAI
                   join bk in QLDP.BOOKINGs on p.MAPHONG equals bk.MAPHONG
                   select new { TênPhòng = p.TENPHONG, NgàyVào = bk.NGAYVAO, NgàyĐi = bk.NGAYDI, TênLoạiPhòng = lp.TENLOAIPHONG, SốGiường = p.SOGIUONG, LoạiGiường = p.LOAIGIUONG, GiáTiền = p.GIA };
        }

		public List<PHONG> getDataDatPhong()
		{
			return QLDP.PHONGs.ToList<PHONG>();
		}
		public List<LOAIPHONG> getDataLoaiPhong()
		{
			return QLDP.LOAIPHONGs.ToList<LOAIPHONG>();
		}
		public List<BOOKING> getDataBooking()
		{
			return QLDP.BOOKINGs.ToList<BOOKING>();
		}

		


	}
}
