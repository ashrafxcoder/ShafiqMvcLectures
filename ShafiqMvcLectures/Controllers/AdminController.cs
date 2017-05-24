using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShafiqMvcLectures.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            
            return Content("Index action method");
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return Content("Detail action method");
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return Content("Create action method");
        }



    }
}
