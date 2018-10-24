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
    public partial class EmployeeController : Controller
    {
        private DBMAINContext db = new DBMAINContext();
        private EmployeeDS oDS = new EmployeeDS();
        private EmployeeCRUD oCRUD = new EmployeeCRUD();
        private Employee_Validation oVAL;
        //DS LOV
        private GenderDS oDSGender = new GenderDS();
        private MaritalDS oDSMarital = new MaritalDS();
        private ReligionDS oDSReligion = new ReligionDS();
        private CityDS oDSCity = new CityDS();
        private EmplstsDS oDSEmplsts = new EmplstsDS();
        private JobtitleDS oDSJobtitle = new JobtitleDS();
        private EducationDS oDSEducation = new EducationDS();
        private BranchallDS oDSBranchallDS = new BranchallDS();
        private EmpmutationstsDS oDSEmpmutationsts = new EmpmutationstsDS();


        public void prepareLookup()
        {
            ViewBag.GENDER = oDSGender.getDatalist_lookup();
            ViewBag.MARITAL = oDSMarital.getDatalist_lookup();
            ViewBag.RELIGION = oDSReligion.getDatalist_lookup();
            ViewBag.CITY = oDSCity.getDatalist_lookup();
            ViewBag.EMPLSTS = oDSEmplsts.getDatalist_lookup();
            ViewBag.JOBTITLE = oDSJobtitle.getDatalist_lookup();
            ViewBag.EDUCATION = oDSEducation.getDatalist_lookup();
            ViewBag.BRANCHALL = oDSBranchallDS.getDatalist_lookup();
            ViewBag.EMPMUTATIONSTS = oDSEmpmutationsts.getDatalist_lookup();
        } //End prepareLookup()

        public ActionResult Index()
        {
            ViewBag.AC_MENU_ID = valMENU.KEPEGAWAIAN_PEGAWAI_INDEX;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];
            ViewBag.CRUDAction = TempData["CRUDAction"];

            var oData = oDS.getDatalist();
            return View(oData);
        }
        public ActionResult Details(int? id = null)
        {
            ViewBag.AC_MENU_ID = valMENU.KEPEGAWAIAN_PEGAWAI_DETAILS;

            ViewBag.CRUD_type = hlpFlags_CRUDOption.VIEW;
            ViewBag.CRUDSavedOrDelete = TempData["CRUDSavedOrDelete"];

            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            prepareLookup();
            return View(oData);
        }
        public ActionResult Create()
        {
            ViewBag.AC_MENU_ID = valMENU.KEPEGAWAIAN_PEGAWAI_CREATE;

            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;
            EmployeedetailVM oData = new EmployeedetailVM();
            prepareLookup();
            return View(oData);
        }
        public ActionResult Edit(int? id = null)
        {
            ViewBag.AC_MENU_ID = valMENU.KEPEGAWAIAN_PEGAWAI_EDIT;

            ViewBag.CRUD_type = hlpFlags_CRUDOption.UPDATE;
            var oData = oDS.getData(id);
            if (oData == null) { return HttpNotFound(); }
            prepareLookup();
            return View(oData);
        }
        public ActionResult Delete(int? id = null)
        {
            ViewBag.AC_MENU_ID = valMENU.KEPEGAWAIAN_PEGAWAI_DELETE;

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
    } //End public partial class EmployeeController : Controller
} //End namespace APPBASE.Controllers

