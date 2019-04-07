using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusBooking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Route()
        {
            ViewBag.Message = "Tuyến Đường";

            return View();
        }
        public ActionResult Guide()
        {
            ViewBag.Message = "Hướng dẫn đặt vé";
            ViewBag.Website = "BusOnlineTicket.Com";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Order()
        {
            ViewBag.Message = "Chọn Ghế";
            return View();
        }
        public ActionResult InfoCustomer()
        {
            ViewBag.Message = "Thông Tin Khách Hàng";
            return View();
        }
        public ActionResult Payment()
        {
            ViewBag.Message = "Thanh Toán";
            return View();
        }
    }
}