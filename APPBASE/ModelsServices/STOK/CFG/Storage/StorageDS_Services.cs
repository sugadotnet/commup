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
    public class StorageDS
    {
        private DBMAINContext db;

        //Constructor
        public StorageDS() { this.db = new DBMAINContext(); } //End public StorageDS
        //Constructor 2
        public StorageDS(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End public ProductstockDS(DBMAINContext poDBMAINContext)
        //Encapsulated methods
        private IQueryable<StorageVM> fieldAll()
        {
            IQueryable<StorageVM> vReturn;

            var oQRY = from tb in db.Storage_infos
                       select new StorageVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           STORAGE_CODE = tb.STORAGE_CODE,
                           STORAGE_NAME = tb.STORAGE_NAME,
                           STORAGE_SEQNO = tb.STORAGE_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End fieldAll()
        private IQueryable<StorageVM> fieldLookup()
        {
            IQueryable<StorageVM> vReturn;

            var oQRY = from tb in db.Storage_infos
                       select new StorageVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           STORAGE_CODE = tb.STORAGE_CODE,
                           STORAGE_NAME = tb.STORAGE_NAME,
                           STORAGE_SEQNO = tb.STORAGE_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End fieldLookup()
        private IQueryable<StorageVM> fieldAll_index()
        {
            IQueryable<StorageVM> vReturn;

            var oQRY = from tb in db.Storage_infos
                       select new StorageVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           STORAGE_CODE = tb.STORAGE_CODE,
                           STORAGE_NAME = tb.STORAGE_NAME,
                           STORAGE_SEQNO = tb.STORAGE_SEQNO
                       };
            vReturn = oQRY;

            return vReturn;
        } //End fieldAll_index()



        public List<StorageVM> getDatalist(IQueryable<StorageVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End public List<StorageVM> getDatalist()
        public List<StorageVM> getDatalist_lookup(IQueryable<StorageVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End public List<StorageVM> getDatalist_lookup()
        public List<StorageVM> getDatalist_mutasiDisplay(IQueryable<StorageVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.Where(fld => fld.ID != valFLAG.STORAGE_ID_DISPLAY && fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
            return this.fieldAll().Where(fld => fld.ID != valFLAG.STORAGE_ID_DISPLAY && fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
        } //End public List<StorageVM> getDatalist_mutasiDisplay(IQueryable<StorageVM> poFieldsToselect = null)
        public List<StorageVM> getDatalist_mutasiGAtas(IQueryable<StorageVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.Where(fld => fld.ID != valFLAG.STORAGE_ID_GATAS && fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
            return this.fieldAll().Where(fld => fld.ID != valFLAG.STORAGE_ID_GATAS && fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
        } //End public List<StorageVM> getDatalist_mutasiDisplay(IQueryable<StorageVM> poFieldsToselect = null)
        public List<StorageVM> getDatalist_mutasiGBawah(IQueryable<StorageVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.Where(fld => fld.ID != valFLAG.STORAGE_ID_GBAWAH && fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
            return this.fieldAll().Where(fld => fld.ID != valFLAG.STORAGE_ID_GBAWAH && fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
        } //End public List<StorageVM> getDatalist_mutasiDisplay(IQueryable<StorageVM> poFieldsToselect = null)
        public List<StorageVM> getDatalist_mutasiKasir(IQueryable<StorageVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.Where(fld => fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
            return this.fieldAll().Where(fld => fld.ID != valFLAG.STORAGE_ID_KASIR).ToList();
        } //End public List<StorageVM> getDatalist_mutasiDisplay(IQueryable<StorageVM> poFieldsToselect = null)

        
        public StorageVM getData(int? id = null, IQueryable<StorageVM> poFieldsToselect = null)
        {
            IQueryable<StorageVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();
            //Filter by ID
            if (id != null) oQRY = oQRY.Where(fld => fld.ID == id);
            return oQRY.SingleOrDefault();
        } //End public StorageVM getData(int? id = null)


    } //End public class StorageDS
} //End namespace APPBASE.Models
