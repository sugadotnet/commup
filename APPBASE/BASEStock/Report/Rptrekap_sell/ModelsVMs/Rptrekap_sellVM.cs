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
    public partial class Rptrekap_sellVM
    {
        public int? ID { get; set; }
        public int? ACTION_TYPE { get; set; }
        public int? FILTER_TYPE { get; set; } //1-Periode Tanggal | 2-Periode Bulan-Tahun | 3-Periode Tahun
        //1-Filter Tipe Periode Tanggal
        public DateTime? TRNFROM_DT { get; set; }
        public DateTime? TRNTO_DT { get; set; }
        //2-Filter Tipe Periode Bulan-Tahun
        public int? TRN_YEAR { get; set; }
        public int? TRN_MONTH { get; set; }
        public int? TRN_YEARMONTH { get; set; }
        public string TRN_YEARMONTH_S { get; set; }
        //3-Filter Tipe Periode Tahun
        public int? TRN_YEARONLY { get; set; }
        //Filter Storage
        public int? STORAGE_ID { get; set; }
        //Filter Product Type
        public int? PRODTYPE_ID { get; set; }
        //Filter Product Type
        public int TOPDATA { get; set; }

        public List<Rekap_sellVM> DETAIL { get; set; }
    } //End class
} //End namespace
