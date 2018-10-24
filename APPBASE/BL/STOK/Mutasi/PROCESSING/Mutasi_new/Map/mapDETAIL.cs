using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_newBL : MutasiBL {
        protected Boolean mapDETAIL() {
            this._TRNSTOCKD = new TrnstockdVM();
            this._TRNSTOCKDS = new List<TrnstockdVM>();

            this._TRNSTOCKD.PROD_ID = this._PRODUCT.ID;
            this._TRNSTOCKD.TRND_QTY = this._PRODUCTNEW.PRODNEW_QTY;
            this._TRNSTOCKD.TRND_PRICE = this._PRODUCTNEW.PRODNEW_PRICE_BASE;
            this._TRNSTOCKD.CACHE_PROD_PRICE_BASE = this._PRODUCTNEW.PRODNEW_PRICE_BASE;
            if (this._TRNSTOCKD.TRND_QTY != null && this._TRNSTOCKD.TRND_PRICE != null)
            {
                this._TRNSTOCKD.TRND_GROSSAMOUNT = this._TRNSTOCKD.TRND_QTY * this._TRNSTOCKD.TRND_PRICE;
                this._TRNSTOCKD.TRND_AMOUNT = this._TRNSTOCKD.TRND_GROSSAMOUNT;
            } //end if
            this._TRNSTOCKD.CACHE_PROD_PRICEDT = this._PRODUCTNEW.PRODNEW_OPENDT;
            this._TRNSTOCKD.TRND_DESC = "Tambah barang baru " + this._PRODUCTNEW.PRODNEW_NAME;
            this._TRNSTOCKD.PRODSTOCK_ID = this._PRODUCTSTOCK.ID;
            this._TRNSTOCKD.STORAGE_BASEID = null;
            this._TRNSTOCKD.STORAGE_TARGETID = this._PRODUCTNEW.STORAGE_ID;

            this._TRNSTOCKDS.Add(this._TRNSTOCKD);
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
