using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webks.Models;

namespace webks.Controllers
{
    public class GioHangController : Controller
    {
        QLDPKSDataContext data = new QLDPKSDataContext();
        public List<GioHang> lstGH(string maphong, string ngayden, string ngaydi)
        {
            var ghp = from a in data.PHONGs
                      join b in data.KHACHSANs
                      on a.MAKHACHSAN equals b.MAKHACHSAN
                      where a.MAPHONG == maphong
                      select new GioHang
                      {
                          MAPHONG = a.MAPHONG,
                          ANHKS1 = b.ANHKS1,
                          TENKHACHSAN = b.TENKHACHSAN,
                          SOSAO = (int)b.SOSAO,
                          LOAIGIUONG = a.LOAIGIUONG,
                          ANH1 = a.ANH1,
                          TENPHONG = a.TENPHONG,
                          DIENTICH = (int)a.DIENTICH,
                          QUANGCANH = a.QUANGCANH,
                          GIA = (int)a.GIA,
                          GIAM = (float)a.GIAM,
                          SOGIUONG = (int)a.SOGIUONG,
                          GIAMOI = (int)(a.GIA - ((a.GIA * a.GIAM) / 100)),
                          NGAYDEN = ngayden,
                          NGAYDI = ngaydi,
                          SODEM = tinhngay(ngayden, ngaydi),
                          TONGTIEN = thanhtien(((int)(a.GIA - ((a.GIA * a.GIAM) / 100))),((int)tinhngay(ngayden, ngaydi))),
                          THUE = (int)Math.Round(((int)(a.GIA - ((a.GIA * a.GIAM) / 100))*tinhngay(ngayden,ngaydi)*0.1), MidpointRounding.AwayFromZero),
                          THANHTIEN = ((int)(a.GIA - ((a.GIA * a.GIAM) / 100)) * tinhngay(ngayden, ngaydi)) + (int)Math.Round(((int)(a.GIA - ((a.GIA * a.GIAM) / 100)) * tinhngay(ngayden, ngaydi) * 0.1), MidpointRounding.AwayFromZero)
                      };
            return ghp.ToList();
        }

        public ActionResult GioHang(string maphong, string ngayden, string ngaydi)
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("dangnhap", "TK");
            }
            else
            {
                var dl = lstGH(maphong, ngayden, ngaydi);
                return View(dl.SingleOrDefault());
            }
            
        }

        private int tinhngay(string ngayden, string ngaydi)
        {
            int nde = int.Parse(ngayden.Substring(8, 2));
            int ndi = int.Parse(ngaydi.Substring(8, 2));
            int DEM = ngayden.Length;
            return ndi - nde;
        }

        private int thanhtien(int gia, int songay)
        {
            return gia * songay;
        }

        public double tinhthue(int tien, int phantram)
        {
            return tien * (phantram / 100);
        }
        
        public ActionResult Datphong(FormCollection collection, string maphong, string ngayden, string ngaydi)
        {
            BOOKING bk = new BOOKING();
            TAIKHOAN tk = (TAIKHOAN)Session["Taikhoan"];
            List<GioHang> gh = lstGH(maphong, ngayden, ngaydi);
            var chbkht = collection["kohutthuoc"];
            string chbtc = "";
            string chbxhd = "";

            bk.MAPHONG = maphong;
            bk.MAKH = tk.MAKH;

            bk.NGAYVAO = new DateTime(catnam(ngayden), catthang(ngayden), catngay(ngayden));
            bk.NGAYDI = new DateTime(catnam(ngaydi), catthang(ngaydi), catngay(ngaydi));

            bk.HOTEN = collection["tt-hoten"].ToString();
            bk.SDT = collection["tt-sdt"].ToString();
            bk.EMAIL = collection["tt-email"].ToString();
            
            foreach(var item in gh)
            {
                bk.THANHTIEN = item.THANHTIEN;
                bk.SODEM = item.SODEM;
            }

            string ycr = collection["yc-rieng"];

            //var checkbox1 = Request.Form["kohutthuoc"];

            //if (checkbox1.Contains("Phòng không hút thuốc"))
            //{
            //    chbkht = "Không hút thuốc";
            //    bk.YEUCAU = chbkht;
            //}           
            bk.YEUCAU = ycr;
            data.BOOKINGs.InsertOnSubmit(bk);
            data.SubmitChanges();
            return RedirectToAction("Thanhcong", "GioHang");
           
        }

        public ActionResult Thanhcong()
        {
            return View();
        }

        private int catngay(string thoigian) 
        {
            int ngay = int.Parse(thoigian.Substring(8, 2));
            return ngay;
        }

        private int catthang(string thoigian)
        {
            return int.Parse(thoigian.Substring(5, 2));
        }

        private int catnam(string thoigian)
        {
            return int.Parse(thoigian.Substring(0, 4));
        }
       
    }
}