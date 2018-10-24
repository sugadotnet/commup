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
    [Table("AC01ROLE")]
    public class Role : CRUD
    {
        public int? MDLE_ID { get; set; }
        public string ROLE_CD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public Byte? SEQNO { get; set; }
    } //End public class Role : CRUD
} //End namespace APPBASE.Models

