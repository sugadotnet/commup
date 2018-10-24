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
    public class IncometypeDS
    {
        //Constructor
        public IncometypeDS() { } //End public IncometypeDS
        public List<IncometypelistVM> getDatalist()
        {
            List<IncometypelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Incometypes
                           select new IncometypelistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<IncometypelistVM> getDatalist()
        public IncometypedetailVM getData(int? id = null)
        {
            IncometypedetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Incometypes
                           where tb.ID == id
                           select new IncometypedetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public IncometypedetailVM getData(int? id = null)


        public List<IncometypelookupVM> getDatalist_lookup()
        {
            List<IncometypelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Incometypes
                           select new IncometypelookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<IncometypelookupVM> getDatalist_lookup()
    } //End public class IncometypeDS
} //End namespace APPBASE.Models
