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
    public partial class Select2VM
    {
        public List<Select2_detailVM> results { get; set; }
    } //End public partial class
    public partial class Select2_detailVM
    {
        public int? id { get; set; }
        public string text { get; set; }
    } //End public partial
} //End namespace APPBASE.Models
