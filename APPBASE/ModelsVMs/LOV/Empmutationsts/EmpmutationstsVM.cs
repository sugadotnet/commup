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
    public partial class EmpmutationstslistVM
    {
        public int? ID { get; set; }
        public string LOV_CODE { get; set; }
        public string LOV_DESC { get; set; }
    } //End public partial class EmpmutationstslistVM
    public partial class EmpmutationstsdetailVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public string LOV_CODE { get; set; }
        public string LOV_DESC { get; set; }
        public int? LOV_SEQNO { get; set; }
    } //End public partial class EmpmutationstsdetailVM

    public partial class EmpmutationstslookupVM
    {
        public int? ID { get; set; }
        public string LOV_CODE { get; set; }
        public string LOV_DESC { get; set; }
    } //End public partial class EmpmutationstslistVM

} //End namespace APPBASE.Models
