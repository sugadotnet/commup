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
    public partial class TrnstockdDS
    {
        private DBMAINContext db;
        public IQueryable<TrnstockdVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<TrnstockdVM> FIELD_INDEX { get { return this.fieldIndex(); } }
        public IQueryable<TrnstockdVM> FIELD_SUMQTY {
            get  { return from tb in this.db.Trnstockd_infos
                         select new TrnstockdVM { TRN_DT = tb.TRN_DT, TRN_TYPEID = tb.TRN_TYPEID, TRND_QTY = tb.TRND_QTY };
            } //end get
        } //end prop


        //Constructor 1
        public TrnstockdDS() {
            this.db = new DBMAINContext();
        } //End Constructor 1
        //Constructor 2
        public TrnstockdDS(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End Constructor 2
        //Encapsulated methods
        private IQueryable<TrnstockdVM> fieldAll()
        {
            IQueryable<TrnstockdVM> vReturn;

            var oQRY = from tb in db.Trnstockd_infos
                       select new TrnstockdVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           TRN_ID = tb.TRN_ID,
                           TRND_QTY = tb.TRND_QTY,
                           TRND_PRICE = tb.TRND_PRICE,
                           TRND_GROSSAMOUNT = tb.TRND_GROSSAMOUNT,
                           TRND_TAXRATE = tb.TRND_TAXRATE,
                           TRND_TAXAMOUNT = tb.TRND_TAXAMOUNT,
                           TRND_AFTERTAXAMOUNT = tb.TRND_AFTERTAXAMOUNT,
                           TRND_DISCRATE = tb.TRND_DISCRATE,
                           TRND_DISCAMOUNT = tb.TRND_DISCAMOUNT,
                           TRND_AMOUNT = tb.TRND_AMOUNT,
                           TRND_DESC = tb.TRND_DESC,
                           PROD_ID = tb.PROD_ID,
                           PRODSTOCK_ID = tb.PRODSTOCK_ID,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           CACHE_PROD_CODE = tb.CACHE_PROD_CODE,
                           CACHE_PROD_NAME = tb.CACHE_PROD_NAME,
                           CACHE_PROD_PRICE_BASE = tb.CACHE_PROD_PRICE_BASE,
                           CACHE_PROD_PRICE_SELL = tb.CACHE_PROD_PRICE_SELL,
                           CACHE_PROD_PRICEDT = tb.CACHE_PROD_PRICEDT,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           PROD_PRICE_BASE = tb.PROD_PRICE_BASE,
                           PROD_PRICE_SELL = tb.PROD_PRICE_SELL,
                           PROD_PRICEDT = tb.PROD_PRICEDT,
                           PROD_STS = tb.PROD_STS,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           VENDOR_ID = tb.VENDOR_ID,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           SERIAL_ID = tb.SERIAL_ID,
                           UKURAN_ID = tb.UKURAN_ID,
                           UOM_ID = tb.UOM_ID,
                           COUNTRY_CODE = tb.COUNTRY_CODE,
                           COUNTRY_NAME = tb.COUNTRY_NAME,
                           VENDOR_CODE = tb.VENDOR_CODE,
                           VENDOR_NAME = tb.VENDOR_NAME,
                           PRODTYPE_CODE = tb.PRODTYPE_CODE,
                           PRODTYPE_NAME = tb.PRODTYPE_NAME,
                           PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                           PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                           SERIAL_CODE = tb.SERIAL_CODE,
                           SERIAL_NAME = tb.SERIAL_NAME,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           UOM_SEQNO = tb.UOM_SEQNO,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_BASESEQNO = tb.STORAGE_BASESEQNO,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME,
                           STORAGE_TARGETSEQNO = tb.STORAGE_TARGETSEQNO,
                           TRN_STS = tb.TRN_STS,
                           TRN_TYPEID = tb.TRN_TYPEID,
                           TRNTYPE_CODE = tb.TRNTYPE_CODE,
                           TRNTYPE_NAME = tb.TRNTYPE_NAME,
                           TRN_SUBTYPEID = tb.TRN_SUBTYPEID,
                           TRN_DT = tb.TRN_DT,
                           TRN_CODE = tb.TRN_CODE,
                           TRN_GIVER = tb.TRN_GIVER,
                           TRN_RECIPIENT = tb.TRN_RECIPIENT,
                           TRN_DESC = tb.TRN_DESC,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<TrnstockdVM> fieldLookup()
        {
            IQueryable<TrnstockdVM> vReturn;

            var oQRY = from tb in db.Trnstockd_infos
                       select new TrnstockdVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           TRN_ID = tb.TRN_ID,
                           TRND_QTY = tb.TRND_QTY,
                           TRND_PRICE = tb.TRND_PRICE,
                           TRND_GROSSAMOUNT = tb.TRND_GROSSAMOUNT,
                           TRND_TAXRATE = tb.TRND_TAXRATE,
                           TRND_TAXAMOUNT = tb.TRND_TAXAMOUNT,
                           TRND_AFTERTAXAMOUNT = tb.TRND_AFTERTAXAMOUNT,
                           TRND_DISCRATE = tb.TRND_DISCRATE,
                           TRND_DISCAMOUNT = tb.TRND_DISCAMOUNT,
                           TRND_AMOUNT = tb.TRND_AMOUNT,
                           TRND_DESC = tb.TRND_DESC,
                           PROD_ID = tb.PROD_ID,
                           PRODSTOCK_ID = tb.PRODSTOCK_ID,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           CACHE_PROD_CODE = tb.CACHE_PROD_CODE,
                           CACHE_PROD_NAME = tb.CACHE_PROD_NAME,
                           CACHE_PROD_PRICE_BASE = tb.CACHE_PROD_PRICE_BASE,
                           CACHE_PROD_PRICE_SELL = tb.CACHE_PROD_PRICE_SELL,
                           CACHE_PROD_PRICEDT = tb.CACHE_PROD_PRICEDT,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           PROD_PRICE_BASE = tb.PROD_PRICE_BASE,
                           PROD_PRICE_SELL = tb.PROD_PRICE_SELL,
                           PROD_PRICEDT = tb.PROD_PRICEDT,
                           PROD_STS = tb.PROD_STS,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           VENDOR_ID = tb.VENDOR_ID,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           SERIAL_ID = tb.SERIAL_ID,
                           UKURAN_ID = tb.UKURAN_ID,
                           UOM_ID = tb.UOM_ID,
                           COUNTRY_CODE = tb.COUNTRY_CODE,
                           COUNTRY_NAME = tb.COUNTRY_NAME,
                           VENDOR_CODE = tb.VENDOR_CODE,
                           VENDOR_NAME = tb.VENDOR_NAME,
                           PRODTYPE_CODE = tb.PRODTYPE_CODE,
                           PRODTYPE_NAME = tb.PRODTYPE_NAME,
                           PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                           PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                           SERIAL_CODE = tb.SERIAL_CODE,
                           SERIAL_NAME = tb.SERIAL_NAME,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           UOM_SEQNO = tb.UOM_SEQNO,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_BASESEQNO = tb.STORAGE_BASESEQNO,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME,
                           STORAGE_TARGETSEQNO = tb.STORAGE_TARGETSEQNO,
                           TRN_STS = tb.TRN_STS,
                           TRN_TYPEID = tb.TRN_TYPEID,
                           TRNTYPE_CODE = tb.TRNTYPE_CODE,
                           TRNTYPE_NAME = tb.TRNTYPE_NAME,
                           TRN_SUBTYPEID = tb.TRN_SUBTYPEID,
                           TRN_DT = tb.TRN_DT,
                           TRN_CODE = tb.TRN_CODE,
                           TRN_GIVER = tb.TRN_GIVER,
                           TRN_RECIPIENT = tb.TRN_RECIPIENT,
                           TRN_DESC = tb.TRN_DESC,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<TrnstockdVM> fieldIndex()
        {
            IQueryable<TrnstockdVM> vReturn;

            var oQRY = from tb in db.Trnstockd_infos
                       select new TrnstockdVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           TRN_ID = tb.TRN_ID,
                           TRND_QTY = tb.TRND_QTY,
                           TRND_PRICE = tb.TRND_PRICE,
                           TRND_GROSSAMOUNT = tb.TRND_GROSSAMOUNT,
                           TRND_TAXRATE = tb.TRND_TAXRATE,
                           TRND_TAXAMOUNT = tb.TRND_TAXAMOUNT,
                           TRND_AFTERTAXAMOUNT = tb.TRND_AFTERTAXAMOUNT,
                           TRND_DISCRATE = tb.TRND_DISCRATE,
                           TRND_DISCAMOUNT = tb.TRND_DISCAMOUNT,
                           TRND_AMOUNT = tb.TRND_AMOUNT,
                           TRND_DESC = tb.TRND_DESC,
                           PROD_ID = tb.PROD_ID,
                           PRODSTOCK_ID = tb.PRODSTOCK_ID,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           CACHE_PROD_CODE = tb.CACHE_PROD_CODE,
                           CACHE_PROD_NAME = tb.CACHE_PROD_NAME,
                           CACHE_PROD_PRICE_BASE = tb.CACHE_PROD_PRICE_BASE,
                           CACHE_PROD_PRICE_SELL = tb.CACHE_PROD_PRICE_SELL,
                           CACHE_PROD_PRICEDT = tb.CACHE_PROD_PRICEDT,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           PROD_PRICE_BASE = tb.PROD_PRICE_BASE,
                           PROD_PRICE_SELL = tb.PROD_PRICE_SELL,
                           PROD_PRICEDT = tb.PROD_PRICEDT,
                           PROD_STS = tb.PROD_STS,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           VENDOR_ID = tb.VENDOR_ID,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           SERIAL_ID = tb.SERIAL_ID,
                           UKURAN_ID = tb.UKURAN_ID,
                           UOM_ID = tb.UOM_ID,
                           COUNTRY_CODE = tb.COUNTRY_CODE,
                           COUNTRY_NAME = tb.COUNTRY_NAME,
                           VENDOR_CODE = tb.VENDOR_CODE,
                           VENDOR_NAME = tb.VENDOR_NAME,
                           PRODTYPE_CODE = tb.PRODTYPE_CODE,
                           PRODTYPE_NAME = tb.PRODTYPE_NAME,
                           PRODSUBTYPE_CODE = tb.PRODSUBTYPE_CODE,
                           PRODSUBTYPE_NAME = tb.PRODSUBTYPE_NAME,
                           SERIAL_CODE = tb.SERIAL_CODE,
                           SERIAL_NAME = tb.SERIAL_NAME,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           UOM_SEQNO = tb.UOM_SEQNO,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_BASESEQNO = tb.STORAGE_BASESEQNO,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME,
                           STORAGE_TARGETSEQNO = tb.STORAGE_TARGETSEQNO,
                           TRN_STS = tb.TRN_STS,
                           TRN_TYPEID = tb.TRN_TYPEID,
                           TRNTYPE_CODE = tb.TRNTYPE_CODE,
                           TRNTYPE_NAME = tb.TRNTYPE_NAME,
                           TRN_SUBTYPEID = tb.TRN_SUBTYPEID,
                           TRN_DT = tb.TRN_DT,
                           TRN_CODE = tb.TRN_CODE,
                           TRN_GIVER = tb.TRN_GIVER,
                           TRN_RECIPIENT = tb.TRN_RECIPIENT,
                           TRN_DESC = tb.TRN_DESC,
                           TRN_YEAR = tb.TRN_YEAR,
                           TRN_MONTH = tb.TRN_MONTH,
                           TRN_YEARMONTH = tb.TRN_YEARMONTH
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method

        public TrnstockdVM getData(int? id, IQueryable<TrnstockdVM> poFieldsToselect = null)
        {
            IQueryable<TrnstockdVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
        public List<TrnstockdVM> getDatalist(IQueryable<TrnstockdVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<TrnstockdVM> getDatalist_lookup(IQueryable<TrnstockdVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList(); 
            return this.fieldLookup().ToList();
        } //End Method
    } //End public class TrnstockdDS
} //End namespace APPBASE.Models
