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
    public partial class RptpricelistController : Controller
    {
        //DBContext
        private DBMAINContext db = new DBMAINContext();
        //VM
        private ProductVM oVM;
        //DATA
        private ProductVM oData;
        private List<ProductVM> oData_list;
        //DS
        private ProductDS oDS;
        //CRUD
        private ProductCRUD oCRUD;
        //VALIDATION
        private Product_Validation oVAL;
        //BL
        //MAP


        //Init
        private void initConstructor(DBMAINContext poDB)
        {
            //DBContext
            this.db = poDB;
            //VM
            this.oVM = new ProductVM();
            //DS
            this.oDS = new ProductDS(this.db);
            //CRUD
            this.oCRUD = new ProductCRUD();

            //BL
            //MAP
        } //End initConstructor
        //Constructor 1
        public RptpricelistController()
        {
            //DBContext
            this.initConstructor(new DBMAINContext());
        } //End Constructor 1
        //Constructor 2
        public RptpricelistController(DBMAINContext poDB)
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
            this.oData_list = oDS.getDatalist();
            if (this.oData_list != null) this.oData_list = this.oData_list.OrderByDescending(fld => fld.PROD_PRICEDT).ToList();
            return View(this.oData_list);
        }
        public ActionResult Index_print()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData_list = oDS.getDatalist();
            if (this.oData_list != null) this.oData_list = this.oData_list.OrderByDescending(fld => fld.PROD_PRICEDT).ToList();
            return View(this.oData_list);
        }
        public ActionResult Details(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DETAILS;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.VIEW;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }
            return View(this.oData);
        }
        public ActionResult Create()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_CREATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;
            return View();
        }
        public ActionResult Edit(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_UPDATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.UPDATE;
            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }
            return View(this.oData);
        }
        public ActionResult Delete(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DELETE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.DELETE;
            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }
            return View(this.oData);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End Controller
} //End namespace
