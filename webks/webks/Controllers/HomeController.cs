using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webks.Models;

namespace webks.Controllers
{
    public class HomeController : Controller
    {
        QLDPKSDataContext data = new QLDPKSDataContext();

        public ActionResult Index()
        {
            return View();
        }

        public List<HOME_DDNB> layDiaDiem()
        {
            return data.HOME_DDNBs.ToList();
        }

        public ActionResult DiaDiem()
        {
            var diadiem = layDiaDiem();
            return PartialView(diadiem);
        }

        public List<HOME_SLIDE> laySlide()
        {
            return data.HOME_SLIDEs.ToList();
        }

        public ActionResult HTSlide()
        {
            var slide = laySlide();
            return PartialView(slide);
        }

        public List<ProView> lstKS(string ID, string ngayden, string ngaydi, int sophong, int songuoi)
        {

            //var ks = from khachsan in data.KHACHSANs
            //         where khachsan.TINH == tinh
            //         select khachsan;
            var ks = from s in data.KHACHSANs
                     join b in data.HOME_DDNBs
                     on ID equals b.IDDIADIEM
                     where s.IDDIADIEM == ID
                     select new ProView()
                     {
                         MAKHACHSAN = s.MAKHACHSAN,
                         TENKHACHSAN = s.TENKHACHSAN,
                         SOLUONGPHONG = (int)s.SOLUONGPHONG,
                         SOSAO = (int)s.SOSAO,
                         TINH = s.TINH,
                         QUAN = s.QUAN,
                         PHUONG = s.PHUONG,
                         DUONG = s.DUONG,
                         DIACHICUTHE = s.DIACHICUTHE,
                         ANHKS1 = s.ANHKS1,
                         MOTA = s.MOTA,
                         DIADANH = s.DIADANH,
                         DANHGIA = s.DANHGIA,
                         DIEM = (float)s.DIEM,
                         TENDIADIEM = b.TENDIADIEM,
                         NGAYDEN = ngayden,
                         NGAYDI = ngaydi,
                         SOPHONG = sophong,
                         SONGUOI = songuoi
                     };


            return ks.ToList();
        }

        public ActionResult HTKhachsan(string iddd, string ngayden, string ngaydi, int sophong, int songuoi)
        {
            
            //if(ngaydi=="" && ngayden=="")
            //{
            //    TimeSpan time = new System.TimeSpan(1, 0, 0, 0);
            //    DateTime homnay = DateTime.Now;
            //    DateTime ngaymai = homnay.Add(time);
            //    ngayden = homnay.ToString();
            //    ngaydi = ngaymai.ToString();
            //    var ks = lstKS(iddd, ngayden, ngaydi, sophong, songuoi);
            //    return View(ks);
            //}
            //else
            //{
            //    var ks = lstKS(iddd, ngayden, ngaydi, sophong, songuoi);
            //    return View(ks);
            //}
            var ks = lstKS(iddd, ngayden, ngaydi, sophong, songuoi);
            return View(ks);
        }

        public List<ProView> lstoneKS(string maks, string ngayden, string ngaydi, int sophong, int songuoi)
        {
            var ks = from s in data.KHACHSANs
                     where s.MAKHACHSAN == maks
                     select new ProView
                     {
                         MAKHACHSAN = s.MAKHACHSAN,
                         TENKHACHSAN = s.TENKHACHSAN,
                         SOLUONGPHONG = (int)s.SOLUONGPHONG,
                         SOSAO = (int)s.SOSAO,
                         TINH = s.TINH,
                         QUAN = s.QUAN,
                         PHUONG = s.PHUONG,
                         DUONG = s.DUONG,
                         DIACHICUTHE = s.DIACHICUTHE,
                         ANHKS1 = s.ANHKS1,
                         ANHKS2 = s.ANHKS2,
                         ANHKS3 = s.ANHKS3,
                         ANHKS4 = s.ANHKS4,
                         ANHKS5 = s.ANHKS5,
                         MOTA = s.MOTA,
                         DIADANH = s.DIADANH,
                         DANHGIA = s.DANHGIA,
                         DIEM = (float)s.DIEM,
                         NGAYDEN = ngayden,
                         NGAYDI = ngaydi,
                         SOPHONG = sophong,
                         SONGUOI = songuoi
                     };
            return ks.ToList();
        }

