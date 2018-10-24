using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPBASE.Models;
using APPBASE.Helpers;
using APPBASE.Filters;
//using APPBASE.Svcapp;
using APPBASE.Svcbiz;

namespace APPBASE.Controllers
{
    //[MyActionFilterAttribute]
    public partial class ErrorController : Controller
    {
        
        public ActionResult ErrorSYS()
        {
            ViewBag.ERRMSG = TempData["ERRMSG"];
            return View();
        }
        public ActionResult Error403()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult ErrorDEV()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            //db.Dispose();
            base.Dispose(disposing);
        }
    } //End public partial class ErrorController : Controller
} //End namespace APPBASE.Controllers

