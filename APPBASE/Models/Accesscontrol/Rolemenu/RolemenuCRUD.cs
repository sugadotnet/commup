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
    [Table("AC01ROLE_MNU")]
    public partial class Rolemenu : CRUD
    {
        public int? MDLE_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public int? MNU_ID { get; set; }
    } //End public partial class Rolemenu : CRUD
} //End namespace APPBASE.Models
