using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webks.Models;

namespace webks.Controllers
{
    public class SearchController : Controller
    {
        QLDPKSDataContext data = new QLDPKSDataContext();

        [HttpPost]
        public ActionResult search(FormCollection collection)
        {

            var dulieutim = collection["keyword"];
            string nd = collection["ngay_den"].ToString();
            string ndi = collection["ngay_di"].ToString();
            int sophong = int.Parse(collection["soluongphong"]);
            int songuoi = int.Parse(collection["soluongkhach"]);
            HOME_DDNB dd = data.HOME_DDNBs.Where(s => s.TENDIADIEM == dulieutim).SingleOrDefault();
            if (dd != null)
            {
                return RedirectToAction("HTKhachsan", "Home", new { iddd = dd.IDDIADIEM, ngayden = nd, ngaydi = ndi, sophong = sophong, songuoi = songuoi });
            }
            else
            {
                ViewBag.Loitim = "Không có khách sạn";
                return RedirectToAction("Index", "Home");
            }

        }

        public ActionResult secondsearch(string ngayden, string ngaydi, string tendiadiem, int sophong, int songuoi)
        {
            List<string> ngay = new List<string>();
            string sp = sophong.ToString();
            string sn = songuoi.ToString();
            ngay.Add(ngayden);
            ngay.Add(ngaydi);
            ngay.Add(tendiadiem);
            ngay.Add(sp);
            ngay.Add(sn);
            //ngaydi.ToList();
            //ngayden.ToList();

            return PartialView(ngay);
        }

        [HttpPost]
        public ActionResult secondSearch(FormCollection collection)
        {
            var dulieutim = collection["search_name"];
            string nd = collection["date_den"].ToString();
            string ndi = collection["date_di"].ToString();
            int sophong = int.Parse(collection["slphong"]);
            int songuoi = int.Parse(collection["slnglon"]);
            HOME_DDNB dd = data.HOME_DDNBs.Where(s => s.TENDIADIEM == dulieutim).SingleOrDefault();
            if (dd != null)
            {
                return RedirectToAction("HTKhachsan", "Home", new { iddd = dd.IDDIADIEM, ngayden = nd, ngaydi = ndi, sophong = sophong, songuoi = songuoi });
            }
            else
            {
                ViewBag.Loitim = "Không có khách sạn";
                return RedirectToAction("Index", "Home");
            }
        }
    }    
}