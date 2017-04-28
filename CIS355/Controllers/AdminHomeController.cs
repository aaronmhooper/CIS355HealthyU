using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS355.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        public ActionResult Index()
        {
            return View();
        }
    }
}