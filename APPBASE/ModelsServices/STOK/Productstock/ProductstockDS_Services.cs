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
    public class ProductstockDS
    {
        private DBMAINContext db;
        public IQueryable<ProductstockVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<ProductstockVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public ProductstockDS() { this.db = new DBMAINContext(); } //End public ProductstockDS()
        //Constructor 2
        public ProductstockDS(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End public ProductstockDS(DBMAINContext poDBMAINContext)
        //Encapsulated methods
        private IQueryable<ProductstockVM> fieldAll()
        {
            IQueryable<ProductstockVM> vReturn;

            var oQRY = from tb in db.Productstock_infos
                       select new ProductstockVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           PROD_ID = tb.PROD_ID,
                           STOCK_DT = tb.STOCK_DT,
                           STOCK_QTY = tb.STOCK_QTY,
                           STOCK_DESC = tb.STOCK_DESC,
                           STORAGE_ID = tb.STORAGE_ID,
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
                           STORAGE_CODE = tb.STORAGE_CODE,
                           STORAGE_NAME = tb.STORAGE_NAME,
                           STORAGE_SEQNO = tb.STORAGE_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End private IQueryable<ProductstockVM> fieldAll()
        private IQueryable<ProductstockVM> fieldLookup()
        {
            IQueryable<ProductstockVM> vReturn;

            var oQRY = from tb in db.Productstock_infos
                       select new ProductstockVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           PROD_ID = tb.PROD_ID,
                           STOCK_DT = tb.STOCK_DT,
                           STOCK_QTY = tb.STOCK_QTY,
                           STOCK_DESC = tb.STOCK_DESC,
                           STORAGE_ID = tb.STORAGE_ID,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           PROD_DESC = tb.PROD_DESC,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           STORAGE_CODE = tb.STORAGE_CODE,
                           STORAGE_NAME = tb.STORAGE_NAME,
                           STORAGE_SEQNO = tb.STORAGE_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End private IQueryable<ProductstockVM> fieldLookup()
        private IQueryable<ProductstockVM> fieldIndex()
        {
            IQueryable<ProductstockVM> vReturn;

            var oQRY = from tb in db.Productstock_infos
                       select new ProductstockVM
                       {
                           ID = tb.ID,
                           PROD_CODE = tb.PROD_CODE,
                           PROD_NAME = tb.PROD_NAME,
                           STOCK_QTY = tb.STOCK_QTY,
                           PROD_IMAGE = tb.PROD_IMAGE,
                           UOM_CODE = tb.UOM_CODE,
                           STOCK_DESC = tb.STOCK_DESC,
                           STORAGE_ID = tb.STORAGE_ID,
                           STORAGE_CODE = tb.STORAGE_CODE,
                           STORAGE_NAME = tb.STORAGE_NAME
                       };
            vReturn = oQRY;

            return vReturn;
        } //End private IQueryable<ProductstockVM> fieldIndex()

        //Public getDatalist methods
        public List<ProductstockVM> getDatalist(IQueryable<ProductstockVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End public List<ProductstockVM> getDatalist(IQueryable<ProductstockVM> poFieldsToselect = null)
        public List<ProductstockVM> getDatalist_lookup(IQueryable<ProductstockVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList(); 
            return this.fieldLookup().ToList();
        } //End public List<ProductstockVM> getDatalist_lookup(IQueryable<ProductstockVM> poFieldsToselect = null)
        public List<ProductstockVM> getDatalist_filter(
            int? pnPROD_ID,
            int? pnSTORAGE_ID,
            int? pnCOUNTRY_ID,
            int? pnVENDOR_ID,
            int? pnPRODTYPE_ID,
            int? pnPRODSUBTYPE_ID,
            int? pnSERIAL_ID,
            IQueryable<ProductstockVM> poFieldsToselect=null
            )
        {
            //Initial
            List<ProductstockVM> vReturn;
            IQueryable<ProductstockVM> oQRY = null;

            //Query
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            //Where PROD_ID
            if (pnPROD_ID != null) oQRY.Where(fld => fld.PROD_ID == pnPROD_ID);
            //Where STORAGE_ID
            if (pnSTORAGE_ID != null) oQRY.Where(fld => fld.STORAGE_ID == pnSTORAGE_ID);
            //Where COUNTRY_ID
            if (pnCOUNTRY_ID != null) oQRY.Where(fld => fld.COUNTRY_ID == pnCOUNTRY_ID);
            //Where VENDOR_ID
            if (pnVENDOR_ID != null) oQRY.Where(fld => fld.VENDOR_ID == pnVENDOR_ID);
            //Where PRODTYPE_ID
            if (pnPRODTYPE_ID != null) oQRY.Where(fld => fld.PRODTYPE_ID == pnPRODTYPE_ID);
            //Where PRODSUBTYPE_ID
            if (pnPRODSUBTYPE_ID != null) oQRY.Where(fld => fld.PRODSUBTYPE_ID == pnPRODSUBTYPE_ID);
            //Where SERIAL_ID
            if (pnSERIAL_ID != null) oQRY.Where(fld => fld.SERIAL_ID == pnSERIAL_ID);

            //Return
            vReturn = oQRY.ToList();
            return vReturn;
        } //End public List<ProductstockVM> getDatalist_filter


        //Mutasi Display
        public List<ProductstockVM> getDatalist_Display(IQueryable<ProductstockVM> poFieldsToselect = null)
        {
            IQueryable<ProductstockVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();
            return oQRY.Where(fld=>fld.STORAGE_ID==valFLAG.STORAGE_ID_DISPLAY).ToList();
        } //End public List<ProductstockVM> getDatalist_indexDisplay(IQueryable<ProductstockVM> poFieldsToselect = null)
        //Mutasi Gudang Atas
        public List<ProductstockVM> getDatalist_GudangA(IQueryable<ProductstockVM> poFieldsToselect = null)
        {
            IQueryable<ProductstockVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();
            return oQRY.Where(fld => fld.STORAGE_ID == valFLAG.STORAGE_ID_GATAS).ToList();
        } //End public List<ProductstockVM> getDatalist_indexDisplay(IQueryable<ProductstockVM> poFieldsToselect = null)
        //Mutasi Gudang Bawah
        public List<ProductstockVM> getDatalist_GudangB(IQueryable<ProductstockVM> poFieldsToselect = null)
        {
            IQueryable<ProductstockVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();
            return oQRY.Where(fld => fld.STORAGE_ID == valFLAG.STORAGE_ID_GBAWAH).ToList();
        } //End public List<ProductstockVM> getDatalist_indexDisplay(IQueryable<ProductstockVM> poFieldsToselect = null)

        //Public getData methods
        public ProductstockVM getData(int? id, IQueryable<ProductstockVM> poFieldsToselect = null)
        {
            IQueryable<ProductstockVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End public ProductstockVM getData(int? id = null, IQueryable<ProductstockVM> poFieldsToselect = null)
    } //End public class ProductstockDS
} //End namespace APPBASE.Models
