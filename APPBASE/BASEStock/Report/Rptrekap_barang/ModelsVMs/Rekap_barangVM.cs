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
    public partial class Rekap_barangVM
    {
        public int? ID { get; set; }
        public int? PROD_ID { get; set; }
        public string PROD_CODE { get; set; }
        public string PROD_NAME { get; set; }
        public string PROD_DESC { get; set; }
        public string PROD_IMAGE { get; set; }
        //UOM
        public int? UOM_ID { get; set; }
        public string UOM_CODE { get; set; }
        public string UOM_DESC { get; set; }
        public string UOM_SYM { get; set; }
        //DISPLAY
        public int? DISPLAY_QTY { get; set; }
        public decimal DISPLAY_GROSSAMOUNT { get; set; }
        public decimal DISPLAY_AMOUNT { get; set; }
        public decimal DISPLAY_AFTERTAXAMOUNT { get; set; }
        //GUDANG ATAS
        public int? GATAS_QTY { get; set; }
        public decimal GATAS_GROSSAMOUNT { get; set; }
        public decimal GATAS_AMOUNT { get; set; }
        public decimal GATAS_AFTERTAXAMOUNT { get; set; }
        //GUDANG BAWAH
        public int? GBAWAH_QTY { get; set; }
        public decimal GBAWAH_GROSSAMOUNT { get; set; }
        public decimal GBAWAH_AMOUNT { get; set; }
        public decimal GBAWAH_AFTERTAXAMOUNT { get; set; }
        //TOTAL
        public int? SUM_QTY { get; set; }
        public decimal SUM_GROSSAMOUNT { get; set; }
        public decimal SUM_AMOUNT { get; set; }
        public decimal SUM_AFTERTAXAMOUNT { get; set; }
    } //End class
} //End namespace
