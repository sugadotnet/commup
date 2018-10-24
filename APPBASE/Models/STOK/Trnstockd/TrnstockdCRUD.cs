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
    [Table("STO01TRN_STOCKD")]
    public partial class Trnstockd : CRUD
    {
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
    } //End public partial class Trnstockd : CRUD
} //End namespace APPBASE.Models
