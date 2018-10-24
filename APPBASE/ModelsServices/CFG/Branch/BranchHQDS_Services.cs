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
    public class BranchHQDS
    {
        //Constructor
        public BranchHQDS() { } //End public BranchHQDS
        public BranchdetailVM getData()
        {
            BranchdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.BranchHQ_infos
                           select new BranchdetailVM
                           {
                               ID = tb.ID,
                               BRANCH_DESC = tb.BRANCH_DESC,
                               ADDR_CITY = tb.ADDR_CITY,
                               ADDR_KEC = tb.ADDR_KEC,
                               ADDR_KEL = tb.ADDR_KEL,
                               ADDR_ZIP = tb.ADDR_ZIP,
                               ADDR_STREET1 = tb.ADDR_STREET1,
                               ADDR_STREET2 = tb.ADDR_STREET2,
                               PHONE = tb.PHONE,
                               FAX = tb.FAX,
                               EMAIL = tb.EMAIL
                           };
                oReturn = oQRY.FirstOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public BranchHQdetailVM getData(int? id = null)
    } //End public class BranchHQDS
} //End namespace APPBASE.Models

