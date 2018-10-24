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
    public partial class Rptrekap_barangVM
    {
        public int? ID { get; set; }
        public int? TRN_YEAR { get; set; }
        public int? TRN_MONTH { get; set; }
        public int? TRN_YEARMONTH { get; set; }
        public string TRN_YEARMONTH_S { get; set; }
        public int? ACTION_TYPE { get; set; }
        public List<Rekap_barangVM> DETAIL { get; set; }
    } //End class
} //End namespace
