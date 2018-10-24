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
    public class RolemenuDS
    {
        //Constructor
        public RolemenuDS() { } //End public RolemenuDS
        public List<RolemenulistVM> getDatalist()
        {
            List<RolemenulistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Rolemenus
                           select new RolemenulistVM
                           {
                               ID = tb.ID,
                               ROLE_ID = tb.ROLE_ID,
                               MNU_ID = tb.MNU_ID
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<RolemenulistVM> getDatalist()
        public RolemenudetailVM getData(int? id = null)
        {
            RolemenudetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Rolemenus
                           where tb.ID == id
                           select new RolemenudetailVM
                           {
                               ID = tb.ID,
                               MDLE_ID = tb.MDLE_ID,
                               ROLE_ID = tb.ROLE_ID,
                               MNU_ID = tb.MNU_ID
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public RolemenudetailVM getData(int? id = null)


        public List<RolemenulookupVM> getDatalist_lookup()
        {
            List<RolemenulookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Rolemenus
                           select new RolemenulookupVM
                           {
                               ID = tb.ID
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<RolemenulookupVM> getDatalist_lookup()


        //Check Granted user to menu
        public Boolean isGranted_menu(int? pnRoleId = null, int? pnMenuId = null)
        {
            Boolean vReturn = false;

            using (var db = new DBMAINContext())
            {
                var oQRY = (from tb in db.Rolemenus
                            where tb.ROLE_ID == pnRoleId && tb.MNU_ID == pnMenuId
                            select new { MNU_ID = tb.MNU_ID }).ToList();

                if (oQRY.Count > 0) { vReturn = true; }
            } //End using (var = new DbContext())
            return vReturn;
        } //End public Boolean isExists_USR_ID(string id = null)
    } //End public class RolemenuDS
} //End namespace APPBASE.Models
