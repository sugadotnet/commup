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
    public class FinishingDS
    {
        //Constructor
        public FinishingDS() { } //End public FinishingDS
        public List<FinishingVM> getDatalist(int? id=null)
        {
            List<FinishingVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Finishing_infos
                           select new FinishingVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               FINISHING_CODE = tb.FINISHING_CODE,
                               FINISHING_NAME = tb.FINISHING_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                if (id != null) oQRY = oQRY.Where(fld => fld.PRODTYPE_ID == id);
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<FinishinglistVM> getDatalist()
        public FinishingVM getData(int? id = null)
        {
            FinishingVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Finishing_infos
                           where tb.ID == id
                           select new FinishingVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               FINISHING_CODE = tb.FINISHING_CODE,
                               FINISHING_NAME = tb.FINISHING_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public FinishingdetailVM getData(int? id = null)


        public List<FinishingVM> getDatalist_lookup(int? ProdTypeId=null)
        {
            List<FinishingVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Finishing_infos
                           select new FinishingVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               FINISHING_CODE = tb.FINISHING_CODE,
                               FINISHING_NAME = tb.FINISHING_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                if (ProdTypeId != null) oQRY = oQRY.Where(fld => fld.PRODTYPE_ID == ProdTypeId);
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<FinishinglookupVM> getDatalist_lookup()
    } //End public class FinishingDS
} //End namespace APPBASE.Models
