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
    public partial class FinishingController : Controller
    {
        private DBMAINContext db = new DBMAINContext();
        private FinishingDS oDS = new FinishingDS();
        private FinishingCRUD oCRUD = new FinishingCRUD();
        private Finishing_Validation oVAL;
        //DATA
        private Select2VM oDataLookup;
        private Select2_detailVM oDataLookup_detail;
        //PRODTYPE
        private ProdtypeDS oDSProdtype = new ProdtypeDS();

        public void prepareLookup()
        {
            ViewBag.PRODTYPE = oDSProdtype.getDatalist_lookup();
        } //End prepareLookup()
        public void prepareLookupFilter()
        {
            ViewBag.PRODTYPE = oDSProdtype.getDatalist_lookup();
        } //End prepareLookupFilter()

        public ActionResult Index()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            var oData = oDS.getDatalist();
            prepareLookup();
            return View(oData);
        }
        public JsonResult Index_json(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_INDEX;
            var oData = oDS.getDatalist(id);
            this.oDataLookup = new Select2VM();
            this.oDataLookup.results = new List<Select2_detailVM>();
            this.oDataLookup.results.Add(new Select2_detailVM { id = -1, text = "" });
            foreach (var item in oData)
            {
                this.oDataLookup.results.Add(new Select2_detailVM { id = item.ID, text = item.FINISHING_NAME });
            } //end loop
            return Json(this.oDataLookup.results, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Details(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DETAILS;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.VIEW;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            prepareLookup();
            return View(oData);
        }
        public ActionResult Create()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_CREATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;
            prepareLookup();
            return View(new FinishingVM());
        }
        public ActionResult Edit(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_UPDATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.UPDATE;
            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            prepareLookup();
            return View(oData);
        }
        public ActionResult Delete(int? id = null)
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_DELETE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.DELETE;
            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            prepareLookup();
            return View(oData);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    } //End public partial class FinishingController : Controller
} //End namespace APPBASE.Controllers
