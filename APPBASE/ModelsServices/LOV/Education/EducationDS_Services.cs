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
    public class EducationDS
    {
        //Constructor
        public EducationDS() { } //End public EducationDS
        public List<EducationlistVM> getDatalist()
        {
            List<EducationlistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Educations
                           select new EducationlistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EducationlistVM> getDatalist()
        public EducationdetailVM getData(int? id = null)
        {
            EducationdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Educations
                           where tb.ID == id
                           select new EducationdetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public EducationdetailVM getData(int? id = null)
        public List<EducationlookupVM> getDatalist_lookup()
        {
            List<EducationlookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Educations
                           select new EducationlookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EducationlookupVM> getDatalist_lookup()

    } //End public class EducationDS
} //End namespace APPBASE.Models

