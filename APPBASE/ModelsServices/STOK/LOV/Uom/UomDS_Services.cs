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
    public class UomDS
    {
        //Constructor
        public UomDS() { } //End public UomDS
        public List<UomVM> getDatalist()
        {
            List<UomVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Uom_infos
                           select new UomVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SYM = tb.LOV_SYM,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<UomlistVM> getDatalist()
        public UomVM getData(int? id = null)
        {
            UomVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Uom_infos
                           where tb.ID == id
                           select new UomVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SYM = tb.LOV_SYM,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public UomdetailVM getData(int? id = null)


        public List<UomVM> getDatalist_lookup()
        {
            List<UomVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Uom_infos
                           select new UomVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC,
                               LOV_SYM = tb.LOV_SYM,
                               LOV_SEQNO = tb.LOV_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<UomlookupVM> getDatalist_lookup()
    } //End public class UomDS
} //End namespace APPBASE.Models
