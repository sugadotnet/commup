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
    public partial class TrnstockrevController : TrnstockController
    {
        protected override Boolean _Index_post(ProductstockVM poViewModel)
        {
            ProductstockVM oViewModel = poViewModel;
            oVAL = new Trnstock_Validation(oViewModel);
            oVAL.Validate_Index();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                if (oViewModel.LIST_INDEX != null)
                {
                    if (oViewModel.LIST_INDEX.Count > 0)
                    {
                        oViewModel.LIST_INDEX.RemoveAll(fld => fld.ID == null);
                        Session[SESSION_PRODUCTSTOCK] = oViewModel;
                        return true;
                    } //End if
                } //End if
            } //end if

            return false;
        }
        [HttpPost]
        public override ActionResult Index(ProductstockVM poViewModel)
        {
            if (this._Index_post(poViewModel)) return RedirectToAction("Create");
            //return View("~/Views/Trnstock/Index.cshtml", poViewModel);
            return View(View_index, oVMProductstok);
        }
    } //End class
} //End namespace
