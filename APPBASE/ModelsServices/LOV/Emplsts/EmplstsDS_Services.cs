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
    public class EmplstsDS
    {
        //Constructor
        public EmplstsDS() { } //End public EmplstsDS
        public List<EmplstslistVM> getDatalist()
        {
            List<EmplstslistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Emplstss
                           select new EmplstslistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EmplstslistVM> getDatalist()
        public EmplstsdetailVM getData(int? id = null)
        {
            EmplstsdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Emplstss
                           where tb.ID == id
                           select new EmplstsdetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public EmplstsdetailVM getData(int? id = null)


        public List<EmplstslookupVM> getDatalist_lookup()
        {
            List<EmplstslookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Emplstss
                           select new EmplstslookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                vReturn = oQRY.OrderBy(fld => fld.LOV_SEQNO).ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EmplstslookupVM> getDatalist_lookup()
    } //End public class EmplstsDS
} //End namespace APPBASE.Models

