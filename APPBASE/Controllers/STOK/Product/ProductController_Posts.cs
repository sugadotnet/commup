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
    public partial class ProductController : Controller
    {
        [HttpPost]
        public ActionResult Create(ProductVM poViewModel)
        {

            oVAL = new Product_Validation(poViewModel);
            oVAL.Validate_Create();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                oCRUD.Create(poViewModel);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Details", new { id = oCRUD.ID });

            } //End if (ModelState.IsValid)

            return View(poViewModel);
        }
        [HttpPost]
        public ActionResult Edit(ProductVM poViewModel)
        {
            oVAL = new Product_Validation(poViewModel);
            oVAL.Validate_Edit();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                oCRUD.Update(poViewModel);
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
        [HttpPost]
        public ActionResult Edit_pricelist(ProductVM poViewModel)
        {
            ProductVM oViewModel = oDS.getData(poViewModel.ID);
            oViewModel.PROD_PRICE_BASE = hlpConvertionAndFormating.ConvertStringToDecimal(poViewModel.PROD_PRICE_BASE_S);
            oViewModel.PROD_PRICEDT = poViewModel.PROD_PRICEDT;

            oVAL = new Product_Validation(oViewModel);
            oVAL.Validate_Edit();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                oCRUD.Update(oViewModel);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Index");
            }
            return View(poViewModel);
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


        protected TrnstockVM setTransaction_vm(ProductVM poViewModel) {
            TrnstockVM vReturn = new TrnstockVM();


            return vReturn;
        } //end method
        [HttpPost]
        public ActionResult Indexvalidasi(ProductnewVM poViewModel)
        {
            if (hlpConfig.SessionInfo.getAppRoleId() != valFLAG.FLAG_ROLE_ADM) return RedirectToAction("Error403", "Error");
            ProductVM oViewModel = new ProductVM();
            ProductstockVM oViewModel_Productstock = new ProductstockVM();

            var oData = oDSProductnew.getData(poViewModel.ID);
            oViewModel.InjectFrom_Productnew(oData);

            oVAL = new Product_Validation(oViewModel);
            oVAL.Validate_Createbulk();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
                
                //foreach (var item in ModelState)
                //{
                //    item.Value.ToString()
                //}
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                //Insert data produk
                oCRUD.Create(oViewModel);
                if (oCRUD.isERR)
                {
                    TempData["ERRMSG"] = oCRUD.ERRMSG;
                    return RedirectToAction("ErrorSYS", "Error");
                } //End if (!oCRUD.isERR) {

                //Insert data produkstok
                oViewModel.ID = oCRUD.ID;
                oViewModel_Productstock.InjectFrom_many(oData, oViewModel);
                oCRUDProductstock.Create(oViewModel_Productstock);
                //Insert Transaction
                /*>>>>> TRN HEADER,DETAIL DAN STOCK [oBL] <<<<< */
                //0-Initialize
                TrnstockVM oViewModel_trn = this.setTransaction_vm(oViewModel);
                this.oBL.Init();
                //1-Inject DATA Vendor
                this.oBL.VENDOR = oDSVendor.getData(oData.VENDOR_ID);
                //1-Inject DATA Storage
                this.oBL.STORAGE = oDSStorage.getData(oData.STORAGE_ID);
                //1-Inject DATA Product (oViewModel)
                this.oBL.PRODUCTNEW = oData;
                //1-Inject DATA Product
                this.oBL.PRODUCT = oDSProduct.getData(oViewModel.ID);
                //1-Inject DATA Products
                this.oBL.PRODUCTS = oDSProduct.getDatalist();
                //1-Inject DATA Productstock
                this.oBL.PRODUCTSTOCK = oDSProductstock.getData(oCRUDProductstock.ID);
                //1-Inject DATA Productstocks
                this.oBL.PRODUCTSTOCKS = oDSProductstock.getDatalist();
                //2-Inject CRUD 1
                this.oBL.CRUD = this.oCRUD_trn;
                //2-Inject CRUD 2
                this.oBL.CRUDDetail = this.oCRUDDetail_trn;
                //2-Inject CRUD 3
                this.oBL.CRUDProductstock = this.oCRUDProductstock;
                //3-Process
                this.oBL.Process();
                //5-Save Mutasi
                if (!this.oBL.Save()) //if (!this.oBL.Save()) return false;
                //5-Commit Mutasi
                this.oBL.Commit();


                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                //return RedirectToAction("Details", new { id = oCRUD.ID });
                return RedirectToAction("Indexvalidasi");
            } //End if (ModelState.IsValid)

            ViewBag.ID = poViewModel.ID;
            ViewBag.CRUDSavedOrDeleteFaield = valFLAG.FLAG_TRUE;
            var oData2 = oDSProductnew.getDatalist_validate();
            return View(oData2);
        }
    } //End public partial class ProductController : Controller
} //End namespace APPBASE.Controllers
