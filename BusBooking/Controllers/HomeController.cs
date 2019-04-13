using BusBooking.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace BusBooking.Controllers
{
    public class HomeController : Controller
    {
        private BusDBContext busdb = new BusDBContext();

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
        public ActionResult SignUp()
        {
            ViewBag.Message = "Đăng Ký";
            return View();
        }
        public ActionResult Bus()
        {
            List<Bus> customers = new List<Bus>();
            string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                string query = "SELECT IdBus, LicencePlates, Color, DriverName FROM Bus";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            customers.Add(new Bus
                            {
                                IdBus = Convert.ToInt32(sdr["IdBus"]),
                                LicencePlates = sdr["LicencePlates"].ToString(),
                                Color = sdr["Color"].ToString(),
                                DriverName = sdr["DriverName"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }

            return View(customers);
        }
        public ActionResult BusDB()
        {
            var fruits = busdb.topBuses();
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(fruits);
            ViewBag.Title = "Anychart ASP.NET C# template";
            ViewBag.ChartTitle = "Top 5 fruits";
            ViewBag.ChartData = json;
            return View(fruits);
        }
    }
}