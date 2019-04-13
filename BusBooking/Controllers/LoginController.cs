using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BusBooking.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Đăng Nhập";
            return View();
        }
        public ActionResult Authentication()
        {
            return RedirectToAction("Index", "Home", null);
        }
    }
}