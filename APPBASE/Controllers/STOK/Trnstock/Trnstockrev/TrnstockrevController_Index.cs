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
using APPBASE.Svcbiz;


namespace APPBASE.Controllers
{
    [MyActionFilterAttribute]
    public partial class TrnstockrevController : TrnstockController
    {
        protected override Boolean _Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];
            Session[SESSION_PRODUCTSTOCK] = null;
            return true;
        }
        public override ActionResult Index()
        {
            this._Index();
            //return View("~/Views/Trnstock/Index.cshtml", oVMProductstok);
            return View(View_index, oVMProductstok);
        }
    } //End class
} //End namespace
