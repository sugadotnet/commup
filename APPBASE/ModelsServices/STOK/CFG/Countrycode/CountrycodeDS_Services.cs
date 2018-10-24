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
    public class CountrycodeDS
    {
        //Constructor
        public CountrycodeDS() { } //End public CountrycodeDS
        public List<CountrycodeVM> getDatalist()
        {
            List<CountrycodeVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Countrycode_infos
                           select new CountrycodeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               COUNTRY_CODE = tb.COUNTRY_CODE,
                               COUNTRY_NAME = tb.COUNTRY_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<CountrycodelistVM> getDatalist()
        public CountrycodeVM getData(int? id = null)
        {
            CountrycodeVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Countrycode_infos
                           where tb.ID == id
                           select new CountrycodeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               COUNTRY_CODE = tb.COUNTRY_CODE,
                               COUNTRY_NAME = tb.COUNTRY_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public CountrycodedetailVM getData(int? id = null)


        public List<CountrycodeVM> getDatalist_lookup()
        {
            List<CountrycodeVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Countrycode_infos
                           select new CountrycodeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               COUNTRY_CODE = tb.COUNTRY_CODE,
                               COUNTRY_NAME = tb.COUNTRY_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<CountrycodelookupVM> getDatalist_lookup()
    } //End public class CountrycodeDS
} //End namespace APPBASE.Models
