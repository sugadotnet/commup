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
    [Table("STO01TRN_STOCK")]
    public partial class Trnstock : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public Byte? TRN_STS { get; set; }
        public int? TRN_TYPEID { get; set; }
        public int? TRN_SUBTYPEID { get; set; }
        public DateTime? TRN_DT { get; set; }
        public string TRN_CODE { get; set; }
        public string TRN_GIVER { get; set; }
        public string TRN_RECIPIENT { get; set; }
        public string TRN_DESC { get; set; }
        public decimal? TRN_AMOUNT { get; set; }
        public int? STORAGE_BASEID { get; set; }
        public int? STORAGE_TARGETID { get; set; }
    } //End public partial class Trnstock : CRUD
} //End namespace APPBASE.Models
