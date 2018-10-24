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
    public partial class ValidationMSG_VM {
        public string VAL_ERRID { get; set; }
        public string VAL_ERRTYPE { get; set; }
        public string VAL_ERRMSG { get; set; }
        public string VAL_ERRINFO_S { get; set; }
        public int? VAL_ERRINFO_n { get; set; }
    } //End public partial class validationMSG_VM
} //End namespace APPBASE.Models
