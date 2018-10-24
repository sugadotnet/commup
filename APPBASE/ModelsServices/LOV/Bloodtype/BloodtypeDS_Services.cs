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
    public class BloodtypeDS
    {
        //Constructor
        public BloodtypeDS() { } //End public BloodtypeDS
        public List<BloodtypelistVM> getDatalist()
        {
            List<BloodtypelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Bloodtypes
                           select new BloodtypelistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<BloodtypelistVM> getDatalist()
        public BloodtypedetailVM getData(int? id = null)
        {
            BloodtypedetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Bloodtypes
                           where tb.ID == id
                           select new BloodtypedetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public BloodtypedetailVM getData(int? id = null)
        public List<BloodtypelookupVM> getDatalist_lookup()
        {
            List<BloodtypelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Bloodtypes
                           select new BloodtypelookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<BloodtypelookupVM> getDatalist_lookup()

    } //End public class BloodtypeDS
} //End namespace APPBASE.Models

