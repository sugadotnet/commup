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
    public class AttendanceDS
    {
        //Constructor
        public AttendanceDS() { } //End public AttendanceDS
        public List<AttendancelistVM> getDatalist()
        {
            List<AttendancelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Attendances
                           select new AttendancelistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<AttendancelistVM> getDatalist()
        public AttendancedetailVM getData(int? id = null)
        {
            AttendancedetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Attendances
                           where tb.ID == id
                           select new AttendancedetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public AttendancedetailVM getData(int? id = null)


        public List<AttendancelookupVM> getDatalist_lookup()
        {
            List<AttendancelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Attendances
                           select new AttendancelookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<AttendancelookupVM> getDatalist_lookup()
    } //End public class AttendanceDS
} //End namespace APPBASE.Models

