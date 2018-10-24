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
        protected Boolean mapHEADER() {
            this._TRNSTOCK = new TrnstockVM();
            this._TRNSTOCK.TRN_DT = this._PRODUCTNEW.PRODNEW_OPENDT;
            this._TRNSTOCK.TRN_CODE = this._PRODUCTNEW.PRODNEW_CODE;
            this._TRNSTOCK.TRN_GIVER = this._VENDOR.VENDOR_NAME;
            this._TRNSTOCK.TRN_RECIPIENT = this._STORAGE.STORAGE_NAME;
            this._TRNSTOCK.TRN_DESC = "Tambah barang baru " + this._PRODUCTNEW.PRODNEW_NAME;
            this._TRNSTOCK.STORAGE_BASEID = null;
            this._TRNSTOCK.STORAGE_TARGETID = this._PRODUCTNEW.STORAGE_ID;
            if (this._PRODUCTNEW.PRODNEW_QTY != null && this._PRODUCTNEW.PRODNEW_PRICE_BASE != null) {
                this._TRNSTOCK.TRN_AMOUNT = this._PRODUCTNEW.PRODNEW_QTY * this._PRODUCTNEW.PRODNEW_PRICE_BASE;
            } //end if

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
