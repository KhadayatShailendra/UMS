using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMS.Common;
using UMS.Data;

namespace UMS.Web.Controllers
{
    public class LoginController : Controller
    {
        private DataAccessor _dataAccessor = new DataAccessor();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Validate(Login loginData)
        {
            if (_dataAccessor.ValidateUser(loginData))
            {
                RedirectPermanent("Main/Index");
            }
            return View("Login");
        }
    }
}