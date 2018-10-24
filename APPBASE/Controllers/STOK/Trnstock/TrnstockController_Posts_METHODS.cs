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
    public partial class TrnstockController : Controller
    {
        protected virtual Boolean _Index_post(ProductstockVM poViewModel)
        {
            ProductstockVM oViewModel = poViewModel;
            oVAL = new Trnstock_Validation(oViewModel);
            oVAL.Validate_Index();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)

            if (ModelState.IsValid) {
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
        protected virtual Boolean _Create_post(TrnstockVM poViewModel)
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
            //oVAL = new Trnstock_Validation(oViewModel);
            oVAL = new Trnstock_Validation(oViewModel, this.oDataproductstock_list);
            oVAL.Validate_Create();

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
                this.oBL.Init();
                //1-Inject DATA 1-Trnstock (oViewModel)
                this.oBL.TRNSTOCK = oViewModel; //this.oBL.inject_TRNSTOCK(oViewModel);
                //1-Inject DATA 2-Trnstockd (oViewModel.LISTITEM)
                this.oBL.TRNSTOCKDS = oViewModel.LISTITEM; //this.oBL.inject_TRNSTOCKDS(oViewModel.LISTITEM);
                //1-Inject DATA 3-Products
                this.oBL.PRODUCTS = oDSProduct.getDatalist(); //this.oBL.inject_PRODUCTS(oDSProduct.getDatalist());
                //1-Inject DATA 4-Productstocks
                this.oBL.PRODUCTSTOCKS = oDSProductstock.getDatalist(); //End this.oBL.inject_PRODUCTSTOCKS(oDSProductstock.getDatalist());
                //2-Inject CRUD 1
                this.oBL.CRUD = this.oCRUD;
                //2-Inject CRUD 2
                this.oBL.CRUDDetail = this.oCRUDDetail;
                //2-Inject CRUD 3
                this.oBL.CRUDProductstock = this.oCRUDProductstock;
                //3-Process
                this.oBL.Process();
                //5-Save Mutasi
                if (!this.oBL.Save()) return false;
                //5-Commit Mutasi
                this.oBL.Commit();

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
    } //End public partial class TrnstockdisplayController : Controller
} //End namespace APPBASE.Controllers
