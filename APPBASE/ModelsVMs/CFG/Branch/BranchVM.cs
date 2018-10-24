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
    public partial class BranchlistVM
    {
        public int? ID { get; set; }
        public string BRANCH_DESC { get; set; }
    } //End public partial class BranchlistVM
    public partial class BranchdetailVM
    {
        public int? ID { get; set; }
        public Byte? BRANCH_TYPE { get; set; }
        public string BRANCH_DESC { get; set; }
        public string ADDR_CITY { get; set; }
        public string ADDR_KEC { get; set; }
        public string ADDR_KEL { get; set; }
        public string ADDR_ZIP { get; set; }
        public string ADDR_STREET1 { get; set; }
        public string ADDR_STREET2 { get; set; }
        public string PHONE { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
    } //End public partial class BranchdetailVM

    public partial class BranchlookupVM
    {
        public int? ID { get; set; }
        public string BRANCH_DESC { get; set; }
    } //End public partial class BranchlistVM

} //End namespace APPBASE.Models

