using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_kasirBL : MutasiBL {
        protected Boolean calcDETAIL() {

            //reset items
            this.__TRNSTOCKDS = new List<TrnstockdVM>();
            this._TRNSTOCK.TRN_AMOUNT = 0;
            foreach (var item in this._TRNSTOCKDS)
            {
                //QTY
                if (item.TRND_QTY == null) item.TRND_QTY = 0;
                //PRICE
                if (item.TRND_PRICE == null) {
                    if ((item.TRND_PRICE_S == "") || (item.TRND_PRICE_S == null)) item.TRND_PRICE = 0;
                    else item.TRND_PRICE = hlpConvertionAndFormating.ConvertStringToDecimal(item.TRND_PRICE_S);
                } //End if
                //DISCOUNT
                if (item.TRND_DISCRATE == null) {
                    if ((item.TRND_DISCRATE_S == "") || (item.TRND_DISCRATE_S == null)) item.TRND_DISCRATE = 0;
                    else item.TRND_DISCRATE = hlpConvertionAndFormating.ConvertStringToDecimal(item.TRND_DISCRATE_S);
                } //End if
                //TAX
                if (item.TRND_TAXRATE == null) {
                    if ((item.TRND_TAXRATE_S == "") || (item.TRND_TAXRATE_S == null)) item.TRND_TAXRATE = 0;
                    else item.TRND_TAXRATE = hlpConvertionAndFormating.ConvertStringToDecimal(item.TRND_TAXRATE_S);
                } //End if
                //AMOUNT
                if (item.TRND_AMOUNT == null) item.TRND_AMOUNT = 0;
                //GROSS
                item.TRND_GROSSAMOUNT = item.TRND_QTY * item.TRND_PRICE;
                //DISCOUNT
                item.TRND_DISCAMOUNT = item.TRND_GROSSAMOUNT * (item.TRND_DISCRATE / 100);
                //TAX
                item.TRND_TAXAMOUNT = item.TRND_GROSSAMOUNT * (item.TRND_TAXRATE / 100);
                //NET
                item.TRND_AMOUNT = item.TRND_GROSSAMOUNT - (item.TRND_DISCAMOUNT+item.TRND_TAXAMOUNT);

                this.__TRNSTOCKDS.Add(item);
                this._TRNSTOCK.TRN_AMOUNT = this._TRNSTOCK.TRN_AMOUNT + item.TRND_AMOUNT;
            } //End foreach

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
