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
    public class ReligionDS
    {
        //Constructor
        public ReligionDS() { } //End public ReligionDS
        public List<ReligionlistVM> getDatalist()
        {
            List<ReligionlistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Religions
                           select new ReligionlistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ReligionlistVM> getDatalist()
        public ReligiondetailVM getData(int? id = null)
        {
            ReligiondetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Religions
                           where tb.ID == id
                           select new ReligiondetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public ReligiondetailVM getData(int? id = null)

        public List<ReligionlookupVM> getDatalist_lookup()
        {
            List<ReligionlookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Religions
                           select new ReligionlookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ReligionlookupVM> getDatalist_lookup()

    } //End public class ReligionDS
} //End namespace APPBASE.Models

