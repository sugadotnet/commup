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
    public partial class TrnstockVM
    {
        public int? ID { get; set; }
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
        public string STORAGE_BASECODE { get; set; }
        public string STORAGE_BASENAME { get; set; }
        public int? STORAGE_BASESEQNO { get; set; }
        public string STORAGE_TARGETCODE { get; set; }
        public string STORAGE_TARGETNAME { get; set; }
        public int? STORAGE_TARGETSEQNO { get; set; }
        public string TRNTYPE_CODE { get; set; }
        public string TRNTYPE_NAME { get; set; }
        
        //Custom Detail transaction
        public List<TrnstockdVM> LISTITEM { get; set; }
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
