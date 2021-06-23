using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_dat_phong_ks.Models;

namespace Web_dat_phong_ks.Controllers
{
    public class SearchController : Controller
    {
        QLDPKSDataContext data = new QLDPKSDataContext();
        [HttpPost]
        public ActionResult search(FormCollection collection)
        {
            var dulieutim = collection["keyword"];
            KHACHSAN ks = data.KHACHSANs.SingleOrDefault(s => s.TENKHACHSAN == dulieutim);
            if (ks != null)
            {
                return RedirectToAction("HTKhachsan", "Home", new { iddd = ks.MAKHACHSAN });
            }
            else
            {
                ViewBag.Loitim = "Không có khách sạn";
                return RedirectToAction("Index","Home");
            }
            
        }
    }
}