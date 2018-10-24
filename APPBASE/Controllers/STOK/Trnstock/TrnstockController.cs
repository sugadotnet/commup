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
    public partial class TrnstockController : Controller
    {
        //AUTH
        protected int? ROLE_ID = hlpConfig.SessionInfo.getAppRoleId();
        protected string View_index = "~/Views/Trnstock/Index.cshtml";
        protected int? STOCKSTORAGE_ID;
        protected Boolean isShowLogbook;

        //DBCOntext
        protected DBMAINContext db = new DBMAINContext();
        //BL
        protected MutasiBL oBL;
        protected IDMutasiBL oBLIDMutasi;
        //MAP
        protected StockMAP oMAPStock;

        //DS
        protected TrnstockDS oDS;
        protected TrnstockdDS oDSDetail;
        protected ProductDS oDSProduct;
        protected ProductstockDS oDSProductstock;
        protected StorageDS oDStorage;
        protected IdmutasiDS oDSIdmutasi;
        //CRUD
        protected TrnstockCRUD oCRUD = new TrnstockCRUD();
        protected TrnstockdCRUD oCRUDDetail = new TrnstockdCRUD();
        protected ProductstockCRUD oCRUDProductstock = null;
        protected IdmutasiCRUD oCRUDIdmutasi;

        //VALIDATION
        protected Trnstock_Validation oVAL;
        //VM
        protected TrnstockVM oData;
        protected List<TrnstockdVM> oDatadetail_list;
        protected List<ProductstockVM> oDataproductstock_list;
        protected ProductstockVM oVMProductstok;
        protected List<StorageVM> oVMStorage;
        //Tempdata ID
        protected string SESSION_PRODUCTSTOCK;
        protected string SESSION_PRODUCTSTOCK_PRINT;

        //DS STORAGE
        protected StorageDS oDSStorage = new StorageDS();

        //Constructor 1
        public TrnstockController() {
            this.db = new DBMAINContext();

            //BL
            oBL = new MutasiBL(this.db);
            oBLIDMutasi = new IDMutasiBL(this.db);
            //MAP
            oMAPStock = new StockMAP(this.db);

            //CRUD
            this.oCRUD = new TrnstockCRUD();
            this.oCRUDDetail = new TrnstockdCRUD();
            this.oCRUDProductstock = new ProductstockCRUD(this.db);
            this.oCRUDIdmutasi = new IdmutasiCRUD(this.db);
            //DS
            oDS = new TrnstockDS(this.db);
            oDSDetail = new TrnstockdDS();
            oDSProduct = new ProductDS(this.db);
            oDSProductstock = new ProductstockDS(this.db);
            oDSStorage = new StorageDS(this.db);
            oDSIdmutasi = new IdmutasiDS(this.db);
            //VM
            oVMProductstok = new ProductstockVM();
            this.SESSION_PRODUCTSTOCK = "PRODUCTSTOCK";
            this.SESSION_PRODUCTSTOCK_PRINT = "PRODUCTSTOCK_PRINT";
        }
        //Constructor 2
        public TrnstockController(DBMAINContext poDB)
        {
            this.db = poDB;
            //BL
            oBL = new MutasiBL(this.db);
            oBLIDMutasi = new IDMutasiBL(this.db);
            //MAP
            oMAPStock = new StockMAP(this.db);

            //CRUD
            this.oCRUDProductstock = new ProductstockCRUD(this.db);
            this.oCRUDIdmutasi = new IdmutasiCRUD(this.db);
            //DS
            oDS = new TrnstockDS(this.db);
            oDSDetail = new TrnstockdDS();
            oDSProduct = new ProductDS(this.db);
            oDSProductstock = new ProductstockDS(this.db);
            oDSStorage = new StorageDS(this.db);
            oDSIdmutasi = new IdmutasiDS(this.db);
            //VM
            oVMProductstok = new ProductstockVM();
            this.SESSION_PRODUCTSTOCK = "PRODUCTSTOCK";
        }

        public void prepareLookup()
        {
            //ViewBag.CITY = oDSCity.getDatalist_lookup();
            //ViewBag.STORAGE = oDSStorage.getDatalist_mutasiDisplay();
            ViewBag.STORAGE = oVMStorage;
        } //End prepareLookup()
        public void prepareLookupFilter()
        {
            //ViewBag.CITY = oDSCity.getDatalist_lookup();
        } //End prepareLookupFilter()

        public virtual ActionResult Index()
        {
            //if (this.isShowLogbook) return RedirectToAction("Logbook");
            this._Index();
            //return View("~/Views/Trnstock/Index.cshtml", oVMProductstok);
            return View(View_index, oVMProductstok);
        }
        public virtual ActionResult Logbook_balance()
        {
            this._Index();
            return View("~/Views/Trnstock/Logbook_balance.cshtml", oVMProductstok);
        }
        public virtual ActionResult Logbook()
        {
            ViewBag.STORAGE_ID = this.STOCKSTORAGE_ID;
            oDatadetail_list = oDSDetail.getDatalist_logbook(null, this.STOCKSTORAGE_ID, null);
            if (oDatadetail_list != null) oDatadetail_list = oDatadetail_list.OrderByDescending(fld => fld.TRN_DT).ToList();
            return View("~/Views/Trnstock/Logbook.cshtml", oDatadetail_list);
        }

        public virtual ActionResult Details(int? id = null)
        {
            if (!this._Details(id)) { return HttpNotFound(); }
            return View("~/Views/Trnstock/Details.cshtml", this.oData);
        }
        public virtual ActionResult Create()
        {
            this._Create();
            return View("~/Views/Trnstock/Create.cshtml", this.oData);
        }
        public virtual ActionResult Reportprint(int? id = null)
        {
            this._Reportprint(id);
            return View("~/Views/Trnstock/Reportprint.cshtml", this.oData);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End class
} //End namespace APPBASE.Controllers
