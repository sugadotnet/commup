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
    [Table("AC01USR")]
    public class User : CRUD
    {
        public Byte? DTA_STS { get; set; }
        public int? RES_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string EMAIL { get; set; }
        public int? USER_STS { get; set; }
        public string USER_IMG { get; set; }
        public int? BRANCH_ID { get; set; }
    } //End public class User : CRUD
} //End namespace APPBASE.Models

