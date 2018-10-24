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
        [HttpPost]
        public ActionResult Login(UserloginVM poVM, string returnUrl)
        {
            if ((ModelState.IsValid) && (hlpCredentialInfo.isValidDBLogin(poVM.USERNAME, poVM.PASSWORD, hlpConfig.ConstantaInfo.MDLE_ID)))
            {
                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Login salah user atau password.");
            return View(poVM);
        }
    } //End public partial class AccountController : Controller
} //End namespace APPBASE.Controllers
