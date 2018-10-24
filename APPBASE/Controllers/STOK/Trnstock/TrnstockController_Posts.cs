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
    public partial class TrnstockController : Controller
    {
        [HttpPost]
        public virtual ActionResult Index(ProductstockVM poViewModel)
        {
            if (this._Index_post(poViewModel)) return RedirectToAction("Create");
            //return View("~/Views/Trnstock/Index.cshtml", poViewModel);
            return View(View_index, oVMProductstok);
        }
        [HttpPost]
        public virtual ActionResult Create(TrnstockVM poViewModel)
        {
            //If Process Success
            if (this._Create_post(poViewModel))
            {
                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Reportprint", new { id = oBL.CRUD.ID });
            } //End if (!oCRUD.isERR)
            //If Error on CRUD Operation
            if ((oCRUD.ERRMSG != "") && (oCRUD.ERRMSG != null)) {
                TempData["ERRMSG"] = oCRUD.ERRMSG;
                return RedirectToAction("ErrorSYS", "Error");
            } //End if
            this.prepareLookup();

            return View("~/Views/Trnstock/Create.cshtml", poViewModel);
        }
    } //End public partial class TrnstockdisplayController : Controller
} //End namespace APPBASE.Controllers
