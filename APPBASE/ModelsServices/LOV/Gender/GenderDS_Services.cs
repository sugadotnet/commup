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
    public class GenderDS
    {
        //Constructor
        public GenderDS() { } //End public GenderDS
        public List<GenderlistVM> getDatalist()
        {
            List<GenderlistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Genders
                           select new GenderlistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<GenderlistVM> getDatalist()
        public GenderdetailVM getData(int? id = null)
        {
            GenderdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Genders
                           where tb.ID == id
                           select new GenderdetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public GenderdetailVM getData(int? id = null)

        public List<GenderlookupVM> getDatalist_lookup()
        {
            List<GenderlookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Genders
                           select new GenderlookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<GenderlookupVM> getDatalist_lookup()
    } //End public class GenderDS
} //End namespace APPBASE.Models
