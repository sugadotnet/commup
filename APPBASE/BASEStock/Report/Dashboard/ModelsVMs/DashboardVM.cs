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
    public partial class DashboardVM
    {
        //Validasi Produk baru dan stok
        public int? PRODVAL_NEW { get; set; }
        public int? PRODVAL_STOCK { get; set; }
        public int? PRODVAL_YEAR { get; set; }
        //Stok Produk
        public int? PRODSTOCK_DISPLAY { get; set; }
        public int? PRODSTOCK_GUDANGA { get; set; }
        public int? PRODSTOCK_GUDANGB { get; set; }
        public int? PRODSTOCK_YEAR { get; set; }
        //Penjualan
        public int? PRODSELL { get; set; }
        public int? PRODSELL_YEAR { get; set; }
        public List<int?> PRODSELL_YEAR_LIST { get; set; }

    } //End public partial class MonthVM
} //End namespace APPBASE.Models
