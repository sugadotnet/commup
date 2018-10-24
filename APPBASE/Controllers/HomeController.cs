using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Filters;
using APPBASE.Svcbiz;

namespace APPBASE.Controllers
{
    [MyActionFilterAttribute]
    public class HomeController : Controller
    {
        private DBMAINContext db;
        protected ProductnewDS oDSProductnew;
        protected ProductstockDS oDSProductstock;
        protected TrnstockdDS oDSTrnstockd;
        //DATA
        protected List<ProductnewVM> oData_productnew;
        protected List<ProductstockVM> oData_productstock;
        protected List<TrnstockdVM> oData_trnstockd;
        protected DashboardVM oData_dashboard;

        protected void Initialize() {
            this.oDSProductnew = new ProductnewDS();
            this.oDSProductstock = new ProductstockDS(this.db);
            this.oDSTrnstockd = new TrnstockdDS(this.db);
        }

        //Constructor 1
        public HomeController() {
            this.db = new DBMAINContext();
            this.Initialize();
        }
        //Constructor 2
        public HomeController(DBMAINContext poDB)
        {
            this.db = poDB;
            this.Initialize();
        }


        protected void Index_getdata(DashboardVM poViewModel=null) {
            this.oData_productnew = this.oDSProductnew.getDatalist_validate();
            this.oData_productstock = this.oDSProductstock.getDatalist(oDSProductstock.FIELD_INDEX);
            this.oData_trnstockd = this.oDSTrnstockd.getDatalist(oDSTrnstockd.FIELD_SUMQTY);

            int? nYEAR = DateTime.Today.Year;
            int? nPRODVAL_NEW = 0;
            int? nPRODVAL_STOCK = 0;
            int? nPRODSTOCK_DISPLAY = 0;
            int? nPRODSTOCK_GUDANGA = 0;
            int? nPRODSTOCK_GUDANGB = 0;
            int? nPRODSELL = 0;
            if (this.oData_productnew != null) {
                nPRODVAL_NEW = this.oData_productnew.Sum(fld => fld.PRODNEW_QTY);
                nPRODVAL_STOCK = 0;
            } //end if
            if (oData_productstock != null) {
                nPRODSTOCK_DISPLAY = this.oData_productstock.Where(fld => fld.STORAGE_ID == valFLAG.STORAGE_ID_DISPLAY).Sum(fld => fld.STOCK_QTY);
                nPRODSTOCK_GUDANGA = this.oData_productstock.Where(fld => fld.STORAGE_ID == valFLAG.STORAGE_ID_GATAS).Sum(fld => fld.STOCK_QTY);
                nPRODSTOCK_GUDANGB = this.oData_productstock.Where(fld => fld.STORAGE_ID == valFLAG.STORAGE_ID_GBAWAH).Sum(fld => fld.STOCK_QTY);
            } //end if
            if (this.oData_trnstockd != null) {
                if (poViewModel != null) nYEAR = poViewModel.PRODSELL_YEAR;
                nPRODSELL = this.oData_trnstockd.Where(fld => fld.TRN_TYPEID == valFLAG.TRN_TYPEID_SELL &&
                             fld.TRN_DT.Value.Year == nYEAR)
                            .Sum(fld => fld.TRND_QTY);
            } //end if
            this.oData_dashboard = new DashboardVM {
                PRODVAL_NEW = nPRODVAL_NEW,
                PRODVAL_STOCK = nPRODVAL_STOCK,
                PRODVAL_YEAR = nYEAR,
                PRODSTOCK_DISPLAY = nPRODSTOCK_DISPLAY,
                PRODSTOCK_GUDANGA = nPRODSTOCK_GUDANGA,
                PRODSTOCK_GUDANGB = nPRODSTOCK_GUDANGB,
                PRODSTOCK_YEAR = nYEAR,
                PRODSELL = nPRODSELL,
                PRODSELL_YEAR = nYEAR
            };

            //var oTes = this.oData_trnstockd.Select(x => new { YEAR = x.TRN_DT.Value.Year }).GroupBy(x => x.YEAR).ToList();
            //var oTes = this.oData_trnstockd.Select(x => new { YEAR = x.TRN_DT.Value.Year }).ToList();
            var oTes = this.oData_trnstockd.GroupBy(x => new { ID = x.TRN_DT.Value.Year, YEAR_SHORTDESC = x.TRN_DT.Value.Year })
                .Select(y => new { ID = y.Key.ID, YEAR_SHORTDESC = y.Key.YEAR_SHORTDESC }).ToList();
            this.oData_dashboard.PRODSELL_YEAR_LIST = new List<int?>();

            foreach (var item in oTes)
            {
                this.oData_dashboard.PRODSELL_YEAR_LIST.Add(item.ID);
            } //end loop

            var oTeslist = this.oData_dashboard.PRODSELL_YEAR_LIST;
        }
        public ActionResult Index()
        {
            this.Index_getdata();
            return View(this.oData_dashboard);
        }
        [HttpPost]
        public ActionResult Index(DashboardVM poViewModel)
        {
            this.Index_getdata(poViewModel);
            return View(this.oData_dashboard);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    } //End public class HomeController : Controller
} //End namespace APPBASE.Controllers
