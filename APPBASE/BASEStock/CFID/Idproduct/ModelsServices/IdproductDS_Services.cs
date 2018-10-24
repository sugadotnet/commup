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
using APPBASE.Svcapp;

namespace APPBASE.Models
{
    public class IdproductDS
    {
        private DBMAINContext db;
        public IQueryable<IdproductVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<IdproductVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public IdproductDS() { this.db = new DBMAINContext(); } //End Constructor IdproductDS
        //Constructor 2
        public IdproductDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor
        private IQueryable<IdproductVM> fieldAll()
        {
            IQueryable<IdproductVM> vReturn;

            var oQRY = from tb in this.db.Idproduct_infos
                       select new IdproductVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           ID_COUNTER = tb.ID_COUNTER,
                           ID_YEAR = tb.ID_YEAR,
                           ID_MONTH = tb.ID_MONTH,
                           ID_LAST = tb.ID_LAST,
                           ID_CURRENT = tb.ID_CURRENT
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<IdproductVM> fieldLookup()
        {
            IQueryable<IdproductVM> vReturn;

            var oQRY = from tb in this.db.Idproduct_infos
                       select new IdproductVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           ID_COUNTER = tb.ID_COUNTER,
                           ID_YEAR = tb.ID_YEAR,
                           ID_MONTH = tb.ID_MONTH,
                           ID_LAST = tb.ID_LAST,
                           ID_CURRENT = tb.ID_CURRENT
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<IdproductVM> fieldIndex()
        {
            IQueryable<IdproductVM> vReturn;

            var oQRY = from tb in this.db.Idproduct_infos
                       select new IdproductVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           ID_COUNTER = tb.ID_COUNTER,
                           ID_YEAR = tb.ID_YEAR,
                           ID_MONTH = tb.ID_MONTH,
                           ID_LAST = tb.ID_LAST,
                           ID_CURRENT = tb.ID_CURRENT
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method


        public List<IdproductVM> getDatalist(IQueryable<IdproductVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<IdproductVM> getDatalist_lookup(IQueryable<IdproductVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End Method
        public IdproductVM getData(int? id, IQueryable<IdproductVM> poFieldsToselect = null)
        {
            IQueryable<IdproductVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
    } //End Class
} //End namespace
