﻿using System;
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

       

    }
}