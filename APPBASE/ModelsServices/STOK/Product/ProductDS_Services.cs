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
    public class ProductDS
    {
        private DBMAINContext db;
        public IQueryable<ProductVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<ProductVM> FIELD_INDEX { get { return this.fieldIndex(); } }

        //Constructor 1
        public ProductDS() {
            this.db = new DBMAINContext();
        } //End public ProductDS
        //Constructor 2
        public ProductDS(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End public ProductstockDS(DBMAINContext poDBMAINContext)
        //Encapsulated methods
        private IQueryable<ProductVM> fieldAll()
        {
            IQueryable<ProductVM> vReturn;

            var oQRY = from tb in db.Product_infos
                       select new ProductVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           PROD_QTY = tb.PROD_QTY,
                           PROD_PRICE_BASE = tb.PROD_PRICE_BASE,
                           PROD_PRICE_SELL = tb.PROD_PRICE_SELL,
                           PROD_PRICEDT = tb.PROD_PRICEDT,
                           PROD_STS = tb.PROD_STS,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           VENDOR_ID = tb.VENDOR_ID,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           SERIAL_ID = tb.SERIAL_ID,
                           FINISHING_ID = tb.FINISHING_ID,
                           UKURAN_ID = tb.UKURAN_ID,
                           UOM_ID = tb.UOM_ID,
                           PRODNEW_ID = tb.PRODNEW_ID,
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
                           FINISHING_CODE = tb.FINISHING_CODE,
                           FINISHING_NAME = tb.FINISHING_NAME,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           UOM_SEQNO = tb.UOM_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End private IQueryable<ProductstockVM> fieldAll()
        private IQueryable<ProductVM> fieldLookup()
        {
            IQueryable<ProductVM> vReturn;

            var oQRY = from tb in db.Product_infos
                       select new ProductVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           PROD_QTY = tb.PROD_QTY,
                           PROD_PRICE_BASE = tb.PROD_PRICE_BASE,
                           PROD_PRICE_SELL = tb.PROD_PRICE_SELL,
                           PROD_PRICEDT = tb.PROD_PRICEDT,
                           PROD_STS = tb.PROD_STS,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           VENDOR_ID = tb.VENDOR_ID,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           SERIAL_ID = tb.SERIAL_ID,
                           FINISHING_ID = tb.FINISHING_ID,
                           UKURAN_ID = tb.UKURAN_ID,
                           UOM_ID = tb.UOM_ID,
                           PRODNEW_ID = tb.PRODNEW_ID,
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
                           FINISHING_CODE = tb.FINISHING_CODE,
                           FINISHING_NAME = tb.FINISHING_NAME,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           UOM_SEQNO = tb.UOM_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End private IQueryable<ProductstockVM> fieldLookup()
        private IQueryable<ProductVM> fieldIndex()
        {
            IQueryable<ProductVM> vReturn;

            var oQRY = from tb in db.Product_infos
                       select new ProductVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           PROD_QTY = tb.PROD_QTY,
                           PROD_PRICE_BASE = tb.PROD_PRICE_BASE,
                           PROD_PRICE_SELL = tb.PROD_PRICE_SELL,
                           PROD_PRICEDT = tb.PROD_PRICEDT,
                           PROD_STS = tb.PROD_STS,
                           COUNTRY_ID = tb.COUNTRY_ID,
                           VENDOR_ID = tb.VENDOR_ID,
                           PRODTYPE_ID = tb.PRODTYPE_ID,
                           PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                           SERIAL_ID = tb.SERIAL_ID,
                           FINISHING_ID = tb.FINISHING_ID,
                           UKURAN_ID = tb.UKURAN_ID,
                           UOM_ID = tb.UOM_ID,
                           PRODNEW_ID = tb.PRODNEW_ID,
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
                           FINISHING_CODE = tb.FINISHING_CODE,
                           FINISHING_NAME = tb.FINISHING_NAME,
                           UKURAN_CODE = tb.UKURAN_CODE,
                           UKURAN_NAME = tb.UKURAN_NAME,
                           UOM_CODE = tb.UOM_CODE,
                           UOM_DESC = tb.UOM_DESC,
                           UOM_SYM = tb.UOM_SYM,
                           UOM_SEQNO = tb.UOM_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End private IQueryable<ProductstockVM> fieldIndex()


        public List<ProductVM> getDatalist(IQueryable<ProductVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public ProductVM getData(int? id = null, IQueryable<ProductVM> poFieldsToselect = null)
        {
            IQueryable<ProductVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End public ProductdetailVM getData(int? id = null)

        //Check Exists
        public Boolean isExists_PRODNEW_ID(int? id = null)
        {
            Boolean vReturn = false;


            using (var db = new DBMAINContext())
            {
                var oQRY = (from tb in db.Product_infos
                            where tb.PRODNEW_ID == id
                            select new { PRODNEW_ID = tb.PRODNEW_ID }).ToList();

                if (oQRY.Count > 0) { vReturn = true; }


            } //End using (var = new DbContext())
            return vReturn;
        } //End public Boolean isExists_PRODNEW_ID(string id = null)

        public List<ProductVM> getDatalist_lookup()
        {
            List<ProductVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Product_infos
                           select new ProductVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PROD_CODE = tb.PROD_CODE,
                               PROD_NAME = tb.PROD_NAME,
                               PROD_DESC = tb.PROD_DESC,
                               PROD_IMAGE = tb.PROD_IMAGE,
                               PROD_QTY = tb.PROD_QTY,
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
                               PRODNEW_ID = tb.PRODNEW_ID,
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
                               UOM_SEQNO = tb.UOM_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProductlookupVM> getDatalist_lookup()
    } //End public class ProductDS
} //End namespace APPBASE.Models
