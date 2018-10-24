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
    public class VendorDS
    {
        //Constructor
        public VendorDS() { } //End public VendorDS
        public List<VendorVM> getDatalist()
        {
            List<VendorVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Vendor_infos
                           select new VendorVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               VENDOR_CODE = tb.VENDOR_CODE,
                               VENDOR_NAME = tb.VENDOR_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<VendorlistVM> getDatalist()
        public VendorVM getData(int? id = null)
        {
            VendorVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Vendor_infos
                           where tb.ID == id
                           select new VendorVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               VENDOR_CODE = tb.VENDOR_CODE,
                               VENDOR_NAME = tb.VENDOR_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public VendordetailVM getData(int? id = null)


        public List<VendorVM> getDatalist_lookup()
        {
            List<VendorVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Vendor_infos
                           select new VendorVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               VENDOR_CODE = tb.VENDOR_CODE,
                               VENDOR_NAME = tb.VENDOR_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<VendorlookupVM> getDatalist_lookup()
    } //End public class VendorDS
} //End namespace APPBASE.Models
