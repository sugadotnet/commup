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
    public class CityDS
    {
        //Constructor
        public CityDS() { } //End public CityDS
        public List<CitylistVM> getDatalist()
        {
            List<CitylistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Citys
                           select new CitylistVM
                           {
                               ID = tb.ID,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<CitylistVM> getDatalist()
        public CitydetailVM getData(int? id = null)
        {
            CitydetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Citys
                           where tb.ID == id
                           select new CitydetailVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SEQNO = tb.LOV_SEQNO,
                               LOV_GROUP = tb.LOV_GROUP,
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public CitydetailVM getData(int? id = null)


        public List<CitylookupVM> getDatalist_lookup()
        {
            List<CitylookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Citys
                           select new CitylookupVM
                           {
                               ID = tb.ID,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC,
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<CitylookupVM> getDatalist_lookup()
    } //End public class CityDS
} //End namespace APPBASE.Models

