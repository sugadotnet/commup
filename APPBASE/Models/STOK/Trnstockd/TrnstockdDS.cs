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
    [Table("VWSTO01TRN_STOCKD_INFO")]
    public partial class Trnstockd_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? TRN_ID { get; set; }
        public int? TRND_QTY { get; set; }
        public decimal? TRND_PRICE { get; set; }
        public decimal? TRND_GROSSAMOUNT { get; set; }
        public decimal? TRND_TAXRATE { get; set; }
        public decimal? TRND_TAXAMOUNT { get; set; }
        public decimal? TRND_AFTERTAXAMOUNT { get; set; }
        public decimal? TRND_DISCRATE { get; set; }
        public decimal? TRND_DISCAMOUNT { get; set; }
        public decimal? TRND_AMOUNT { get; set; }
        public string TRND_DESC { get; set; }
        public int? PROD_ID { get; set; }
        public int? PRODSTOCK_ID { get; set; }
        public int? STORAGE_BASEID { get; set; }
        public int? STORAGE_TARGETID { get; set; }
        public string CACHE_PROD_CODE { get; set; }
        public string CACHE_PROD_NAME { get; set; }
        public decimal? CACHE_PROD_PRICE_BASE { get; set; }
        public decimal? CACHE_PROD_PRICE_SELL { get; set; }
        public DateTime? CACHE_PROD_PRICEDT { get; set; }
        public string PROD_CODE { get; set; }
        public string PROD_NAME { get; set; }
        public string PROD_DESC { get; set; }
        public string PROD_IMAGE { get; set; }
        public decimal? PROD_PRICE_BASE { get; set; }
        public decimal? PROD_PRICE_SELL { get; set; }
        public DateTime? PROD_PRICEDT { get; set; }
        public Byte? PROD_STS { get; set; }
        public int? COUNTRY_ID { get; set; }
        public int? VENDOR_ID { get; set; }
        public int? PRODTYPE_ID { get; set; }
        public int? PRODSUBTYPE_ID { get; set; }
        public int? SERIAL_ID { get; set; }
        public int? UKURAN_ID { get; set; }
        public int? UOM_ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string VENDOR_CODE { get; set; }
        public string VENDOR_NAME { get; set; }
        public string PRODTYPE_CODE { get; set; }
        public string PRODTYPE_NAME { get; set; }
        public string PRODSUBTYPE_CODE { get; set; }
        public string PRODSUBTYPE_NAME { get; set; }
        public string SERIAL_CODE { get; set; }
        public string SERIAL_NAME { get; set; }
        public string UKURAN_CODE { get; set; }
        public string UKURAN_NAME { get; set; }
        public string UOM_CODE { get; set; }
        public string UOM_DESC { get; set; }
        public string UOM_SYM { get; set; }
        public int? UOM_SEQNO { get; set; }
        public string STORAGE_BASECODE { get; set; }
        public string STORAGE_BASENAME { get; set; }
        public int? STORAGE_BASESEQNO { get; set; }
        public string STORAGE_TARGETCODE { get; set; }
        public string STORAGE_TARGETNAME { get; set; }
        public int? STORAGE_TARGETSEQNO { get; set; }

        public Byte? TRN_STS { get; set; }
        public int? TRN_TYPEID { get; set; }
        public string TRNTYPE_CODE { get; set; }
        public string TRNTYPE_NAME { get; set; }

        public int? TRN_SUBTYPEID { get; set; }
        public DateTime? TRN_DT { get; set; }
        public string TRN_CODE { get; set; }
        public string TRN_GIVER { get; set; }
        public string TRN_RECIPIENT { get; set; }
        public string TRN_DESC { get; set; }

        public int? TRN_YEAR { get; set; }
        public int? TRN_MONTH { get; set; }
        public int? TRN_YEARMONTH { get; set; }
    } //End public partial class Trnstockd_info
} //End namespace APPBASE.Models
