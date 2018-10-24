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
    [Table("VWMST01CFG_BRANCH_INFO")]
    public partial class Branch_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
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
    } //End public partial class Branch_info
    [Table("VWMST01CFG_BRANCHHQ_INFO")]
    public partial class BranchHQ_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
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
    } //End public partial class BranchHQ_info

    [Table("VWEDU01CFG_BRANCHALL_INFO")]
    public partial class Branchall_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
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
    } //End public partial class Branch_info
} //End namespace APPBASE.Models

