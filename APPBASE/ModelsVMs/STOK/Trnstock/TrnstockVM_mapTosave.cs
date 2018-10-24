using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class TrnstockVM
    {
        public void mapToSave_Header()
        {
            this.TRN_TYPEID = valFLAG.TRN_TYPEID_MUTASI;
        } //End public void mapToSave_Header()
        public void mapToSave_Detail(List<TrnstockdVM> poViewModel, List<ProductstockVM> poViewModel_Productstock)
        {
            this.LISTITEM = new List<TrnstockdVM>();
            foreach (var item in poViewModel)
            {
                TrnstockdVM oItem = new TrnstockdVM();
                var oModel_Productstock = poViewModel_Productstock.SingleOrDefault(fld => fld.ID == item.PRODSTOCK_ID);

                item.TRN_ID = this.ID;
                //oItem.DTA_STS = null;
                //oItem.TRN_ID = this.ID;
                //oItem.TRND_QTY = null;
                //oItem.TRND_PRICE = null;
                //oItem.TRND_GROSSAMOUNT = null;
                //oItem.TRND_TAXRATE = null;
                //oItem.TRND_TAXAMOUNT = null;
                //oItem.TRND_AFTERTAXAMOUNT = null;
                //oItem.TRND_DISCRATE = null;
                //oItem.TRND_DISCAMOUNT = null;
                //oItem.TRND_AMOUNT = null;
                //oItem.TRND_DESC = null;
                
                oItem.PROD_ID = oModel_Productstock.PROD_ID;
                item.PROD_ID = oModel_Productstock.PROD_ID;

                //oItem.PRODSTOCK_ID = null;
                oItem.STORAGE_BASEID = oModel_Productstock.STORAGE_ID;
                item.STORAGE_BASEID = oModel_Productstock.STORAGE_ID;

                //oItem.STORAGE_TARGETID = null;
                
                //oItem.CACHE_PROD_CODE = oModel_Productstock.PROD_CODE;
                //oItem.CACHE_PROD_NAME = oModel_Productstock.PROD_NAME;
                item.CACHE_PROD_CODE = oModel_Productstock.PROD_CODE;
                item.CACHE_PROD_NAME = oModel_Productstock.PROD_NAME;

                //oItem.CACHE_PROD_PRICE_BASE = null;
                //oItem.CACHE_PROD_PRICE_SELL = null;
                //oItem.CACHE_PROD_PRICEDT = null;
                
                
                //this.LISTITEM.Add(oItem);
                this.LISTITEM.Add(item);
            } //End if
        } //End public void mapToSave_Detail(List<TrnstockdVM> poViewModel, List<ProductstockVM> poViewModel_Productstock)
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
