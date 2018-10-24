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
    public class JobtypeDS
    {
        //Constructor
        public JobtypeDS() { } //End public JobtypeDS
        public List<JobtypelistVM> getDatalist()
        {
            List<JobtypelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Jobtypes
                           select new JobtypelistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<JobtypelistVM> getDatalist()
        public JobtypedetailVM getData(int? id = null)
        {
            JobtypedetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Jobtypes
                           where tb.ID == id
                           select new JobtypedetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public JobtypedetailVM getData(int? id = null)
        public List<JobtypelookupVM> getDatalist_lookup()
        {
            List<JobtypelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Jobtypes
                           select new JobtypelookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<JobtypelookupVM> getDatalist_lookup()
    
    } //End public class JobtypeDS
} //End namespace APPBASE.Models

