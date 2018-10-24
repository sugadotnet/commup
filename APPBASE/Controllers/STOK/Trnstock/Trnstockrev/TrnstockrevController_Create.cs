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
        //BL
        protected Mutasi_revaddBL oBLMutasi_revadd;
        protected Mutasi_revsubBL oBLMutasi_revsub;

        protected override Boolean _Create()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_CREATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;

            this.oData = new TrnstockVM();
            ProductstockVM oViewModel = new ProductstockVM();
            if (Session[SESSION_PRODUCTSTOCK] != null)
            {
                oViewModel = (ProductstockVM)Session[SESSION_PRODUCTSTOCK];
                this.oData.mapToInput(oViewModel);
            } //End if

            this.prepareLookup();
            return true;
        }
        public override ActionResult Create()
        {
            this._Create();
            return View("~/Views/Trnstockrev/Create.cshtml", this.oData);
        }

    } //End class
} //End namespace
