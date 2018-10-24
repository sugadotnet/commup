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
    public partial class ProductnewController : Controller
    {
        private DBMAINContext db;
        private ProductnewDS oDS;
        private ProductnewCRUD oCRUD;
        private Productnew_Validation oVAL;
        //BARCODE
        protected Barcode_13chars oBARCODE;
        //DATA
        protected ProductnewVM oData;
        protected List<ProductnewVM> oData_list;
        //COUNTRYCODE
        private CountrycodeDS oDSCountrycode;
        //VENDOR
        private VendorDS oDSVendor;
        //PRODTYPE
        private ProdtypeDS oDSProdtype;
        //PRODSUBTYPE
        private ProdsubtypeDS oDSProdsubtype;
        //SERIAL
        private SerialDS oDSSerial;
        //FINISHING
        private FinishingDS oDSFinishing;
        //UKURAN
        private UkuranDS oDSUkuran;
        //STORAGE
        private UomDS oDSUom;
        //STORAGE
        private StorageDS oDSStorage;

        //Constructor 1
        public ProductnewController() {
            this.db = new DBMAINContext();
            this.oDS = new ProductnewDS();
            this.oCRUD = new ProductnewCRUD();

            //COUNTRYCODE
            this.oDSCountrycode = new CountrycodeDS();
            //VENDOR
            this.oDSVendor = new VendorDS();
            //PRODTYPE
            this.oDSProdtype = new ProdtypeDS();
            //PRODSUBTYPE
            this.oDSProdsubtype = new ProdsubtypeDS();
            //SERIAL
            this.oDSSerial = new SerialDS();
            //FINISHING
            this.oDSFinishing = new FinishingDS();
            //UKURAN
            this.oDSUkuran = new UkuranDS();
            //STORAGE
            this.oDSUom = new UomDS();
            //STORAGE
            this.oDSStorage = new StorageDS(this.db);
        } //End Constructor
        //Constructor 2
        public ProductnewController(DBMAINContext poDB) {
            this.db = poDB;
            this.oDS = new ProductnewDS();
            this.oCRUD = new ProductnewCRUD();

            //COUNTRYCODE
            this.oDSCountrycode = new CountrycodeDS();
            //VENDOR
            this.oDSVendor = new VendorDS();
            //PRODTYPE
            this.oDSProdtype = new ProdtypeDS();
            //PRODSUBTYPE
            this.oDSProdsubtype = new ProdsubtypeDS();
            //SERIAL
            this.oDSSerial = new SerialDS();
            //FINISHING
            this.oDSFinishing = new FinishingDS();
            //UKURAN
            this.oDSUkuran = new UkuranDS();
            //STORAGE
            this.oDSUom = new UomDS();
            //STORAGE
            this.oDSStorage = new StorageDS(this.db);
        } //End Constructor


        public void prepareLookup()
        {
            ViewBag.COUNTRYCODE = oDSCountrycode.getDatalist_lookup();
            ViewBag.VENDOR = oDSVendor.getDatalist_lookup();
            ViewBag.PRODTYPE = oDSProdtype.getDatalist_lookup();

            if (this.oData != null) {
                ViewBag.PRODSUBTYPE = oDSProdsubtype.getDatalist_lookup(this.oData.PRODTYPE_ID);
                ViewBag.SERIAL = oDSSerial.getDatalist_lookup(this.oData.PRODTYPE_ID);
                ViewBag.FINISHING = oDSFinishing.getDatalist_lookup(this.oData.PRODTYPE_ID);
            } //end if
            
            ViewBag.UKURAN = oDSUkuran.getDatalist_lookup();
            ViewBag.UOM = oDSUom.getDatalist_lookup();
            var vSTORAGE = oDSStorage.getDatalist_lookup();
            int? nRoleId = hlpConfig.SessionInfo.getAppRoleId();
            //ADM
            if (nRoleId == valFLAG.FLAG_ROLE_ADM) {
                ViewBag.STORAGE = vSTORAGE.Where(fld => fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
            } //end if
            //GUDANG ATAS
            if (nRoleId == valFLAG.FLAG_ROLE_GDGA)
            {
                ViewBag.STORAGE = vSTORAGE.Where(fld => fld.ID == valFLAG.STORAGE_ID_GATAS).ToList();
            } //end if
            //GUDANG BAWAH
            if (nRoleId == valFLAG.FLAG_ROLE_GDGB)
            {
                ViewBag.STORAGE = vSTORAGE.Where(fld => fld.ID == valFLAG.STORAGE_ID_GBAWAH).ToList();
            } //end if
            //DISPLAY / SALES
            if (nRoleId == valFLAG.FLAG_ROLE_SLS)
            {
                ViewBag.STORAGE = vSTORAGE.Where(fld => fld.ID == valFLAG.STORAGE_ID_DISPLAY).ToList();
            } //end if
        } //End prepareLookup()
        public void prepareLookupFilter()
        {
            //ViewBag.BRANCHALL = oDSBranchall.getDatalist_lookup();
            //ViewBag.CLASSTYPE = oDSClasstype.getDatalist_lookup();
        } //End prepareLookupFilter()

        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            //-issue#8: this.oData_list = oDS.getDatalist();
            this.oData_list = oDS.getDatalist_validate(); //+issue#8
            if (this.oData_list != null) this.oData_list = this.oData_list.OrderByDescending(fld => fld.PRODNEW_OPENDT).ToList();
            
            return View(this.oData_list);
        }
        public ActionResult Details(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DETAILS;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.VIEW;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }

            //this.prepareLookup();
            return View(this.oData);
        }
        public ActionResult Create()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_CREATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;

            this.prepareLookup();
            var oModel = new ProductnewVM();
            return View(oModel);
        }
        public ActionResult Edit(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_UPDATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.UPDATE;
            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }

            this.prepareLookup();
            return View(this.oData);
        }
        public ActionResult Delete(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DELETE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.DELETE;
            this.oData = oDS.getData(id);
            if (this.oData == null) { return HttpNotFound(); }

            this.prepareLookup();
            return View(this.oData);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End public partial class ProductnewController : Controller
} //End namespace APPBASE.Controllers
