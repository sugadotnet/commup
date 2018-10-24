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
        protected override Boolean _Create_post(TrnstockVM poViewModel)
        {
            TrnstockVM oViewModel = poViewModel;
            oViewModel.TRN_GIVER = hlpConfig.SessionInfo.getAppUsername();
            //oViewModel.LISTITEM = new List<TrnstockdVM>();
            for (int i = 0; i < poViewModel.LISTITEM.Count; i++)
            {
                oViewModel.LISTITEM[i].TRND_PRICE = hlpConvertionAndFormating.ConvertStringToDecimal(oViewModel.LISTITEM[i].TRND_PRICE_S);
                oViewModel.LISTITEM[i].TRND_DISCRATE = hlpConvertionAndFormating.ConvertStringToDecimal(oViewModel.LISTITEM[i].TRND_DISCRATE_S);
            } //End for

            this.oDataproductstock_list = oDSProductstock.getDatalist();
            if (this.oDataproductstock_list != null)
            {
                this.oDataproductstock_list =
                    this.oDataproductstock_list
                    .Where(fld => fld.STORAGE_ID == this.STOCKSTORAGE_ID).ToList();
            } //end if
            oVAL = new Trnstock_Validation(oViewModel, this.oDataproductstock_list);
            if (this.TRN_TYPEID == valFLAG.TRN_TYPEID_REVADD) {
                oVAL.Validate_Create_revadd();
            } //end if
            if (this.TRN_TYPEID == valFLAG.TRN_TYPEID_REVSUB)
            {
                oVAL.Validate_Create_revsub();
            } //end if
            

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid)
            {
                /*>>>>> AUTOGENERATE NUMBER [oBLIDMutasi] <<<<< */
                //0-Initialize
                this.oBLIDMutasi.Init(oViewModel.TRN_CODE);
                //1-Inject 1
                this.oBLIDMutasi.inject_IDMUTASI(oDSIdmutasi.getData_byYearAndMonth(DateTime.Now));
                //1-Inject 2
                this.oBLIDMutasi.inject_IdmutasiCRUD(this.oCRUDIdmutasi);
                //2-Process
                this.oBLIDMutasi.Process();
                oViewModel.TRN_CODE = oBLIDMutasi.ID;

                /*>>>>> TRN HEADER,DETAIL DAN STOCK [oBL] <<<<< */
                //0-Initialize
                this.oBLMutasi_revadd.Init();
                
                //1-Inject DATA Trnstock (oViewModel)
                this.oBLMutasi_revadd.TRNSTOCK = oViewModel;
                //1-Inject DATA Trnstockd (oViewModel.LISTITEM)
                this.oBLMutasi_revadd.TRNSTOCKDS = oViewModel.LISTITEM;
                //1-Inject DATA Products
                this.oBLMutasi_revadd.PRODUCTS = oDSProduct.getDatalist();
                //1-Inject DATA Productstocks
                this.oBLMutasi_revadd.PRODUCTSTOCKS = oDSProductstock.getDatalist();
                //1-Inject DATA Storage
                this.oBLMutasi_revadd.STORAGE = oDSStorage.getData(this.STORAGE_REVTARGETID);

                //2-Inject CRUD 1
                this.oBLMutasi_revadd.CRUD = this.oCRUD;
                //2-Inject CRUD 2
                this.oBLMutasi_revadd.CRUDDetail = this.oCRUDDetail;
                //2-Inject CRUD 3
                this.oBLMutasi_revadd.CRUDProductstock = this.oCRUDProductstock;
                //3-Process
                this.oBLMutasi_revadd.Process();
                //5-Save Mutasi
                if (!this.oBLMutasi_revadd.Save()) return false;
                //5-Commit Mutasi
                this.oBLMutasi_revadd.Commit();

                /*>>>>> AUTOGENERATE NUMBER [oBLIDMutasi] <<<<< */
                //3-Save
                this.oBLIDMutasi.Save();
                //4-Commit
                this.oBLIDMutasi.Commit();
                //Return
                return true;
            } //End if (ModelState.IsValid)

            //Prepare
            this.prepareLookup();
            //Return
            return false;
        }
        [HttpPost]
        public override ActionResult Create(TrnstockVM poViewModel)
        {
            //If Process Success
            if (this._Create_post(poViewModel))
            {
                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Reportprint", new { id = oBLMutasi_revadd.CRUD.ID });
            } //End if (!oCRUD.isERR)
            //If Error on CRUD Operation
            if (oCRUD.ERRMSG != "")
            {
                TempData["ERRMSG"] = oCRUD.ERRMSG;
                return RedirectToAction("ErrorSYS", "Error");
            } //End if
            this.prepareLookup();

            return View("~/Views/Trnstockrev/Create.cshtml", poViewModel);
        }
    } //End class
} //End namespace
