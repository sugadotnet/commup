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
        public void mapProductstock_init()
        {
            //FROM TRANSACTION HEADER = _TRNSTOCK
            this._PRODUCTSTOCK.STOCK_DT = this._TRNSTOCK.TRN_DT;

            //FROM TRANSACTION DETAIL = _TRNSTOCKD
            this._PRODUCTSTOCK.PROD_ID = this._TRNSTOCKD.PROD_ID;
            this._PRODUCTSTOCK.STOCK_QTY = this._TRNSTOCKD.TRND_QTY;
            this._PRODUCTSTOCK.STOCK_DESC = "Mutasi stock awal";
            this._PRODUCTSTOCK.STORAGE_ID = this._TRNSTOCKD.STORAGE_TARGETID;
        } //End Method
    } //End public partial class ProductstockVM
} //End namespace APPBASE.Models
