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
    [Table("STO01CFG_STORAGE")]
    public partial class Storage : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public string STORAGE_CODE { get; set; }
        public string STORAGE_NAME { get; set; }
        public int? STORAGE_SEQNO { get; set; }
    } //End public partial class Storage : CRUD
} //End namespace APPBASE.Models
