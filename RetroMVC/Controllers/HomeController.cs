using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RetroMVC.Models;
using Data;

namespace RetroMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ctx = new RetroContext();
            var blogs = ctx.Blog.ToList();
            return View(blogs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}