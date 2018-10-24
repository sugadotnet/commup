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
    public partial class ProductstockVM
    {
        public void mapToUpdateStock(List<TrnstockdVM> poViewModel_Transactiond)
        {
            List<ProductstockVM> oViewModel = this.LIST_INDEX;
            List<ProductstockVM> oViewModel_toRemove = new List<ProductstockVM>();
            int nIndex = 0;
            foreach (var item in poViewModel_Transactiond)
            {
                //Update stock target
                nIndex = oViewModel.FindIndex(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_ID == item.STORAGE_TARGETID);
                if (nIndex < 0)
                {
                    this._TRNSTOCKD = item;
                    this.inject_PRODUCTSTOCK();
                    this.mapProductstock_init();
                    this.add_PRODUCTSTOCKS(this._PRODUCTSTOCK);
                } //End if
                //oViewModel[nIndex].STOCK_QTY = oViewModel[nIndex].STOCK_QTY + item.TRND_QTY;

                //Update stock base
                nIndex = oViewModel.FindIndex(fld => fld.PROD_ID == item.PROD_ID &&  fld.STORAGE_ID == item.STORAGE_BASEID);
                oViewModel[nIndex].STOCK_QTY = oViewModel[nIndex].STOCK_QTY - item.TRND_QTY;


                //Hapus baris yang tidak ingin di save
                foreach (var itemStock in oViewModel)
                {
                    if ((itemStock.STORAGE_ID != item.STORAGE_BASEID) && (itemStock.STORAGE_ID != item.STORAGE_TARGETID)) {
                        oViewModel_toRemove.Add(itemStock);
                    } //End if ((itemStock.ID != item.STORAGE_BASEID) && (itemStock.ID != item.STORAGE_TARGETID)) {
                } //End foreach (var itemStock in oViewModel)
                
            } //End foreach (var item in poViewModel_Transactiond)
            //Replace list dengan list yang sudah bersih dan di update stocknya
            foreach (var item in oViewModel_toRemove)
	        {
                oViewModel.Remove(item);
	        }
            this.LIST_INDEX = oViewModel;
        } //End public void InjectFrom_Product(ProductVM poViewModel)
    } //End public partial class ProductstockVM
} //End namespace APPBASE.Models
