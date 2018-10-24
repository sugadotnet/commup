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
    public partial class Rekap_sellVM
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
        //BEGIN BALANCE
        public int? QTY_BEGIN { get; set; }
        public decimal GROSSAMOUNT_BEGIN { get; set; }
        public decimal AMOUNT_BEGIN { get; set; }
        public decimal AFTERTAXAMOUNT_BEGIN { get; set; }
        public List<int?> QTY { get; set; }
        public int? QTY_TOTAL { get; set; }
    } //End class
} //End namespace
