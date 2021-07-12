using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webks.Models;

namespace webks.Controllers
{
    public class TKController : Controller
    {
        QLDPKSDataContext data = new QLDPKSDataContext();

        [HttpGet]
        public ActionResult dangky()
        {
            return View();
        }

        [HttpPost]
        public ActionResult dangky(FormCollection collection, TAIKHOAN tk)
        {
            var tendn = collection["dk-tendn"];
            var email = collection["dk-email"];
            var matkhau = collection["dk-mk"];
            var sdt = collection["dk-sdt"];

            tk.TENDN = tendn;
            tk.EMAIL = email;
            tk.MATKHAU = matkhau;
            tk.SDT = sdt;
            data.TAIKHOANs.InsertOnSubmit(tk);
            data.SubmitChanges();
            return RedirectToAction("thanhcong");
        }

        public ActionResult thanhcong()
        {
            return View();
        }

        public ActionResult dangnhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult dangnhap(FormCollection collection)
        {
            var tendn = collection["dn-tendn"];
            var mk = collection["dn-mk"];
            TAIKHOAN tk = data.TAIKHOANs.SingleOrDefault(n => n.TENDN == tendn && n.MATKHAU == mk);
            if (tk != null)
            {
                Session["Taikhoan"] = tk;
                return RedirectToAction("Index", "Home");
            }
            else
                ViewBag.Thongbao = "Sai tên đăng nhập hoặc mật khẩu";
            return View();
        }
    }
}