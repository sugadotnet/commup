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
    public class BranchDS
    {
        //Constructor
        public BranchDS() { } //End public BranchDS
        public List<BranchlistVM> getDatalist()
        {
            List<BranchlistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Branch_infos
                           select new BranchlistVM
                           {
                               ID = tb.ID,
                               BRANCH_DESC = tb.BRANCH_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<BranchlistVM> getDatalist()
        public BranchdetailVM getData(int? id = null)
        {
            BranchdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Branch_infos
                           where tb.ID == id
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
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public BranchdetailVM getData(int? id = null)
        public List<BranchlookupVM> getDatalist_lookup()
        {
            List<BranchlookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Branch_infos
                           select new BranchlookupVM
                           {
                               ID = tb.ID,
                               BRANCH_DESC = tb.BRANCH_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<CitylookupVM> getDatalist_lookup()
    } //End public class BranchDS
} //End namespace APPBASE.Models

