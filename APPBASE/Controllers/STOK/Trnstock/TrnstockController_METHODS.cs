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
        protected virtual Boolean _Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];
            Session[SESSION_PRODUCTSTOCK] = null;
            return true;
        }
        protected Boolean _Details(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DETAILS;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.VIEW;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            this.oData = oDS.getData(id);
            if (oData == null) { return false; }
            return true;
        }
        protected virtual Boolean _Create()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_CREATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;

            this.oData = new TrnstockVM();
            ProductstockVM oViewModel = new ProductstockVM();
            if (Session[SESSION_PRODUCTSTOCK] != null)
            {
                oViewModel = (ProductstockVM)Session[SESSION_PRODUCTSTOCK];
                this.oData.mapToInput(oViewModel);
            } //End if (TempData[TEMPDATA_PRODUCTSTOCK] != null)

            this.prepareLookup();
            return true;
        }
        protected Boolean _Reportprint(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData = oDS.getData(id);
            this.oData.LISTITEM = oDSDetail.getDatalist(this.oData.ID);
            return true;
        }
    } //End class
} //End namespace APPBASE.Controllers
