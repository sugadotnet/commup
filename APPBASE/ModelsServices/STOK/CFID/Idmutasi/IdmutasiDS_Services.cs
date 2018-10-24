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
    public class IdmutasiDS
    {
        private DBMAINContext db;

        public IQueryable<IdmutasiVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<IdmutasiVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public IdmutasiDS() {
            this.db = new DBMAINContext();
        } //End public IdmutasiDS
        //Constructor 2
        public IdmutasiDS(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End public IdmutasiDS(DBMAINContext poDBMAINContext)
        //Encapsulated methods
        private IQueryable<IdmutasiVM> fieldAll()
        {
            IQueryable<IdmutasiVM> vReturn;

            var oQRY = from tb in db.Idmutasi_infos
                       select new IdmutasiVM
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
        } //End private IQueryable<ProductstockVM> fieldAll()
        private IQueryable<IdmutasiVM> fieldLookup()
        {
            IQueryable<IdmutasiVM> vReturn;

            var oQRY = from tb in db.Idmutasi_infos
                       select new IdmutasiVM
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
        } //End private IQueryable<ProductstockVM> fieldLookup()
        private IQueryable<IdmutasiVM> fieldIndex()
        {
            IQueryable<IdmutasiVM> vReturn;

            var oQRY = from tb in db.Idmutasi_infos
                       select new IdmutasiVM
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
        } //End private IQueryable<ProductstockVM> fieldIndex()



        public List<IdmutasiVM> getDatalist(IQueryable<IdmutasiVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End public List<IdmutasilistVM> getDatalist()
        public IdmutasiVM getData(int? id, IQueryable<IdmutasiVM> poFieldsToselect = null)
        {
            IQueryable<IdmutasiVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End public IdmutasidetailVM getData(int? id = null)
        public IdmutasiVM getData_first(IQueryable<IdmutasiVM> poFieldsToselect = null)
        {
            IQueryable<IdmutasiVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();
            return oQRY.FirstOrDefault();
        } //End public IdmutasidetailVM getData(int? id = null)
        public List<IdmutasiVM> getDatalist_lookup(IQueryable<IdmutasiVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End public List<IdmutasilookupVM> getDatalist_lookup()


        public IdmutasiVM getData_byYearAndMonth(DateTime? pdDatetime, IQueryable<IdmutasiVM> poFieldsToselect = null)
        {
            int? nYEAR = pdDatetime.Value.Year;
            int? nMONTH = pdDatetime.Value.Month;

            IQueryable<IdmutasiVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID_YEAR==nYEAR && fld.ID_MONTH==nMONTH).SingleOrDefault();
        } //End public IdmutasidetailVM getData(int? id = null)
    } //End public class IdmutasiDS
} //End namespace APPBASE.Models
