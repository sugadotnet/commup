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
        public void mapToInput(ProductstockVM poViewModel)
        {
            this.TRN_DT = DateTime.Now;
            this.STORAGE_BASEID = poViewModel.STORAGE_ID;
            
            this.LISTITEM = new List<TrnstockdVM>();
            foreach (var item in poViewModel.LIST_INDEX)
            {
                TrnstockdVM oItem = new TrnstockdVM();
                oItem.PRODSTOCK_ID = item.ID;
                oItem.PROD_ID = item.PROD_ID;
                oItem.PROD_CODE = item.PROD_CODE;
                oItem.PROD_NAME = item.PROD_NAME;
                oItem.TRND_QTY = item.STOCK_QTY;
                oItem.STOCK_QTY = item.STOCK_QTY;
                oItem.PROD_IMAGE = item.PROD_IMAGE;
                oItem.UOM_CODE = item.UOM_CODE;
                oItem.STORAGE_BASEID = item.STORAGE_ID;
                oItem.STORAGE_BASECODE = item.STORAGE_CODE;
                oItem.STORAGE_BASENAME = item.STORAGE_NAME;
                this.LISTITEM.Add(oItem);
            } //End if
        } //End public void mapToInput(ProductstockVM poViewModel)
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
