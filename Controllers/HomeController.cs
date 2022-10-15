using Blog_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace Blog_.Controllers
{
    public class HomeController : Controller
    {
        BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryWidgetGetir()
        {
            return View(context.Kategoris.ToList());
        }
        public ActionResult PostWidgetGetir()
        {
            ViewBag.Fresh = context.Makales.OrderByDescending(x => x.YayinlamaTarihi).Take(5);

            ViewBag.Populer=context.Makales.OrderByDescending(x=>x.Goruntulenme).Take(5);
            return View();

        }
    }
}