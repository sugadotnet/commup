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
    [Table("VWSUMMARY_SELL_INFO")]
    public partial class Summary_sell_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
        public int? ID { get; set; }
        public int? TRN_YEARMONTH { get; set; }
        public int? TRN_YEAR { get; set; }
        public int? TRN_MONTH { get; set; }
        public string MONTH_CODE { get; set; }
        public string MONTH_SHORTDESC { get; set; }
        public string MONTH_DESC { get; set; }
        public Byte? MONTH_NUM { get; set; }
        public Byte? MONTH_SEQNO { get; set; }
        public int? PROD_ID { get; set; }
        public string PROD_NAME { get; set; }
        public string PROD_DESC { get; set; }
        public string PROD_IMAGE { get; set; }
        public int? TRND_QTY { get; set; }
        public decimal TRND_GROSSAMOUNT { get; set; }
        public decimal TRND_TAXAMOUNT { get; set; }
        public decimal TRND_AFTERTAXAMOUNT { get; set; }
        public decimal TRND_DISCAMOUNT { get; set; }
        public decimal TRND_AMOUNT { get; set; }
    } //End public partial class Summary_sell_info
} //End namespace APPBASE.Models
