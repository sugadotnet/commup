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
    public partial class StockMAP
    {
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public StockMAP() {
            this.db = new DBMAINContext();
        } //End Constructor
        //Constructor 2
        public StockMAP(DBMAINContext poDB) {
            this.db = poDB;
        } //End Constructor
        //Initialize
        public Boolean Init() {

            //Return
            return true;
        } //End Method
        //Process
        public Boolean Process()
        {
            this._TRNSTOCK_result = this._TRNSTOCK_data;
            
            this._TRNSTOCK_result.TRN_DT = this._DATETIME;
            
            this._TRNSTOCK_result.TRN_DT = DateTime.Now;
            
            this._TRNSTOCK_result.STORAGE_BASEID = this._PRODUCTSTOCK_data.STORAGE_ID;
            this._TRNSTOCK_result.LISTITEM = new List<TrnstockdVM>();
            foreach (var item in this._PRODUCTSTOCK_data.LIST_INDEX)
            {
                var oData = this._PRODUCTSTOCK_datas.SingleOrDefault(fld => fld.ID == item.ID);
                TrnstockdVM oItem = new TrnstockdVM();
                oItem.PRODSTOCK_ID = oData.ID;
                oItem.PROD_ID = oData.PROD_ID;
                oItem.PROD_CODE = oData.PROD_CODE;
                oItem.PROD_NAME = oData.PROD_NAME;
                oItem.TRND_QTY = oData.STOCK_QTY;
                oItem.STOCK_QTY = oData.STOCK_QTY;
                oItem.TRND_PRICE = oData.PROD_PRICE_SELL;
                oItem.PROD_IMAGE = oData.PROD_IMAGE;
                oItem.PROD_PRICE_BASE = oData.PROD_PRICE_BASE;
                oItem.PROD_PRICE_SELL = oData.PROD_PRICE_SELL;
                oItem.UOM_CODE = oData.UOM_CODE;
                oItem.STORAGE_BASEID = oData.STORAGE_ID;
                oItem.STORAGE_BASECODE = oData.STORAGE_CODE;
                oItem.STORAGE_BASENAME = oData.STORAGE_NAME;
                this._TRNSTOCK_result.LISTITEM.Add(oItem);
            } //End foreach

            //Return
            return true;
        } //End Method
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
