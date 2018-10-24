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
    [Table("VWMST01CFG_MONTH_INFO")]
    public partial class Month_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
        public int? ID { get; set; }
        public int? DTA_STS { get; set; }
        public string MONTH_CODE { get; set; }
        public string MONTH_SHORTDESC { get; set; }
        public string MONTH_DESC { get; set; }
        public Byte? MONTH_NUM { get; set; }
        public Byte? MONTH_SEQNO { get; set; }
    } //End public partial class Month_info
} //End namespace APPBASE.Models
