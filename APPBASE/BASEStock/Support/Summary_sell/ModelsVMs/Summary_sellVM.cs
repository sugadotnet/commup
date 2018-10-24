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
    public partial class Summary_sellVM
    {
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
        public decimal? TRND_GROSSAMOUNT { get; set; }
        public decimal? TRND_TAXAMOUNT { get; set; }
        public decimal? TRND_AFTERTAXAMOUNT { get; set; }
        public decimal? TRND_DISCAMOUNT { get; set; }
        public decimal? TRND_AMOUNT { get; set; }
        public chartVM CHART { get; set; }
    } //End public partial class Summary_sellVM

    public partial class ReportsellVM
    {
        public int? TRN_YEAR { get; set; }
        public List<int?> YEAR_LIST { get; set; }
        public List<Summary_sellVM> DETAIL { get; set; }
        public List<chartVM> DETAIL_CHART { get; set; }

        //TOTAL
        public int? TOTAL_QTY { get; set; }
        public decimal? TOTAL_AMOUNT { get; set; }
    } //End class

    public partial class chartVM
    {
        public int? QTY { get; set; }
        public decimal? AMT { get; set; }
    } //End class
} //End namespace APPBASE.Models
