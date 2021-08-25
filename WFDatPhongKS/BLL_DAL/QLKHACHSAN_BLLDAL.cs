using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QLKHACHSAN_BLLDAL
    {
        QLDPKSDataContext data = new QLDPKSDataContext();
        public List<KHACHSAN> lstks()
        {
            return data.KHACHSANs.ToList();
        }

        public List<string> lsttenncc()
        {
            var dl = from s in data.NCCs
                     select s.TENNCC;
            return dl.ToList();
        }

        public List<KHACHSAN> lstmotks(string maks)
        {
            return data.KHACHSANs.Where(n => n.MAKHACHSAN == maks).ToList();
        }

        public bool themks(string maks, string mancc, string tenkhachsan, int soluongphong, int sosao, string tinh, string quan, string phuong, string duong, string diachicuthe, string anhks1, string anhks2, string anhks3, string anhks4, string anhks5, string mota, string diadanh, string danhgia, float diem, string iddiadiem)
        {
            try
            {
                KHACHSAN ks = new KHACHSAN();
                ks.MAKHACHSAN = maks;
                ks.MANCC = mancc;
                ks.TENKHACHSAN = tenkhachsan;
                ks.SOLUONGPHONG = (int)soluongphong;
                ks.SOSAO = (int)sosao;
                ks.TINH = tinh;
                ks.QUAN = quan;
                ks.PHUONG = phuong;
                ks.DUONG = duong;
                ks.DIACHICUTHE = diachicuthe;
                ks.ANHKS1 = anhks1;
                ks.ANHKS2 = anhks2;
                ks.ANHKS3 = anhks3;
                ks.ANHKS4 = anhks4;
                ks.ANHKS5 = anhks5;
                ks.MOTA = mota;
                ks.DIADANH = diadanh;
                ks.DANHGIA = danhgia;
                ks.DIEM = (float)diem;
                ks.IDDIADIEM = iddiadiem;
                data.KHACHSANs.InsertOnSubmit(ks);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaks(string maks, string mancc, string tenkhachsan, int soluongphong, int sosao, string tinh, string quan, string phuong, string duong, string diachicuthe, string anhks1, string anhks2, string anhks3, string anhks4, string anhks5, string mota, string diadanh, string danhgia, float diem, string iddiadiem)
        {
            try
            {
                KHACHSAN ks = data.KHACHSANs.Where(n => n.MAKHACHSAN == maks).FirstOrDefault();
                
                ks.MANCC = mancc;
                ks.TENKHACHSAN = tenkhachsan;
                ks.SOLUONGPHONG = (int)soluongphong;
                ks.SOSAO = (int)sosao;
                ks.TINH = tinh;
                ks.QUAN = quan;
                ks.PHUONG = phuong;
                ks.DUONG = duong;
                ks.DIACHICUTHE = diachicuthe;
                ks.ANHKS1 = anhks1;
                ks.ANHKS2 = anhks2;
                ks.ANHKS3 = anhks3;
                ks.ANHKS4 = anhks4;
                ks.ANHKS5 = anhks5;
                ks.MOTA = mota;
                ks.DIADANH = diadanh;
                ks.DANHGIA = danhgia;
                ks.DIEM = (float)diem;
                ks.IDDIADIEM = iddiadiem;
                
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deletekhachsan(string maks)
        {
            try
            {
                KHACHSAN ks = data.KHACHSANs.Where(n => n.MAKHACHSAN == maks).SingleOrDefault();
                data.KHACHSANs.DeleteOnSubmit(ks);
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
