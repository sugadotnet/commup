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
        public void InjectFrom_many(ProductnewVM poViewModel_Productnew, ProductVM poViewModel_Product)
        {
            this.PROD_ID = poViewModel_Product.ID;
            this.STOCK_DT = poViewModel_Productnew.PRODNEW_OPENDT;
            this.STOCK_QTY = poViewModel_Productnew.PRODNEW_QTY;
            this.STOCK_DESC = "Stock Awal";
            this.STORAGE_ID = poViewModel_Productnew.STORAGE_ID;
        } //End public void InjectFrom_Product(ProductVM poViewModel)
    } //End public partial class ProductstockVM
} //End namespace APPBASE.Models
