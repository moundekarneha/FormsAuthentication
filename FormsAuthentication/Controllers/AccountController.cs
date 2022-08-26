using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormsAuthentication.Models;

namespace FormsAuthentication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Member member)
        {
            return View();
        }


        public ActionResult SinUp()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Login(Member member)
        //{
        //    return View();
        //}
    }
}