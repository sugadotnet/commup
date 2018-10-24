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
    public class MonthDS
    {
        private DBMAINContext db;
        public IQueryable<MonthVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<MonthVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public MonthDS() { this.db = new DBMAINContext(); } //End Constructor MonthDS
        //Constructor 2
        public MonthDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor
        private IQueryable<MonthVM> fieldAll()
        {
            IQueryable<MonthVM> vReturn;

            var oQRY = from tb in this.db.Month_infos
                       select new MonthVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           MONTH_CODE = tb.MONTH_CODE,
                           MONTH_SHORTDESC = tb.MONTH_SHORTDESC,
                           MONTH_DESC = tb.MONTH_DESC,
                           MONTH_NUM = tb.MONTH_NUM,
                           MONTH_SEQNO = tb.MONTH_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<MonthVM> fieldLookup()
        {
            IQueryable<MonthVM> vReturn;

            var oQRY = from tb in this.db.Month_infos
                       select new MonthVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           MONTH_CODE = tb.MONTH_CODE,
                           MONTH_SHORTDESC = tb.MONTH_SHORTDESC,
                           MONTH_DESC = tb.MONTH_DESC,
                           MONTH_NUM = tb.MONTH_NUM,
                           MONTH_SEQNO = tb.MONTH_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<MonthVM> fieldIndex()
        {
            IQueryable<MonthVM> vReturn;

            var oQRY = from tb in this.db.Month_infos
                       select new MonthVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           MONTH_CODE = tb.MONTH_CODE,
                           MONTH_SHORTDESC = tb.MONTH_SHORTDESC,
                           MONTH_DESC = tb.MONTH_DESC,
                           MONTH_NUM = tb.MONTH_NUM,
                           MONTH_SEQNO = tb.MONTH_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method


        public List<MonthVM> getDatalist(IQueryable<MonthVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<MonthVM> getDatalist_lookup(IQueryable<MonthVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End Method
        public MonthVM getData(int? id, IQueryable<MonthVM> poFieldsToselect = null)
        {
            IQueryable<MonthVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
    } //End Class
} //End namespace
