using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_dat_phong_ks.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        public ActionResult ThanhToan()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("dangnhap", "TK");
            }
            return View();
        }
    }
}