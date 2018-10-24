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
    public partial class UserController : Controller
    {
        [HttpPost]
        public ActionResult Create(UserdetailVM poViewModel, HttpPostedFileBase FileUSER_IMG)
        {
            ViewBag.AC_MENU_ID = valMENU.HAKAKSES_USER_CREATE;

            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;

            //USERNAME=RES_CD
            //poViewModel.USERNAME = poViewModel.RES_CD;
            oVAL = new User_Validation(poViewModel);
            oVAL.Validate_Create();
            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                if (poViewModel.PASSWORD != null) { poViewModel.PASSWORD = hlpObf.randomEncrypt(poViewModel.PASSWORD); }
                oCRUD.Create(poViewModel, FileUSER_IMG);
                if (oCRUD.isERR) {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Details", new { id = oCRUD.ID });
            } //End if (ModelState.IsValid)

            return View(poViewModel);
        }
        [HttpPost]
        public ActionResult Edit(UserdetailVM poViewModel, HttpPostedFileBase FileUSER_IMG)
        {
            ViewBag.AC_MENU_ID = valMENU.HAKAKSES_USER_EDIT;

            oVAL = new User_Validation(poViewModel);
            oVAL.Validate_Edit();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                if (poViewModel.PASSWORD != null) { poViewModel.PASSWORD = hlpObf.randomEncrypt(poViewModel.PASSWORD); }
                oCRUD.Update(poViewModel, FileUSER_IMG);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Details", new { id = oCRUD.ID });
            }
            return View(poViewModel);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            ViewBag.AC_MENU_ID = valMENU.HAKAKSES_USER_DELETE;

            oCRUD.Delete(id);

            if (oCRUD.isERR)
            {
                TempData["ERRMSG"] = oCRUD.ERRMSG;
                return RedirectToAction("ErrorSYS", "Error");
            } //End if (!oCRUD.isERR) {

            TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Changepassword(UserdetailVM poViewModel)
        {
            //ViewBag.AC_MENU_ID = valMENU.HAKAKSES_USER_EDIT;
            ViewBag.PREV_URL = poViewModel.PREV_URL;
            var oDatatemp = oDS.getData(hlpConfig.SessionInfo.getAppUserId());
            poViewModel.PASSWORD_OLD = oDatatemp.PASSWORD;

            oVAL = new User_Validation(poViewModel);
            oVAL.Validate_Changepassword();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                if (poViewModel.PASSWORD_NEW1 != null) { poViewModel.PASSWORD_NEW1 = hlpObf.randomEncrypt(poViewModel.PASSWORD_NEW1); }
                oCRUD.Changepassword(poViewModel);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return Redirect(poViewModel.PREV_URL);
                //return RedirectToAction("Details", new { id = oCRUD.ID });
            }
            return View(poViewModel);
        }

    } //End public partial class UsercparController : Controller
} //End namespace APPBASE.Controllers