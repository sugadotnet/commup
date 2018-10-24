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
    [Table("STO01PRODUCT")]
    public partial class Product : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public string PROD_CODE { get; set; }
        public string PROD_NAME { get; set; }
        public string PROD_DESC { get; set; }
        public string PROD_IMAGE { get; set; }
        public int? PROD_QTY { get; set; }
        public decimal? PROD_PRICE_BASE { get; set; }
        public decimal? PROD_PRICE_SELL { get; set; }
        public DateTime? PROD_PRICEDT { get; set; }
        public Byte? PROD_STS { get; set; }
        public int? COUNTRY_ID { get; set; }
        public int? VENDOR_ID { get; set; }
        public int? PRODTYPE_ID { get; set; }
        public int? PRODSUBTYPE_ID { get; set; }
        public int? SERIAL_ID { get; set; }
        public int? FINISHING_ID { get; set; }
        public int? UKURAN_ID { get; set; }
        public int? UOM_ID { get; set; }
        public int? PRODNEW_ID { get; set; }
    } //End public partial class Product : CRUD
} //End namespace APPBASE.Models
