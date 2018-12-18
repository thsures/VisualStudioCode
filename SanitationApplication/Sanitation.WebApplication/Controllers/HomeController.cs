using Sanitation.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sanitation.BusinessLibrary;
using System.Data;
using System.Data.SqlClient;

namespace Sanitation.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Contactus()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Aboutus()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel usermodel)
        {
            SanitationBL_DataAccess blaccess = new SanitationBL_DataAccess();
            string value = blaccess.Insert(usermodel.UserName, usermodel.Password);
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

    }
}