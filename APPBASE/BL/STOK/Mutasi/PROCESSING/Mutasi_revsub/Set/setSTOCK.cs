using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_revsubBL : Mutasi_revBL
    {
        protected override Boolean setSTOCKS() {
            int nIndex = 0;
            foreach (var item in this._TRNSTOCKDS)
            {
                //Update stock target
                nIndex = this._PRODUCTSTOCKS.FindIndex(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_ID == item.STORAGE_TARGETID);
                if (nIndex < 0) { //if Stock target not exist
                    this._TRNSTOCKD = item;
                    this.__PRODUCTSTOCK = new ProductstockVM();
                    this.setSTOCK();
                    this.__PRODUCTSTOCKS_NEW.Add(this.__PRODUCTSTOCK);
                } //End if
                if (nIndex >= 0) { //if stock target exist
                    this._PRODUCTSTOCKS[nIndex].STOCK_QTY = this._PRODUCTSTOCKS[nIndex].STOCK_QTY - item.TRND_QTY;
                    this.__PRODUCTSTOCKS_UPDATE.Add(this._PRODUCTSTOCKS[nIndex]);
                } //End if
            } //End foreach

            //Return
            return true;
        } //End Method

        private Boolean setSTOCK()
        {
            //FROM TRANSACTION HEADER = _TRNSTOCK
            this.__PRODUCTSTOCK.STOCK_DT = this.__TRNSTOCK.TRN_DT;

            //FROM TRANSACTION DETAIL = _TRNSTOCKD
            this.__PRODUCTSTOCK.PROD_ID = this._TRNSTOCKD.PROD_ID;
            this.__PRODUCTSTOCK.STOCK_QTY = this._TRNSTOCKD.TRND_QTY;
            this.__PRODUCTSTOCK.STOCK_DESC = "Mutasi stock awal";
            this.__PRODUCTSTOCK.STORAGE_ID = this._TRNSTOCKD.STORAGE_TARGETID;

            //Return
            return true;
        } //End Method
        
    } //End Method
} //End namespace APPBASE.Models
