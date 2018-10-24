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
    public partial class ProductnewController : Controller
    {
        protected ProductnewVM prepareBarcode(ProductnewVM poViewModel) {
            ProductnewVM oViewModel = poViewModel;
            //Set Barcode
            if (oViewModel.COUNTRY_ID != null)
                oViewModel.COUNTRY_CODE = this.oDSCountrycode.getData(oViewModel.COUNTRY_ID).COUNTRY_CODE;
            if (oViewModel.VENDOR_ID != null)
                oViewModel.VENDOR_CODE = this.oDSVendor.getData(oViewModel.VENDOR_ID).VENDOR_CODE;
            if (oViewModel.PRODTYPE_ID != null)
                oViewModel.PRODTYPE_CODE = this.oDSProdtype.getData(oViewModel.PRODTYPE_ID).PRODTYPE_CODE;
            if (oViewModel.PRODSUBTYPE_ID != null)
                oViewModel.PRODSUBTYPE_CODE = this.oDSProdsubtype.getData(oViewModel.PRODSUBTYPE_ID).PRODSUBTYPE_CODE;
            if (oViewModel.SERIAL_ID != null)
                oViewModel.SERIAL_CODE = this.oDSSerial.getData(oViewModel.SERIAL_ID).SERIAL_CODE;
            if (oViewModel.FINISHING_ID != null)
                oViewModel.FINISHING_CODE = this.oDSFinishing.getData(oViewModel.FINISHING_ID).FINISHING_CODE;
            if (oViewModel.UKURAN_ID != null)
                oViewModel.UKURAN_CODE = this.oDSUkuran.getData(oViewModel.UKURAN_ID).UKURAN_CODE;
            return oViewModel;
        }
        [HttpPost]
        public ActionResult Create(ProductnewVM poViewModel, HttpPostedFileBase FilePRODNEW_IMAGE)
        {

            ProductnewVM oViewModel = poViewModel;
            oVAL = new Productnew_Validation(oViewModel);
            oVAL.Validate_barcode();
            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            if (ModelState.IsValid) {
                //Prepare barcode
                oViewModel = this.prepareBarcode(oViewModel);
                //Set Barcode
                using (var oTemp = new Barcode_13chars(oViewModel)) { oViewModel.PRODNEW_CODE = oTemp.getResult(); }
            } //end if


            oVAL.Validate_Create();
            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                //Set Price Base
                oViewModel.PRODNEW_PRICE_BASE = hlpConvertionAndFormating.ConvertStringToDecimal(oViewModel.PRODNEW_PRICE_BASE_S);
                //Set Price Sell same as Price Base
                oViewModel.PRODNEW_PRICE_SELL = oViewModel.PRODNEW_PRICE_BASE;
                //Run CRUD
                oCRUD.Create(oViewModel, FilePRODNEW_IMAGE);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Details", new { id = oCRUD.ID });

            } //End if (ModelState.IsValid)

            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;
            this.prepareLookup();
            return View(oViewModel);
        }
        [HttpPost]
        public ActionResult Edit(ProductnewVM poViewModel, HttpPostedFileBase FilePRODNEW_IMAGE)
        {
            ProductnewVM oViewModel = poViewModel;
            oVAL = new Productnew_Validation(oViewModel);
            oVAL.Validate_barcode();
            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            if (ModelState.IsValid)
            {
                //Prepare barcode
                oViewModel = this.prepareBarcode(oViewModel);
                //Set Barcode
                using (var oTemp = new Barcode_13chars(oViewModel)) { oViewModel.PRODNEW_CODE = oTemp.getResult(); }
            } //end if


            oVAL.Validate_Edit();
            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            if (ModelState.IsValid)
            {
                //Set Price Base
                oViewModel.PRODNEW_PRICE_BASE = hlpConvertionAndFormating.ConvertStringToDecimal(oViewModel.PRODNEW_PRICE_BASE_S);
                //Set Price Sell same as Price Base
                oViewModel.PRODNEW_PRICE_SELL = oViewModel.PRODNEW_PRICE_BASE;
                //Run CRUD
                oCRUD.Update(oViewModel, FilePRODNEW_IMAGE);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Details", new { id = oCRUD.ID });
            }

            this.prepareLookup();
            return View(oViewModel);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            oCRUD.Delete(id);

            if (oCRUD.isERR)
            {
                TempData["ERRMSG"] = oCRUD.ERRMSG;
                return RedirectToAction("ErrorSYS", "Error");
            } //End if (!oCRUD.isERR) {

            TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
            return RedirectToAction("Index");
        }
    } //End public partial class ProductnewController : Controller
} //End namespace APPBASE.Controllers
