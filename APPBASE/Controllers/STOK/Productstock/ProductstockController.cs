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
using APPBASE.Svcapp;


namespace APPBASE.Controllers
{
    [MyActionFilterAttribute]
    public partial class ProductstockController : Controller
    {
        //AUTH
        protected int? ROLE_ID = hlpConfig.SessionInfo.getAppRoleId();
        protected string View_index = "~/Views/Productstock/Index.cshtml";

        //DBContext
        protected DBMAINContext db = new DBMAINContext();
        //VM
        protected ProductstockVM oVM;
        //DATA
        protected ProductstockVM oData;
        protected List<ProductstockVM> oData_list;
        //DS
        protected ProductstockDS oDS;
        //CRUD
        protected ProductstockCRUD oCRUD;
        //VALIDATION
        protected Productstock_Validation oVAL;
        //BL
        //MAP

        //Init
        private void initConstructor(DBMAINContext poDB)
        {
            //DBContext
            this.db = poDB;
            //VM
            this.oVM = new ProductstockVM();
            //DS
            this.oDS = new ProductstockDS(this.db);
            //CRUD
            this.oCRUD = new ProductstockCRUD(this.db);

            //BL
            //MAP
        } //End initConstructor
        //Constructor 1
        public ProductstockController()
        {
            //DBContext
            this.initConstructor(new DBMAINContext());
        } //End Constructor 1
        //Constructor 2
        public ProductstockController(DBMAINContext poDB)
        {
            //DBContext
            this.initConstructor(poDB);
        } //End Constructor 2

        //Prepare Lookup
        public void prepareLookup()
        {
            //ViewBag.SAMPLE = oDSSample.getDatalist_lookup();
        } //End prepareLookup()
        //Prepare Lookup Filter
        public void prepareLookupFilter()
        {
            //ViewBag.SAMPLE = oDSSample.getDatalist_lookup();
        } //End prepareLookupFilter()


        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            return View(View_index, this.oData);
        }
        public ActionResult Edit(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_UPDATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.UPDATE;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }
            return View("~/Views/Productstock/Edit.cshtml", this.oData);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End Controller
} //End namespace
