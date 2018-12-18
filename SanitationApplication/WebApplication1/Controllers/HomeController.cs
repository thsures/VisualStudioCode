using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(UserRegistration Ur)
        {
            SanitationAppEntities db = new SanitationAppEntities();
            db.UserRegistrations.Add(Ur);
            db.SaveChanges();
            return View();
        }
    }
}