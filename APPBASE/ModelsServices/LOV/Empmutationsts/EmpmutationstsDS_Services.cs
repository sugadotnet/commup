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
    public class EmpmutationstsDS
    {
        //Constructor
        public EmpmutationstsDS() { } //End public EmpmutationstsDS
        public List<EmpmutationstslistVM> getDatalist()
        {
            List<EmpmutationstslistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Empmutationstss
                           select new EmpmutationstslistVM
                           {
                               ID = tb.ID,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EmpmutationstslistVM> getDatalist()
        public EmpmutationstsdetailVM getData(int? id = null)
        {
            EmpmutationstsdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Empmutationstss
                           where tb.ID == id
                           select new EmpmutationstsdetailVM
                           {
                               ID = tb.ID,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public EmpmutationstsdetailVM getData(int? id = null)


        public List<EmpmutationstslookupVM> getDatalist_lookup()
        {
            List<EmpmutationstslookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Empmutationstss
                           select new EmpmutationstslookupVM
                           {
                               ID = tb.ID,
                               LOV_CODE = tb.LOV_CODE,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EmpmutationstslookupVM> getDatalist_lookup()
    } //End public class EmpmutationstsDS
} //End namespace APPBASE.Models
