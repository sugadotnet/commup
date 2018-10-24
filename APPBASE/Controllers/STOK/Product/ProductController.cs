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
    public partial class ProductController : Controller
    {
        private DBMAINContext db = new DBMAINContext();
        //DS
        private ProductDS oDS = new ProductDS();
        private ProductnewDS oDSProductnew = new ProductnewDS();
        protected ProductDS oDSProduct = new ProductDS();
        protected ProductstockDS oDSProductstock = new ProductstockDS();
        protected VendorDS oDSVendor = new VendorDS();
        protected StorageDS oDSStorage = new StorageDS();
        //CRUD
        private ProductCRUD oCRUD = new ProductCRUD();
        private ProductstockCRUD oCRUDProductstock;
        protected TrnstockCRUD oCRUD_trn = new TrnstockCRUD();
        protected TrnstockdCRUD oCRUDDetail_trn = new TrnstockdCRUD();

        //Validation
        private Product_Validation oVAL;
        //BL
        protected Mutasi_newBL oBL;

        //Constructor 1
        public ProductController() {
            this.db = new DBMAINContext();
            //DS
            this.oDS = new ProductDS(db);
            this.oDSProductnew = new ProductnewDS();
            oCRUDProductstock = new ProductstockCRUD(this.db);
            //CRUD
            this.oCRUD = new ProductCRUD();
            this.oCRUDProductstock = new ProductstockCRUD();
            //BL
            this.oBL = new Mutasi_newBL(this.db);
        } //End Constructor
        //Constructor 2
        public ProductController(DBMAINContext poDB) {
            this.db = poDB;
            //DS
            this.oDS = new ProductDS();
            this.oDSProductnew = new ProductnewDS();
            oCRUDProductstock = new ProductstockCRUD(this.db);
            //CRUD
            this.oCRUD = new ProductCRUD();
            this.oCRUDProductstock = new ProductstockCRUD();
            //BL
            this.oBL = new Mutasi_newBL();
        } //End Constructor

        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            var oData = oDS.getDatalist();
            if (oData != null) oData = oData.OrderByDescending(fld => fld.PROD_PRICEDT).ToList();
            return View(oData);
        }
        public ActionResult Indexvalidasi()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            if (hlpConfig.SessionInfo.getAppRoleId() != valFLAG.FLAG_ROLE_ADM) return RedirectToAction("Error403", "Error");
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];
            var oData = oDSProductnew.getDatalist_validate();
            if (oData != null) oData = oData.OrderByDescending(fld => fld.PRODNEW_OPENDT).ToList();
            return View(oData);
        }
        public ActionResult Details(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DETAILS;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.VIEW;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            return View(oData);
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
            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            return View(oData);
        }
        public ActionResult Edit_pricelist(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_UPDATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.UPDATE;
            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            return View(oData);
        }
        public ActionResult Delete(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DELETE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.DELETE;
            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            return View(oData);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End public partial class ProductController : Controller
} //End namespace APPBASE.Controllers
