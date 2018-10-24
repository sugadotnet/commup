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
    [Table("STO01CFG_FINISHING")]
    public partial class Finishing : CRUD
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public string FINISHING_CODE { get; set; }
        public string FINISHING_NAME { get; set; }
        public int? PRODTYPE_ID { get; set; }
    } //End public partial class Finishing : CRUD
} //End namespace APPBASE.Models
