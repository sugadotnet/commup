using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_revsubBL : Mutasi_revBL {
        protected override Boolean setDETAIL() {
            foreach (var item in this._TRNSTOCKDS)
            {
                var oData = this._PRODUCTSTOCKS.SingleOrDefault(fld => fld.ID == item.PRODSTOCK_ID);
                //item.TRN_ID = this._TRNSTOCK.ID; //Tidak dipakai karena HEADER belum di save jadi pasti ID belum di generate
                item.PROD_ID = oData.PROD_ID;
                //item.STORAGE_TARGETID = valFLAG.STORAGE_ID_DISPLAY;
                item.STORAGE_TARGETID = this._STORAGE.ID;
                item.CACHE_PROD_CODE = oData.PROD_CODE;
                item.CACHE_PROD_NAME = oData.PROD_NAME;
                item.PROD_PRICEDT = oData.PROD_PRICEDT;
                this.__TRNSTOCKDS.Add(item);
            } //End foreach
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
