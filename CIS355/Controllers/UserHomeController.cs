using CIS355.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS355.Controllers
{
    [Authorize]
    public class UserHomeController : Controller
    {
        // GET: UserHome
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;
        public UserHomeController(ApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        public UserHomeController()
        {

        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set
            {
                _userManager = value;
            }
        }
        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "AdminHome");
            }
            int points = 0;
            ViewBag.user = User.Identity.Name;
            List<Transaction> userTrans = new List<Transaction>();
            foreach (Transaction trans in db.Transactions.ToList())
            {
                
                if(trans.User.Id== User.Identity.GetUserId())
                {
                    userTrans.Add(trans);
                }
            }
            foreach(Transaction trans in userTrans)
            {

                points += trans.Actvity.Points;
            }
            ViewBag.points = points;
            return View();
        }
    }
}