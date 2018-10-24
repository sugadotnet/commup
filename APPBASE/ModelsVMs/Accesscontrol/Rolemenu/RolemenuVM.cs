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
    public partial class RolemenulistVM
    {
        public int? ID { get; set; }
        public int? ROLE_ID { get; set; }
        public int? MNU_ID { get; set; }
    } //End public partial class RolemenulistVM
    public partial class RolemenudetailVM
    {
        public int? ID { get; set; }
        public int? MDLE_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public int? MNU_ID { get; set; }
    } //End public partial class RolemenudetailVM

    public partial class RolemenulookupVM
    {
        public int? ID { get; set; }
    } //End public partial class RolemenulistVM

} //End namespace APPBASE.Models
