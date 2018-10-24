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
    public class MaritalDS
    {
        //Constructor
        public MaritalDS() { } //End public MaritalDS
        public List<MaritallistVM> getDatalist()
        {
            List<MaritallistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Maritals
                           select new MaritallistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<MaritallistVM> getDatalist()
        public MaritaldetailVM getData(int? id = null)
        {
            MaritaldetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Maritals
                           where tb.ID == id
                           select new MaritaldetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public MaritaldetailVM getData(int? id = null)


        public List<MaritallookupVM> getDatalist_lookup()
        {
            List<MaritallookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Maritals
                           select new MaritallookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<MaritallookupVM> getDatalist_lookup()
    } //End public class MaritalDS
} //End namespace APPBASE.Models
