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
    public partial class Rptrekap_mutasiController : Controller
    {
        //DBContext
        protected DBMAINContext db = new DBMAINContext();
        //DATA
        protected Rptrekap_mutasiVM oData;
        protected List<Balance_trnVM> oDataBalance_list;
        protected List<Balance_trnVM> oDataBeginBalance_list;
        protected List<Balance_trnVM> oDataCurrentBalance_list;
        //DS
        protected Rptrekap_mutasiDS oDS;
        protected Balance_trnDS oDSBalance;
        protected MonthDS oDSMonth;
        protected StorageDS oDSStorage;
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
            this.oDS = new Rptrekap_mutasiDS(this.db);
            this.oDSBalance = new Balance_trnDS(this.db);
            this.oDSMonth = new MonthDS(this.db);
            this.oDSStorage = new StorageDS(this.db);
            //CRUD
            //BL
            //MAP
        } //End initConstructor
        //Constructor 1
        public Rptrekap_mutasiController()
        {
            //DBContext
            this.initConstructor(new DBMAINContext());
        } //End Constructor 1
        //Constructor 2
        public Rptrekap_mutasiController(DBMAINContext poDB)
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
        } //End prepareLookupFilter()


        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            //this.oData_list = oDS.getDatalist();
            this.prepareLookupFilter();
            this.oData = new Rptrekap_mutasiVM();
            this.oData.STORAGE_ID = 1;
            this.oData.TRN_MONTH = DateTime.Today.Month;
            this.oData.TRN_YEAR = DateTime.Today.Year;
            return View(this.oData);
        }
        [HttpPost]
        public ActionResult Index(Rptrekap_mutasiVM poViewModel)
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
            if ((this.oData.TRN_YEAR != null) && (this.oData.TRN_MONTH != null)) {
                //Init Balance
                this.oDataBalance_list = this.oDSBalance.getDatalist_until(null, this.oData.TRN_YEAR, this.oData.TRN_MONTH);
                //Begin Period
                sBeginDate = "01/" + this.oData.TRN_MONTH.ToString().PadLeft(2, '0') + "/" + this.oData.TRN_YEAR.ToString();
                dBeginDate = hlpConvertionAndFormating.ConvertStringToDateShort(sBeginDate).Value.AddDays(-1);
                sBeginYear = dBeginDate.Year.ToString().PadLeft(4, '0');
                sBeginMonth = dBeginDate.Month.ToString().PadLeft(2, '0');
                nBeginYearmonth = Convert.ToInt32(sBeginYear + sBeginMonth);
                //Begin Balance
                this.oDataBeginBalance_list = this.oDataBalance_list.Where(fld => fld.TRN_YEARMONTH <= nBeginYearmonth).ToList();
                //Current Period
                sYear = this.oData.TRN_YEAR.ToString().PadLeft(4, '0');
                sMonth = this.oData.TRN_MONTH.ToString().PadLeft(2, '0');
                nYearmonth = Convert.ToInt32(sYear + sMonth);
                this.oDataCurrentBalance_list = this.oDataBalance_list.Where(fld => fld.TRN_YEARMONTH == nYearmonth).ToList();
            } //end if
            //Result
            this.oData.DETAIL = this.oDS.getResult(this.oData.STORAGE_ID, oDataBeginBalance_list, oDataCurrentBalance_list, oDataBalance_list);
            if (poViewModel.ACTION_TYPE == 1) {
                TempData["oData"] = this.oData;
                return RedirectToAction("Reportprint");
            } //end if

            this.prepareLookupFilter();
            return View(this.oData);
        }
        public ActionResult Reportprint()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData = (Rptrekap_mutasiVM)TempData["oData"];
            return View(this.oData);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End Controller
} //End namespace