        public ActionResult ChiTietPhong(string maks, string ngayden, string ngaydi, int sophong, int songuoi)
        {
            var ks = lstoneKS(maks, ngayden, ngaydi, sophong, songuoi);
            return View(ks.SingleOrDefault());
        }

        public List<TTPhongModel> lstonephong(string maks,string ngayden, string ngaydi)
        {
            var tt = from s in data.PHONGs
                     where s.MAKHACHSAN == maks
                     select new TTPhongModel
                     {
                         MAKHACHSAN = s.MAKHACHSAN,
                         MALOAI = s.MALOAI,
                         MAPHONG = s.MAPHONG,
                         TENPHONG = s.TENPHONG,
                         DIENTICH = (int)s.DIENTICH,
                         QUANGCANH = s.QUANGCANH,
                         GIA = (int)s.GIA,
                         GIAM = (float)s.GIAM,
                         ANH1 = s.ANH1,
                         ANH2 = s.ANH2,
                         ANH3 = s.ANH3,
                         ANH4 = s.ANH4,
                         ANH5 = s.ANH5,
                         SOGIUONG = (int)s.SOGIUONG,
                         LOAIGIUONG = s.LOAIGIUONG,
                         SOLUONG = (int)s.SOLUONG,
                         SOKHACH = (int)s.SOKHACH,
                         GIAMOI = (int)(s.GIA - ((s.GIA * s.GIAM) / 100))
                     };
            return tt.ToList();
        }

        public ActionResult ThongTinPhong(string maks, string ngayden, string ngaydi)
        {
            var phong = lstonephong(maks,ngayden,ngaydi);
            return PartialView(phong);
        }

        public List<TienIchModel> lstTienIch(string maks)
        {
            var ti = from s in data.KSTIENICHes
                     join a in data.TIENICHes
                     on s.IDTIENICH equals a.IDTIENICH
                     join b in data.KHACHSANs
                     on s.MAKHACHSAN equals b.MAKHACHSAN
                     where s.MAKHACHSAN == maks
                     select new TienIchModel
                     {
                         IDTIENICH = (int)s.IDTIENICH,
                         TENTIENICH = a.TENTIENICH,
                         ICON = a.ICON,
                         MAKHACHSAN = s.MAKHACHSAN,
                         GHICHU = s.GHICHU,
                         DIEM = (float)b.DIEM
                     };
            return ti.ToList();
        }

        public ActionResult tienichks(string maks)
        {
            var tis = lstTienIch(maks);
            return PartialView(tis);
        }

        public List<TTPhongModel> lstgianho(string maks)
        {
            var popp = from s in data.PHONGs
                       where s.MAKHACHSAN == maks
                       select new TTPhongModel
                       {
                           GIA = (int)s.GIA,
                           GIAM = (float)s.GIAM,
                           GIAMOI = (int)(s.GIA - ((s.GIA * s.GIAM) / 100))
                       };
            return popp.OrderBy(n => n.GIA).ToList();
        }

        public ActionResult pphong(string maks)
        {
            var pp = lstgianho(maks);
            return PartialView(pp.FirstOrDefault());
        }

        public ActionResult pphongtw(string maks)
        {
            var tw = lstgianho(maks);
            return PartialView(tw.FirstOrDefault());
        }

        public ActionResult hientk()
        {
            List<string> tentk = new List<string>();
            
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == null)
            {
                string tentk1 = "";
                tentk.Add(tentk1);
            }
            else
            {
                TAIKHOAN tk = (TAIKHOAN)Session["Taikhoan"];
                string tentk1 = "Xin chào " + tk.TENDN.Trim();
                tentk.Add(tentk1);
            }
            return PartialView(tentk);            
        }

        
    }
}