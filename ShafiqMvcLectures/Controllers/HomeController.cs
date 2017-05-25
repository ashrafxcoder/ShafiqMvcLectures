using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShafiqMvcLectures.Controllers
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



            var vm = new AboutVm()
            {
                WeekDays = CultureInfo.CurrentCulture.DateTimeFormat.DayNames.ToList(),
                Ages = Enumerable.Range(20, 10).ToList()
            };
            return View(vm);
        }

        [ChildActionOnly]
        public PartialViewResult WeekDays()
        {
            var model = CultureInfo.CurrentCulture.DateTimeFormat.DayNames.ToList();
            return PartialView("WeekDays", model);
        }

        [ChildActionOnly]
        public PartialViewResult Ages()
        {
            var model = Enumerable.Range(20, 10).ToList();
            return PartialView("Ages", model);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, bool rememberMe)
        {
            if (username == "shafiq" && password == "shafiq")
            {
                
                FormsAuthentication.SetAuthCookie(username, rememberMe);
                return RedirectToAction("Index", "Admin");
            }

            return View();

        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }


    }



    public class AboutVm
    {
        public List<string> WeekDays { get; set; }
        public List<int> Ages { get; set; }
    }
}