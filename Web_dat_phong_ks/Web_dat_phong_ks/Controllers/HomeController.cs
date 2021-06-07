using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_dat_phong_ks.Models;


namespace Web_dat_phong_ks.Controllers
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

        public List<ProView>lstKS(string ID)
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
                         GIAPHONGCU = (int)s.GIAPHONGCU,
                         GIAPHONGMOI = (int)s.GIAPHONGMOI,
                         DIADANH = s.DIADANH,
                         DANHGIA = s.DANHGIA,
                         DIEM = (int)s.DIEM,
                         TENDIADIEM = b.TENDIADIEM
                     };


            return ks.ToList();
        }

        public ActionResult HTKhachsan(string iddd)
        {
            //string tinh = "TP.Hồ Chí Minh";
            var ks = lstKS(iddd);
            return View(ks);
        }

       

    }
}