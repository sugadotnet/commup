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
    public class ProdsubtypeDS
    {
        //Constructor
        public ProdsubtypeDS() { } //End public ProdsubtypeDS
        public List<ProdsubtypeVM> getDatalist(int? id = null)
        {
            List<ProdsubtypeVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Prodsubtype_infos
                           select new ProdsubtypeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                               PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                if (id != null) oQRY = oQRY.Where(fld => fld.PRODTYPE_ID == id);
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProdsubtypelistVM> getDatalist()
        public ProdsubtypeVM getData(int? id = null)
        {
            ProdsubtypeVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Prodsubtype_infos
                           where tb.ID == id
                           select new ProdsubtypeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                               PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public ProdsubtypedetailVM getData(int? id = null)


        public List<ProdsubtypeVM> getDatalist_lookup(int? ProdTypeId=null)
        {
            List<ProdsubtypeVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Prodsubtype_infos
                           select new ProdsubtypeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                               PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                if (ProdTypeId != null) oQRY = oQRY.Where(fld => fld.PRODTYPE_ID == ProdTypeId);
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProdsubtypelookupVM> getDatalist_lookup()
    } //End public class ProdsubtypeDS
} //End namespace APPBASE.Models
