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
    public partial class Rptrekap_sellController : Controller
    {
        //DBContext
        protected DBMAINContext db = new DBMAINContext();
        //DATA
        protected Rptrekap_sellVM oData;
        protected List<Balance_trnsellVM> oDataBalance_list;
        protected List<Balance_trnsellVM> oDataBeginBalance_list;
        protected List<Balance_trnsellVM> oDataCurrentBalance_list;
        //DS
        protected Rptrekap_sellDS oDS;
        protected Balance_trnsellDS oDSBalance;
        protected MonthDS oDSMonth;
        protected StorageDS oDSStorage;
        protected ProdtypeDS oDSProdtype;
        //CRUD
        //VALIDATION
        //BL
        //MAP
        //Init
        private void initConstructor(DBMAINContext poDB)
        {
            //DBContext
            this.db = poDB;
            //DS
            this.oDS = new Rptrekap_sellDS(this.db);
            this.oDSBalance = new Balance_trnsellDS(this.db);
            this.oDSMonth = new MonthDS(this.db);
            this.oDSStorage = new StorageDS(this.db);
            this.oDSProdtype = new ProdtypeDS();
            //CRUD
            //BL
            //MAP
        } //End initConstructor
        //Constructor 1
        public Rptrekap_sellController()
        {
            //DBContext
            this.initConstructor(new DBMAINContext());
        } //End Constructor 1
        //Constructor 2
        public Rptrekap_sellController(DBMAINContext poDB)
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
            ViewBag.MONTH = oDSMonth.getDatalist_lookup();
            ViewBag.STORAGE = oDSStorage.getDatalist();
            ViewBag.PRODTYPE = oDSProdtype.getDatalist();
        } //End prepareLookupFilter()


        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            //this.oData_list = oDS.getDatalist();
            this.prepareLookupFilter();
            this.oData = new Rptrekap_sellVM();
            DateTime dToday = DateTime.Today.Date;

            this.oData.FILTER_TYPE = 1;
            this.oData.TRNFROM_DT = dToday.Date;
            this.oData.TRNTO_DT = dToday.Date;
            this.oData.TRN_MONTH = dToday.Month;
            this.oData.TRN_YEAR = dToday.Year;

            return View(this.oData);
        }
        [HttpPost]
        public ActionResult Index(Rptrekap_sellVM poViewModel)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData = poViewModel;
            //Init Begin Period
            string sBeginDate = "";
            DateTime dBeginDate;
            string sBeginYear = "";
            string sBeginMonth = "";
            int? nBeginYearmonth = null;
            //Init Current Period
            string sYear = "";
            string sMonth = "";
            int? nYearmonth = null;
            //Construct Filter
            //Init Balance
            if (this.oData.FILTER_TYPE == 1) {
                this.oDataBalance_list = this.oDSBalance.getDatalist_fromtodate(null, this.oData.TRNFROM_DT, this.oData.TRNTO_DT);
            } //end if
            if (this.oData.FILTER_TYPE == 2) {
                this.oDataBalance_list = this.oDSBalance.getDatalist_current(null, this.oData.TRN_YEAR, this.oData.TRN_MONTH);
            } //end if
            this.oDataBalance_list = this.oDSBalance.getDatalist_morefilter(this.oDataBalance_list, this.oData.PRODTYPE_ID, this.oData.TOPDATA);
            //Result
            this.oData.DETAIL = this.oDS.getResult(this.oData.STORAGE_ID, oDataBeginBalance_list, oDataCurrentBalance_list, oDataBalance_list);
            if ((poViewModel.ACTION_TYPE == 1) && (this.oData.DETAIL != null))
            {
                if (this.oData.DETAIL.Count > 0) {
                    TempData["oData"] = this.oData;
                    return RedirectToAction("Reportprint");
                } //end if
            } //end if

            this.prepareLookupFilter();
            return View(this.oData);
        }
        public ActionResult Reportprint()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData = (Rptrekap_sellVM)TempData["oData"];
            return View(this.oData);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End Controller
} //End namespace
