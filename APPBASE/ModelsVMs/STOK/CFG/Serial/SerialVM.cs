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
    public partial class SerialVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public string SERIAL_CODE { get; set; }
        public string SERIAL_NAME { get; set; }
        public int? PRODTYPE_ID { get; set; }
        public string PRODTYPE_CODE { get; set; }
        public string PRODTYPE_NAME { get; set; }
    } //End public partial class SerialVM
} //End namespace APPBASE.Models
