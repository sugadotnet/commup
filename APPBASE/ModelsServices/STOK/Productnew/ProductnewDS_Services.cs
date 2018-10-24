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
    public class ProductnewDS
    {
        //Constructor
        public ProductnewDS() { } //End public ProductnewDS
        public List<ProductnewVM> getDatalist()
        {
            List<ProductnewVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Productnew_infos
                           select new ProductnewVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODNEW_CODE = tb.PRODNEW_CODE,
                               PRODNEW_NAME = tb.PRODNEW_NAME,
                               PRODNEW_DESC = tb.PRODNEW_DESC,
                               PRODNEW_IMAGE = tb.PRODNEW_IMAGE,
                               PRODNEW_QTY = tb.PRODNEW_QTY,
                               PRODNEW_PRICE_BASE = tb.PRODNEW_PRICE_BASE,
                               PRODNEW_PRICE_SELL = tb.PRODNEW_PRICE_SELL,
                               PRODNEW_PRICEDT = tb.PRODNEW_PRICEDT,
                               PRODNEW_STS = tb.PRODNEW_STS,
                               PRODNEW_OPENDT = tb.PRODNEW_OPENDT,
                               PRODNEW_VALDT = tb.PRODNEW_VALDT,
                               COUNTRY_ID = tb.COUNTRY_ID,
                               VENDOR_ID = tb.VENDOR_ID,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                               SERIAL_ID = tb.SERIAL_ID,
                               FINISHING_ID = tb.FINISHING_ID,
                               UKURAN_ID = tb.UKURAN_ID,
                               UOM_ID = tb.UOM_ID,
                               STORAGE_ID = tb.STORAGE_ID,
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
                               UOM_SEQNO = tb.UOM_SEQNO,
                               STORAGE_CODE = tb.STORAGE_CODE,
                               STORAGE_NAME = tb.STORAGE_NAME,
                               STORAGE_SEQNO = tb.STORAGE_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProductnewlistVM> getDatalist()
        public ProductnewVM getData(int? id = null)
        {
            ProductnewVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Productnew_infos
                           where tb.ID == id
                           select new ProductnewVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODNEW_CODE = tb.PRODNEW_CODE,
                               PRODNEW_NAME = tb.PRODNEW_NAME,
                               PRODNEW_DESC = tb.PRODNEW_DESC,
                               PRODNEW_IMAGE = tb.PRODNEW_IMAGE,
                               PRODNEW_QTY = tb.PRODNEW_QTY,
                               PRODNEW_PRICE_BASE = tb.PRODNEW_PRICE_BASE,
                               PRODNEW_PRICE_SELL = tb.PRODNEW_PRICE_SELL,
                               PRODNEW_PRICEDT = tb.PRODNEW_PRICEDT,
                               PRODNEW_STS = tb.PRODNEW_STS,
                               PRODNEW_OPENDT = tb.PRODNEW_OPENDT,
                               PRODNEW_VALDT = tb.PRODNEW_VALDT,
                               COUNTRY_ID = tb.COUNTRY_ID,
                               VENDOR_ID = tb.VENDOR_ID,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                               SERIAL_ID = tb.SERIAL_ID,
                               FINISHING_ID = tb.FINISHING_ID,
                               UKURAN_ID = tb.UKURAN_ID,
                               UOM_ID = tb.UOM_ID,
                               STORAGE_ID = tb.STORAGE_ID,
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
                               UOM_SEQNO = tb.UOM_SEQNO,
                               STORAGE_CODE = tb.STORAGE_CODE,
                               STORAGE_NAME = tb.STORAGE_NAME,
                               STORAGE_SEQNO = tb.STORAGE_SEQNO
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public ProductnewdetailVM getData(int? id = null)

        public List<ProductnewVM> getDatalist_validate()
        {
            List<ProductnewVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Productnew_infos
                           select new ProductnewVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODNEW_CODE = tb.PRODNEW_CODE,
                               PRODNEW_NAME = tb.PRODNEW_NAME,
                               PRODNEW_DESC = tb.PRODNEW_DESC,
                               PRODNEW_IMAGE = tb.PRODNEW_IMAGE,
                               PRODNEW_QTY = tb.PRODNEW_QTY,
                               PRODNEW_PRICE_BASE = tb.PRODNEW_PRICE_BASE,
                               PRODNEW_PRICE_SELL = tb.PRODNEW_PRICE_SELL,
                               PRODNEW_PRICEDT = tb.PRODNEW_PRICEDT,
                               PRODNEW_STS = tb.PRODNEW_STS,
                               PRODNEW_OPENDT = tb.PRODNEW_OPENDT,
                               PRODNEW_VALDT = tb.PRODNEW_VALDT,
                               COUNTRY_ID = tb.COUNTRY_ID,
                               VENDOR_ID = tb.VENDOR_ID,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                               SERIAL_ID = tb.SERIAL_ID,
                               FINISHING_ID = tb.FINISHING_ID,
                               UKURAN_ID = tb.UKURAN_ID,
                               UOM_ID = tb.UOM_ID,
                               STORAGE_ID = tb.STORAGE_ID,
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
                               UOM_SEQNO = tb.UOM_SEQNO,
                               STORAGE_CODE = tb.STORAGE_CODE,
                               STORAGE_NAME = tb.STORAGE_NAME,
                               STORAGE_SEQNO = tb.STORAGE_SEQNO
                           };
                vReturn = oQRY.Where(fld=> !db.Product_infos.Any(fld2=>fld2.PRODNEW_ID==fld.ID)).ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProductnewVM> getDatalist_validate()
        public List<ProductnewVM> getDatalist_lookup()
        {
            List<ProductnewVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Productnew_infos
                           select new ProductnewVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               PRODNEW_CODE = tb.PRODNEW_CODE,
                               PRODNEW_NAME = tb.PRODNEW_NAME,
                               PRODNEW_DESC = tb.PRODNEW_DESC,
                               PRODNEW_IMAGE = tb.PRODNEW_IMAGE,
                               PRODNEW_QTY = tb.PRODNEW_QTY,
                               PRODNEW_PRICE_BASE = tb.PRODNEW_PRICE_BASE,
                               PRODNEW_PRICE_SELL = tb.PRODNEW_PRICE_SELL,
                               PRODNEW_PRICEDT = tb.PRODNEW_PRICEDT,
                               PRODNEW_STS = tb.PRODNEW_STS,
                               PRODNEW_OPENDT = tb.PRODNEW_OPENDT,
                               PRODNEW_VALDT = tb.PRODNEW_VALDT,
                               COUNTRY_ID = tb.COUNTRY_ID,
                               VENDOR_ID = tb.VENDOR_ID,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODSUBTYPE_ID = tb.PRODSUBTYPE_ID,
                               SERIAL_ID = tb.SERIAL_ID,
                               FINISHING_ID = tb.FINISHING_ID,
                               UKURAN_ID = tb.UKURAN_ID,
                               UOM_ID = tb.UOM_ID,
                               STORAGE_ID = tb.STORAGE_ID,
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
                               UOM_SEQNO = tb.UOM_SEQNO,
                               STORAGE_CODE = tb.STORAGE_CODE,
                               STORAGE_NAME = tb.STORAGE_NAME,
                               STORAGE_SEQNO = tb.STORAGE_SEQNO
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<ProductnewlookupVM> getDatalist_lookup()

        //Check Exists
        public Boolean isExists_PRODNEW_CODE(int? id=null, string code = null)
        {
            Boolean vReturn = false;


            using (var db = new DBMAINContext())
            {
                var oQRY = (from tb in db.Productnew_infos
                            where tb.PRODNEW_CODE == code
                            select new {ID = tb.ID,  PRODNEW_CODE = tb.PRODNEW_CODE }).ToList();

                if (id != null) { oQRY = oQRY.Where(f => f.ID != id).ToList(); }

                if (oQRY.Count > 0) { vReturn = true; }


            } //End using (var = new DbContext())
            return vReturn;
        } //End public Boolean isExists_PRODNEW_CODE(string id = null)
    } //End public class ProductnewDS
} //End namespace APPBASE.Models
