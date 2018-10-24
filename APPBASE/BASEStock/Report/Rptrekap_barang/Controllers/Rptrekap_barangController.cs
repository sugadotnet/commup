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
    public partial class Rptrekap_barangController : Controller
    {
        //DBContext
        protected DBMAINContext db = new DBMAINContext();
        //DATA
        protected Rptrekap_barangVM oData;
        protected List<Balance_trnVM> oDataBalance_list;
        //DS
        protected Rptrekap_barangDS oDS;
        protected Balance_trnDS oDSBalance;
        protected MonthDS oDSMonth;
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
            this.oDS = new Rptrekap_barangDS(this.db);
            this.oDSBalance = new Balance_trnDS(this.db);
            this.oDSMonth = new MonthDS(this.db);
            //CRUD
            //BL
            //MAP
        } //End initConstructor
        //Constructor 1
        public Rptrekap_barangController()
        {
            //DBContext
            this.initConstructor(new DBMAINContext());
        } //End Constructor 1
        //Constructor 2
        public Rptrekap_barangController(DBMAINContext poDB)
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
        } //End prepareLookupFilter()


        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            //this.oData_list = oDS.getDatalist();
            this.prepareLookupFilter();
            this.oData = new Rptrekap_barangVM();
            this.oData.TRN_MONTH = DateTime.Now.Month;
            this.oData.TRN_YEAR = DateTime.Now.Year;
            return View(this.oData);
        }
        [HttpPost]
        public ActionResult Index(Rptrekap_barangVM poViewModel)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData = poViewModel;
            this.oDataBalance_list = this.oDSBalance.getDatalist_until(null, this.oData.TRN_YEAR, this.oData.TRN_MONTH);
            this.oData.DETAIL = this.oDS.getResult(oDataBalance_list);
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
            this.oData = (Rptrekap_barangVM)TempData["oData"];
            return View(this.oData);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End Controller
} //End namespace
