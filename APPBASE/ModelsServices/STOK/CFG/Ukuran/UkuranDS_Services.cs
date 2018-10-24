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
    public class UkuranDS
    {
        //Constructor
        public UkuranDS() { } //End public UkuranDS
        public List<UkuranVM> getDatalist()
        {
            List<UkuranVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Ukuran_infos
                           select new UkuranVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               UKURAN_CODE = tb.UKURAN_CODE,
                               UKURAN_NAME = tb.UKURAN_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<UkuranlistVM> getDatalist()
        public UkuranVM getData(int? id = null)
        {
            UkuranVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Ukuran_infos
                           where tb.ID == id
                           select new UkuranVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               UKURAN_CODE = tb.UKURAN_CODE,
                               UKURAN_NAME = tb.UKURAN_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public UkurandetailVM getData(int? id = null)


        public List<UkuranVM> getDatalist_lookup()
        {
            List<UkuranVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Ukuran_infos
                           select new UkuranVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               UKURAN_CODE = tb.UKURAN_CODE,
                               UKURAN_NAME = tb.UKURAN_NAME
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<UkuranlookupVM> getDatalist_lookup()
    } //End public class UkuranDS
} //End namespace APPBASE.Models
