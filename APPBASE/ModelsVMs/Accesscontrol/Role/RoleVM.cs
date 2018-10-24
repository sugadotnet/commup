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
    public partial class RolelistVM
    {
        public int? ID { get; set; }
        public string ROLE_CD { get; set; }
        public string DISPLAY_NAME { get; set; }
    } //End public partial class RoledetailVM
    public partial class RoledetailVM
    {
        public int? ID { get; set; }
        public int? MDLE_ID { get; set; }
        public string ROLE_CD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public Byte? SEQNO { get; set; }
    } //End public partial class RoledetailVM

    public partial class RolelookupVM
    {
        public int? ID { get; set; }
        public string ROLE_CD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public Byte? SEQNO { get; set; }
    } //End public partial class RoledetailVM
} //End namespace APPBASE.Models
