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
    public partial class ProductVM
    {
        public void InjectFrom_Productnew(ProductnewVM poViewModel) {
            this.ID = poViewModel.ID;
            //this.DTA_STS = poViewModel.DTA_STS;
            this.PROD_CODE = poViewModel.PRODNEW_CODE;
            this.PROD_NAME = poViewModel.PRODNEW_NAME;
            this.PROD_DESC = poViewModel.PRODNEW_DESC;
            this.PROD_IMAGE = poViewModel.PRODNEW_IMAGE;
            this.PROD_QTY = poViewModel.PRODNEW_QTY;
            this.PROD_PRICE_BASE = poViewModel.PRODNEW_PRICE_BASE;
            this.PROD_PRICE_SELL = poViewModel.PRODNEW_PRICE_SELL;
            this.PROD_PRICEDT = poViewModel.PRODNEW_PRICEDT;
            this.PROD_STS = poViewModel.PRODNEW_STS;
            this.COUNTRY_ID = poViewModel.COUNTRY_ID;
            this.VENDOR_ID = poViewModel.VENDOR_ID;
            this.PRODTYPE_ID = poViewModel.PRODTYPE_ID;
            this.PRODSUBTYPE_ID = poViewModel.PRODSUBTYPE_ID;
            this.SERIAL_ID = poViewModel.SERIAL_ID;
            this.FINISHING_ID = poViewModel.FINISHING_ID;
            this.UKURAN_ID = poViewModel.UKURAN_ID;
            this.UOM_ID = poViewModel.UOM_ID;
            this.PRODNEW_ID = poViewModel.ID;
            this.COUNTRY_CODE = poViewModel.COUNTRY_CODE;
            this.COUNTRY_NAME = poViewModel.COUNTRY_NAME;
            this.VENDOR_CODE = poViewModel.VENDOR_CODE;
            this.VENDOR_NAME = poViewModel.VENDOR_NAME;
            this.PRODTYPE_CODE = poViewModel.PRODTYPE_CODE;
            this.PRODTYPE_NAME = poViewModel.PRODTYPE_NAME;
            this.PRODSUBTYPE_CODE = poViewModel.PRODSUBTYPE_CODE;
            this.PRODSUBTYPE_NAME = poViewModel.PRODSUBTYPE_NAME;
            this.SERIAL_CODE = poViewModel.SERIAL_CODE;
            this.SERIAL_NAME = poViewModel.SERIAL_NAME;
            this.FINISHING_CODE = poViewModel.FINISHING_CODE;
            this.FINISHING_NAME = poViewModel.FINISHING_NAME;
            this.UKURAN_CODE = poViewModel.UKURAN_CODE;
            this.UKURAN_NAME = poViewModel.UKURAN_NAME;
            this.UOM_CODE = poViewModel.UOM_CODE;
            this.UOM_DESC = poViewModel.UOM_DESC;
            this.UOM_SYM = poViewModel.UOM_SYM;
            this.UOM_SEQNO = poViewModel.UOM_SEQNO;
        } //End public void InjectFrom_Productnew(ProductVM povViewModel)
    } //End public partial class ProductVM
} //End namespace APPBASE.Models
