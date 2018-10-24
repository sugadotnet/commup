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
    public class ProdtypeDS
    {
        //Constructor
        public ProdtypeDS() { } //End public ProdtypeDS
        public List<ProdtypeVM> getDatalist()
        {
            List<ProdtypeVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Prodtype_infos
                           select new ProdtypeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProdtypelistVM> getDatalist()
        public ProdtypeVM getData(int? id = null)
        {
            ProdtypeVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Prodtype_infos
                           where tb.ID == id
                           select new ProdtypeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public ProdtypedetailVM getData(int? id = null)


        public List<ProdtypeVM> getDatalist_lookup()
        {
            List<ProdtypeVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Prodtype_infos
                           select new ProdtypeVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProdtypelookupVM> getDatalist_lookup()
    } //End public class ProdtypeDS
} //End namespace APPBASE.Models
