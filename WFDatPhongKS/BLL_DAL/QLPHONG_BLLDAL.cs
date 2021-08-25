using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QLPHONG_BLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();

        public List<PHONG> lstphong()
        {
            return data.PHONGs.ToList();
        }

        public bool themphong(string maks, string maloai, string maphong, string tenphong, int dientich, string quangcanh, int gia, float giam, string anh1, string anh2, string anh3, string anh4, string anh5, int sogiuong, string loaigiuong, int soluong, int sokhach)
        {
            try
            {
                PHONG p = new PHONG();
                p.MAKHACHSAN = maks;
                p.MALOAI = maloai;
                p.MAPHONG = maphong;
                p.TENPHONG = tenphong;
                p.DIENTICH = (int)dientich;
                p.QUANGCANH = quangcanh;
                p.GIA = (int)gia;
                p.GIAM = (float)giam;
                p.ANH1 = anh1;
                p.ANH2 = anh2;
                p.ANH3 = anh3;
                p.ANH4 = anh4;
                p.ANH5 = anh5;
                p.SOGIUONG = (int)sogiuong;
                p.LOAIGIUONG = loaigiuong;
                p.SOLUONG = (int)soluong;
                p.SOKHACH = (int)sokhach;
                data.PHONGs.InsertOnSubmit(p);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaphong(string maks, string maloai, string maphong, string tenphong, int dientich, string quangcanh, int gia, float giam, string anh1, string anh2, string anh3, string anh4, string anh5, int sogiuong, string loaigiuong, int soluong, int sokhach)
        {
            try
            {
                PHONG p = data.PHONGs.Where(n => n.MAPHONG == maphong).FirstOrDefault();
                p.MAKHACHSAN = maks;
                p.MALOAI = maloai;
                p.TENPHONG = tenphong;
                p.DIENTICH = (int)dientich;
                p.QUANGCANH = quangcanh;
                p.GIA = (int)gia;
                p.GIAM = (float)giam;
                p.ANH1 = anh1;
                p.ANH2 = anh2;
                p.ANH3 = anh3;
                p.ANH4 = anh4;
                p.ANH5 = anh5;
                p.SOGIUONG = (int)sogiuong;
                p.LOAIGIUONG = loaigiuong;
                p.SOLUONG = (int)soluong;
                p.SOKHACH = (int)sokhach;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }           
        }

        public bool deletephong(string maphong)
        {

            try
            {
                PHONG p = data.PHONGs.Where(n => n.MAPHONG == maphong).SingleOrDefault();
                data.PHONGs.DeleteOnSubmit(p);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
