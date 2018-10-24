using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using APPBASE.Filters;
using APPBASE.Models;
using APPBASE.Helpers;

namespace APPBASE.Controllers
{
    public partial class AccountController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            hlpConfig.SessionInfo.setDefSession();
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        //Changepassword
        public ActionResult Changepassword(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public ActionResult LogOff()
        {
            return RedirectToAction("Login", "Account");
        }
        [MyActionFilterAttribute]
        public ActionResult Register()
        {
            return View();
        }
    } //End public partial class AccountController : Controller
} //End namespace APPBASE.Controllers
