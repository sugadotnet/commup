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
    public partial class RptsellController : Controller
    {
        //DBContext
        private DBMAINContext db = new DBMAINContext();
        //VM
        private Summary_sellVM oVM;
        //DATA
        private Summary_sellVM oData;
        private List<Summary_sellVM> oData_list;
        private ReportsellVM oData_report;
        protected TrnstockdVM oData_transaction;
        protected List<TrnstockdVM> oData_transaction_list;
        //DS
        private Summary_sellDS oDS;
        protected TrnstockDS oDSTrnstock;
        protected TrnstockdDS oDSTrnstockd;
        //CRUD
        //private ProductCRUD oCRUD;
        //VALIDATION
        private Summary_sell_Validation oVAL;
        //BL
        //MAP


        //Init
        private void initConstructor(DBMAINContext poDB)
        {
            //DBContext
            this.db = poDB;
            //VM
            this.oVM = new Summary_sellVM();
            //DS
            this.oDS = new Summary_sellDS(this.db);
            this.oDSTrnstock = new TrnstockDS(this.db);
            this.oDSTrnstockd = new TrnstockdDS(this.db);
            //CRUD
            //this.oCRUD = new ProductCRUD();

            //BL
            //MAP
        } //End initConstructor
        //Constructor 1
        public RptsellController()
        {
            //DBContext
            this.initConstructor(new DBMAINContext());
        } //End Constructor 1
        //Constructor 2
        public RptsellController(DBMAINContext poDB)
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


        protected void Index_getdata(ReportsellVM poViewModel=null) {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            int? nYEAR = DateTime.Today.Year;
            if (poViewModel != null) nYEAR = poViewModel.TRN_YEAR;

            this.oData_report = new ReportsellVM();
            this.oData_report.YEAR_LIST = new List<int?>();
            //Init List Tahun
            var oDETAIL = oDS.getDatalist();
            if (oDETAIL != null)
            {
                var oYEARLIST = oDETAIL.GroupBy(x => new { ID = x.TRN_YEAR, YEAR_SHORTDESC = x.TRN_YEAR })
                    .Select(y => new { ID = y.Key.ID, YEAR_SHORTDESC = y.Key.YEAR_SHORTDESC })
                    .OrderBy(x => x.ID)
                    .ToList();
                foreach (var item in oYEARLIST)
                {
                    if (poViewModel==null) nYEAR = item.ID;
                    this.oData_report.YEAR_LIST.Add(item.ID);
                } //end loop
            } //end if
            //Detail penjualan
            this.oData_report.TRN_YEAR = nYEAR;
            this.oData_report.DETAIL = oDS.getDatalist_byYear(this.oData_report.TRN_YEAR);
            //Set chart
            this.oData_report = this.setAmount(this.oData_report);
            this.oData_report = this.setTotal(this.oData_report);
        }
        public ActionResult Index()
        {
            this.Index_getdata();
            return View(this.oData_report);
        }
        [HttpPost]
        public virtual ActionResult Index(ReportsellVM poViewModel)
        {
            this.Index_getdata(poViewModel);
            return View(this.oData_report);
        }

        public ActionResult Index_print()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            this.oData_list = oDS.getDatalist();
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


        public ActionResult Rincian(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;

            int? nYEAR = DateTime.Today.Year;
            if (id != null) nYEAR = id;
            this.oData_transaction_list = this.oDSTrnstockd.getDatalist();
            this.oData_transaction_list = this.oData_transaction_list.Where(fld => fld.TRN_DT.Value.Year == nYEAR &&
                fld.TRN_TYPEID == valFLAG.TRN_TYPEID_SELL).ToList();
            decimal? nTRND_AMOUNT = this.oData_transaction_list.Sum(fld => fld.TRND_AMOUNT);
            ViewBag.SUM_AMOUNT = hlpConvertionAndFormating.ConvertDecimalToStringFmtThousand(nTRND_AMOUNT);
            if (this.oData_transaction_list != null) this.oData_transaction_list = this.oData_transaction_list
                  .OrderByDescending(fld => fld.TRN_DT).ToList();
            return View(this.oData_transaction_list);
        }

        private ReportsellVM setAmount(ReportsellVM poData)
        {
            ReportsellVM vReturn = poData;
            vReturn.DETAIL_CHART = new List<chartVM>();
            for (int i = 0; i < 13; i++)
            {
                chartVM oVM = new chartVM();
                oVM.AMT = 0; oVM.QTY = 0;
                vReturn.DETAIL_CHART.Add(oVM);
                if (i > 0)
                {
                    if (poData.DETAIL.Where(fld => fld.TRN_MONTH == i).FirstOrDefault() != null) {
                        vReturn.DETAIL_CHART[i].AMT = poData.DETAIL
                            .Where(fld => fld.TRN_MONTH == i && fld.TRN_YEAR == poData.TRN_YEAR)
                            .FirstOrDefault().TRND_AMOUNT;
                        vReturn.DETAIL_CHART[i].QTY = poData.DETAIL
                            .Where(fld => fld.TRN_MONTH == i && fld.TRN_YEAR == poData.TRN_YEAR)
                            .FirstOrDefault().TRND_QTY;
                        
                        if (vReturn.DETAIL_CHART[i].AMT == null) vReturn.DETAIL_CHART[i].AMT = 0;
                        if (vReturn.DETAIL_CHART[i].QTY == null) vReturn.DETAIL_CHART[i].QTY = 0;
                    } //End if
                } //End if
            } //End for

            //Return
            return vReturn;
        } //end method
        private ReportsellVM setTotal(ReportsellVM poData)
        {
            ReportsellVM vReturn = poData;
            vReturn.TOTAL_AMOUNT = poData.DETAIL.Sum(f => f.TRND_AMOUNT);
            vReturn.TOTAL_QTY = poData.DETAIL.Sum(f => f.TRND_QTY);
            //Return
            return vReturn;
        } //end method
        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End Controller
} //End namespace
