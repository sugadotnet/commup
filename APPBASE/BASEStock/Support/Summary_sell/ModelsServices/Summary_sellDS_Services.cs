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
    public class Summary_sellDS
    {
        private DBMAINContext db;
        public IQueryable<Summary_sellVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<Summary_sellVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public Summary_sellDS() { this.db = new DBMAINContext(); } //End Constructor Summary_sellDS
        //Constructor 2
        public Summary_sellDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor
        private IQueryable<Summary_sellVM> fieldAll()
        {
            IQueryable<Summary_sellVM> vReturn;

            var oQRY = from tb in this.db.Summary_sell_infos
                       select new Summary_sellVM
                       {
                           ID = tb.ID,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           MONTH_CODE = tb.MONTH_CODE,
                           MONTH_SHORTDESC = tb.MONTH_SHORTDESC,
                           MONTH_DESC = tb.MONTH_DESC,
                           MONTH_NUM = tb.MONTH_NUM,
                           MONTH_SEQNO = tb.MONTH_SEQNO,
                           PROD_ID = tb.PROD_ID,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           TRND_QTY = tb.TRND_QTY,
                           TRND_GROSSAMOUNT = tb.TRND_GROSSAMOUNT,
                           TRND_TAXAMOUNT = tb.TRND_TAXAMOUNT,
                           TRND_AFTERTAXAMOUNT = tb.TRND_AFTERTAXAMOUNT,
                           TRND_DISCAMOUNT = tb.TRND_DISCAMOUNT,
                           TRND_AMOUNT = tb.TRND_AMOUNT
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<Summary_sellVM> fieldLookup()
        {
            IQueryable<Summary_sellVM> vReturn;

            var oQRY = from tb in this.db.Summary_sell_infos
                       select new Summary_sellVM
                       {
                           ID = tb.ID,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           MONTH_CODE = tb.MONTH_CODE,
                           MONTH_SHORTDESC = tb.MONTH_SHORTDESC,
                           MONTH_DESC = tb.MONTH_DESC,
                           MONTH_NUM = tb.MONTH_NUM,
                           MONTH_SEQNO = tb.MONTH_SEQNO,
                           PROD_ID = tb.PROD_ID,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           TRND_QTY = tb.TRND_QTY,
                           TRND_GROSSAMOUNT = tb.TRND_GROSSAMOUNT,
                           TRND_TAXAMOUNT = tb.TRND_TAXAMOUNT,
                           TRND_AFTERTAXAMOUNT = tb.TRND_AFTERTAXAMOUNT,
                           TRND_DISCAMOUNT = tb.TRND_DISCAMOUNT,
                           TRND_AMOUNT = tb.TRND_AMOUNT
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<Summary_sellVM> fieldIndex()
        {
            IQueryable<Summary_sellVM> vReturn;

            var oQRY = from tb in this.db.Summary_sell_infos
                       select new Summary_sellVM
                       {
                           ID = tb.ID,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           MONTH_CODE = tb.MONTH_CODE,
                           MONTH_SHORTDESC = tb.MONTH_SHORTDESC,
                           MONTH_DESC = tb.MONTH_DESC,
                           MONTH_NUM = tb.MONTH_NUM,
                           MONTH_SEQNO = tb.MONTH_SEQNO,
                           PROD_ID = tb.PROD_ID,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           TRND_QTY = tb.TRND_QTY,
                           TRND_GROSSAMOUNT = tb.TRND_GROSSAMOUNT,
                           TRND_TAXAMOUNT = tb.TRND_TAXAMOUNT,
                           TRND_AFTERTAXAMOUNT = tb.TRND_AFTERTAXAMOUNT,
                           TRND_DISCAMOUNT = tb.TRND_DISCAMOUNT,
                           TRND_AMOUNT = tb.TRND_AMOUNT
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method


        public List<Summary_sellVM> getDatalist(IQueryable<Summary_sellVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<Summary_sellVM> getDatalist_byYear(int? pnYEAR, IQueryable<Summary_sellVM> poFieldsToselect = null)
        {
            IQueryable<Summary_sellVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();
            return oQRY.Where(fld => fld.TRN_YEAR == pnYEAR).ToList();
        } //End Method

        public List<Summary_sellVM> getDatalist_lookup(IQueryable<Summary_sellVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End Method
        public Summary_sellVM getData(int? id, IQueryable<Summary_sellVM> poFieldsToselect = null)
        {
            IQueryable<Summary_sellVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
    } //End Class
} //End namespace
