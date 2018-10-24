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
    public class RoleDS
    {
        //Constructor
        public RoleDS() { } //End public RoleDS
        public List<RolelistVM> getDatalist()
        {
            List<RolelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Roles
                           select new RolelistVM
                           {
                               ID = tb.ID,
                               ROLE_CD = tb.ROLE_CD,
                               DISPLAY_NAME = tb.DISPLAY_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<RolelistVM> getDatalist()
        public RoledetailVM getData(int? id = null)
        {
            RoledetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Roles
                           where tb.ID == id
                           select new RoledetailVM
                           {
                               ID = tb.ID,
                               MDLE_ID = tb.MDLE_ID,
                               ROLE_CD = tb.ROLE_CD,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               SEQNO = tb.SEQNO
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public RoledetailVM getData(int? id = null)
        public List<RolelookupVM> getDatalist_lookup()
        {
            List<RolelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Roles
                           select new RolelookupVM
                           {
                               ID = tb.ID,
                               ROLE_CD = tb.ROLE_CD,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               SEQNO = tb.SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<RolelookupVM> getDatalist_lookup()
        public List<RolelookupVM> getDatalistHQ_lookup()
        {
            List<RolelookupVM> vReturn;

            var idlist = new int?[] { 1,2,3};

            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Roles
                           select new RolelookupVM
                           {
                               ID = tb.ID,
                               ROLE_CD = tb.ROLE_CD,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               SEQNO = tb.SEQNO
                           };
                vReturn = oQRY.Where(fld=>idlist.Contains(fld.ID)).ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<RolelookupVM> getDatalistHQ_lookup()
        public List<RolelookupVM> getDatalistBRANCH_lookup()
        {
            List<RolelookupVM> vReturn;

            var idlist = new int?[] { 4, 5, 6 };

            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Roles
                           select new RolelookupVM
                           {
                               ID = tb.ID,
                               ROLE_CD = tb.ROLE_CD,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               SEQNO = tb.SEQNO
                           };
                vReturn = oQRY.Where(fld => idlist.Contains(fld.ID)).ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<RolelookupVM> getDatalistBRANCH_lookup()
    } //End public class RoleDS
} //End namespace APPBASE.Models
