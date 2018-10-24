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
    public partial class TrnstockrevController : TrnstockController
    {
        public override ActionResult Reportprint(int? id = null)
        {
            this._Reportprint(id);
            return View("~/Views/Trnstockrev/Reportprint.cshtml", this.oData);
        }
    } //End class
} //End namespace
