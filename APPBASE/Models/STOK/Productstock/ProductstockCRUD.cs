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
    [Table("STO01PRODUCT_STOCK")]
    public partial class Productstock : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public int? PROD_ID { get; set; }
        public DateTime? STOCK_DT { get; set; }
        public int? STOCK_QTY { get; set; }
        public string STOCK_DESC { get; set; }
        public int? STORAGE_ID { get; set; }
    } //End public partial class Productstock : CRUD
} //End namespace APPBASE.Models
