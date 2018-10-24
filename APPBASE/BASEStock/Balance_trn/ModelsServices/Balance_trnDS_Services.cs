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
    public class Balance_trnDS
    {
        private DBMAINContext db;
        public IQueryable<Balance_trnVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<Balance_trnVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public Balance_trnDS() { this.db = new DBMAINContext(); } //End Constructor Balance_trnDS
        //Constructor 2
        public Balance_trnDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor
        private IQueryable<Balance_trnVM> fieldAll()
        {
            IQueryable<Balance_trnVM> vReturn;

            var oQRY = from tb in this.db.Balance_trn_infos
                       select new Balance_trnVM
                       {
                           ID = tb.ID,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH,
                           TRN_YEARMONTH_S = tb.TRN_YEARMONTH_S,
                           TRN_QTY = tb.TRN_QTY,
                           TRN_GROSSAMOUNT = tb.TRN_GROSSAMOUNT,
                           TRN_AMOUNT = tb.TRN_AMOUNT,
                           TRN_AFTERTAXAMOUNT = tb.TRN_AFTERTAXAMOUNT,
                           PROD_ID = tb.PROD_ID,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           COUNTRY_CODE = tb.COUNTRY_CODE,
                           COUNTRY_NAME = tb.COUNTRY_NAME,
                           VENDOR_ID = tb.VENDOR_ID,
                           VENDOR_CODE = tb.VENDOR_CODE,
                           VENDOR_NAME = tb.VENDOR_NAME,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODTYPE_CODE = tb.PRODTYPE_CODE,
                           PRODTYPE_NAME = tb.PRODTYPE_NAME,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                           PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                           SERIAL_ID = tb.SERIAL_ID,
                           SERIAL_CODE = tb.SERIAL_CODE,
                           SERIAL_NAME = tb.SERIAL_NAME,
                           UKURAN_ID = tb.UKURAN_ID,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_ID = tb.UOM_ID,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<Balance_trnVM> fieldLookup()
        {
            IQueryable<Balance_trnVM> vReturn;

            var oQRY = from tb in this.db.Balance_trn_infos
                       select new Balance_trnVM
                       {
                           ID = tb.ID,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH,
                           TRN_YEARMONTH_S = tb.TRN_YEARMONTH_S,
                           TRN_QTY = tb.TRN_QTY,
                           TRN_GROSSAMOUNT = tb.TRN_GROSSAMOUNT,
                           TRN_AMOUNT = tb.TRN_AMOUNT,
                           TRN_AFTERTAXAMOUNT = tb.TRN_AFTERTAXAMOUNT,
                           PROD_ID = tb.PROD_ID,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           COUNTRY_CODE = tb.COUNTRY_CODE,
                           COUNTRY_NAME = tb.COUNTRY_NAME,
                           VENDOR_ID = tb.VENDOR_ID,
                           VENDOR_CODE = tb.VENDOR_CODE,
                           VENDOR_NAME = tb.VENDOR_NAME,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODTYPE_CODE = tb.PRODTYPE_CODE,
                           PRODTYPE_NAME = tb.PRODTYPE_NAME,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                           PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                           SERIAL_ID = tb.SERIAL_ID,
                           SERIAL_CODE = tb.SERIAL_CODE,
                           SERIAL_NAME = tb.SERIAL_NAME,
                           UKURAN_ID = tb.UKURAN_ID,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_ID = tb.UOM_ID,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<Balance_trnVM> fieldIndex()
        {
            IQueryable<Balance_trnVM> vReturn;

            var oQRY = from tb in this.db.Balance_trn_infos
                       select new Balance_trnVM
                       {
                           ID = tb.ID,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH,
                           TRN_YEARMONTH_S = tb.TRN_YEARMONTH_S,
                           TRN_QTY = tb.TRN_QTY,
                           TRN_GROSSAMOUNT = tb.TRN_GROSSAMOUNT,
                           TRN_AMOUNT = tb.TRN_AMOUNT,
                           TRN_AFTERTAXAMOUNT = tb.TRN_AFTERTAXAMOUNT,
                           PROD_ID = tb.PROD_ID,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           COUNTRY_CODE = tb.COUNTRY_CODE,
                           COUNTRY_NAME = tb.COUNTRY_NAME,
                           VENDOR_ID = tb.VENDOR_ID,
                           VENDOR_CODE = tb.VENDOR_CODE,
                           VENDOR_NAME = tb.VENDOR_NAME,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODTYPE_CODE = tb.PRODTYPE_CODE,
                           PRODTYPE_NAME = tb.PRODTYPE_NAME,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                           PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                           SERIAL_ID = tb.SERIAL_ID,
                           SERIAL_CODE = tb.SERIAL_CODE,
                           SERIAL_NAME = tb.SERIAL_NAME,
                           UKURAN_ID = tb.UKURAN_ID,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_ID = tb.UOM_ID,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method

        public List<Balance_trnVM> getDatalist(IQueryable<Balance_trnVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<Balance_trnVM> getDatalist_until(IQueryable<Balance_trnVM> poFieldsToselect = null, int? pnYear = null, int? pnMonth = null)
        {
            IQueryable<Balance_trnVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            int? nYearmonth = null;
            if ((pnYear != null) && (pnMonth != null))
            {
                string sYear = pnYear.ToString().PadLeft(4, '0');
                string sMonth = pnMonth.ToString().PadLeft(2, '0');
                nYearmonth = Convert.ToInt32(sYear + sMonth);
                oQRY = oQRY.Where(fld => fld.TRN_YEARMONTH <= nYearmonth);
            } //end if

            return oQRY.ToList();
        } //End Method
        public List<Balance_trnVM> getDatalist_current(IQueryable<Balance_trnVM> poFieldsToselect = null, int? pnYear = null, int? pnMonth = null)
        {
            IQueryable<Balance_trnVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            int? nYearmonth = null;
            if ((pnYear != null) && (pnMonth != null))
            {
                string sYear = pnYear.ToString().PadLeft(4, '0');
                string sMonth = pnMonth.ToString().PadLeft(2, '0');
                nYearmonth = Convert.ToInt32(sYear + sMonth);
                oQRY = oQRY.Where(fld => fld.TRN_YEARMONTH == nYearmonth);
            } //end if

            return oQRY.ToList();
        } //End Method
        public List<Balance_trnVM> getDatalist_lookup(IQueryable<Balance_trnVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End Method
        public Balance_trnVM getData(int? id, IQueryable<Balance_trnVM> poFieldsToselect = null)
        {
            IQueryable<Balance_trnVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
    } //End Class
} //End namespace
