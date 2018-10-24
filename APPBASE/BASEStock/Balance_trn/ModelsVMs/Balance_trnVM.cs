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
using APPBASE.Svcapp;

namespace APPBASE.Models
{
    public partial class Balance_trnVM
    {
        public int? ID { get; set; }
        public int? TRN_YEAR { get; set; }
        public int? TRN_MONTH { get; set; }
        public int? TRN_YEARMONTH { get; set; }
        public string TRN_YEARMONTH_S { get; set; }
        //SUM
        public int? TRN_QTY { get; set; }
        public decimal? TRN_GROSSAMOUNT { get; set; }
        public decimal? TRN_AMOUNT { get; set; }
        public decimal? TRN_AFTERTAXAMOUNT { get; set; }
        //PROD
        public int? PROD_ID { get; set; }
        public string PROD_CODE { get; set; }
        public string PROD_NAME { get; set; }
        public string PROD_DESC { get; set; }
        public string PROD_IMAGE { get; set; }
        //COUNTRY
        public int? COUNTRY_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME { get; set; }
        //VENDOR
        public int? VENDOR_ID { get; set; }
        public string VENDOR_CODE { get; set; }
        public string VENDOR_NAME { get; set; }
        //PRODTYPE
        public int? PRODTYPE_ID { get; set; }
        public string PRODTYPE_CODE { get; set; }
        public string PRODTYPE_NAME { get; set; }
        //PRODTYPE
        public int? PRODSUBTYPE_ID { get; set; }
        public string PRODSUBTYPE_CODE { get; set; }
        public string PRODSUBTYPE_NAME { get; set; }
        //SERIAL
        public int? SERIAL_ID { get; set; }
        public string SERIAL_CODE { get; set; }
        public string SERIAL_NAME { get; set; }
        //UKURAN
        public int? UKURAN_ID { get; set; }
        public string UKURAN_CODE { get; set; }
        public string UKURAN_NAME { get; set; }
        //UOM
        public int? UOM_ID { get; set; }
        public string UOM_CODE { get; set; }
        public string UOM_DESC { get; set; }
        public string UOM_SYM { get; set; }
        //STORAGE BASE
        public int? STORAGE_BASEID { get; set; }
        public string STORAGE_BASECODE { get; set; }
        public string STORAGE_BASENAME { get; set; }
        //STORAGE TARGET
        public int? STORAGE_TARGETID { get; set; }
        public string STORAGE_TARGETCODE { get; set; }
        public string STORAGE_TARGETNAME { get; set; }
    } //End public partial class Balance_trnVM
} //End namespace APPBASE.Models
