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
    [Table("STO01PRODUCT_NEW")]
    public partial class Productnew : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public string PRODNEW_CODE { get; set; }
        public string PRODNEW_NAME { get; set; }
        public string PRODNEW_DESC { get; set; }
        public string PRODNEW_IMAGE { get; set; }
        public int? PRODNEW_QTY { get; set; }
        public decimal? PRODNEW_PRICE_BASE { get; set; }
        public decimal? PRODNEW_PRICE_SELL { get; set; }
        public DateTime? PRODNEW_PRICEDT { get; set; }
        public Byte? PRODNEW_STS { get; set; }
        public DateTime? PRODNEW_OPENDT { get; set; }
        public DateTime? PRODNEW_VALDT { get; set; }
        public int? COUNTRY_ID { get; set; }
        public int? VENDOR_ID { get; set; }
        public int? PRODTYPE_ID { get; set; }
        public int? PRODSUBTYPE_ID { get; set; }
        public int? SERIAL_ID { get; set; }
        public int? FINISHING_ID { get; set; }
        public int? UKURAN_ID { get; set; }
        public int? UOM_ID { get; set; }
        public int? STORAGE_ID { get; set; }
    } //End public partial class Productnew : CRUD
} //End namespace APPBASE.Models
