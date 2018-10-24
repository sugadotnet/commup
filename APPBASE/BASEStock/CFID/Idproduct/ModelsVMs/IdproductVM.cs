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
    public partial class IdproductVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? ID_COUNTER { get; set; }
        public int? ID_YEAR { get; set; }
        public int? ID_MONTH { get; set; }
        public string ID_LAST { get; set; }
        public string ID_CURRENT { get; set; }
    } //End public partial class IdproductVM
} //End namespace APPBASE.Models
