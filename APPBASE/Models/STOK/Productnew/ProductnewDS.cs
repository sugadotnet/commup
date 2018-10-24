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
    [Table("VWSTO01PRODUCT_NEW_INFO")]
    public partial class Productnew_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
        public int? ID { get; set; }
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
        public string FINISHING_CODE { get; set; }
        public string FINISHING_NAME { get; set; }
        public string UKURAN_CODE { get; set; }
        public string UKURAN_NAME { get; set; }
        public string UOM_CODE { get; set; }
        public string UOM_DESC { get; set; }
        public string UOM_SYM { get; set; }
        public int? UOM_SEQNO { get; set; }
        public string STORAGE_CODE { get; set; }
        public string STORAGE_NAME { get; set; }
        public int? STORAGE_SEQNO { get; set; }
    } //End public partial class Productnew_info
} //End namespace APPBASE.Models
