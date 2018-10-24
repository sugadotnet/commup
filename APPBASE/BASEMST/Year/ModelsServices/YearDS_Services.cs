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
    public class YearDS
    {
        private DBMAINContext db;
        public IQueryable<YearVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<YearVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public YearDS() { this.db = new DBMAINContext(); } //End Constructor YearDS
        //Constructor 2
        public YearDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor
        private IQueryable<YearVM> fieldAll()
        {
            IQueryable<YearVM> vReturn;

            var oQRY = from tb in this.db.Year_infos
                       select new YearVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           YEAR_CODE = tb.YEAR_CODE,
                           YEAR_SHORTDESC = tb.YEAR_SHORTDESC,
                           YEAR_DESC = tb.YEAR_DESC,
                           YEAR_FROM = tb.YEAR_FROM,
                           YEAR_TO = tb.YEAR_TO,
                           YEAR_NUM = tb.YEAR_NUM
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<YearVM> fieldLookup()
        {
            IQueryable<YearVM> vReturn;

            var oQRY = from tb in this.db.Year_infos
                       select new YearVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           YEAR_CODE = tb.YEAR_CODE,
                           YEAR_SHORTDESC = tb.YEAR_SHORTDESC,
                           YEAR_DESC = tb.YEAR_DESC,
                           YEAR_FROM = tb.YEAR_FROM,
                           YEAR_TO = tb.YEAR_TO,
                           YEAR_NUM = tb.YEAR_NUM
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<YearVM> fieldIndex()
        {
            IQueryable<YearVM> vReturn;

            var oQRY = from tb in this.db.Year_infos
                       select new YearVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           YEAR_CODE = tb.YEAR_CODE,
                           YEAR_SHORTDESC = tb.YEAR_SHORTDESC,
                           YEAR_DESC = tb.YEAR_DESC,
                           YEAR_FROM = tb.YEAR_FROM,
                           YEAR_TO = tb.YEAR_TO,
                           YEAR_NUM = tb.YEAR_NUM
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method


        public List<YearVM> getDatalist(IQueryable<YearVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<YearVM> getDatalist_lookup(IQueryable<YearVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End Method
        public YearVM getData(int? id, IQueryable<YearVM> poFieldsToselect = null)
        {
            IQueryable<YearVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
    } //End Class
} //End namespace
