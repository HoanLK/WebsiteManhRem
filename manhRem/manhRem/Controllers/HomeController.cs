using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace manhRem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Productscatalog()
        {
            ViewBag.Message = "Danh mục các loại sản phẩm.";

            return View();
        }

        public ActionResult Productstype()
        {
            ViewBag.Message = "Từng loại sản phẩm.";

            return View();
        }

        public ActionResult Productlist()
        {
            ViewBag.Message = "Danh sách sản phẩm.";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Sản phẩm.";

            return View();
        }

        public ActionResult Tutorial()
        {
            ViewBag.Message = "Hướng dẫn.";

            return View();
        }
    }
}