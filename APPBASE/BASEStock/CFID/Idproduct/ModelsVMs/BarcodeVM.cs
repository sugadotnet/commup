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
    public partial class BarcodeVM
    {
        public string SEGMENT01 { get; set; }
        public string SEGMENT02 { get; set; }
        public string SEGMENT03 { get; set; }
        public string SEGMENT04 { get; set; }
        public string SEGMENT05 { get; set; }
        public string SEGMENT06 { get; set; }
        public string SEGMENT07 { get; set; }
        public string SEGMENT08 { get; set; }

        public Boolean RESULT_STATUS { get; set; }
        public string RESULT_STATUS_MESSAGE { get; set; }
        public string RESULT_VALUE { get; set; }
    } //End class
} //End namespace
