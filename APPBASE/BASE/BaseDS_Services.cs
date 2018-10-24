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
    public class BaseDS
    {
        private DBMAINContext db;
        public IQueryable<BaseVM> FIELD_LOOKUP { get { return this.fieldLookup(); } }
        public IQueryable<BaseVM> FIELD_INDEX { get { return this.fieldIndex(); } }


        //Constructor 1
        public BaseDS() { this.db = new DBMAINContext(); } //End Constructor BaseDS
        //Constructor 2
        public BaseDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor
        private IQueryable<BaseVM> fieldAll()
        {
            IQueryable<BaseVM> vReturn;

            var oQRY = from tb in this.db.Base_infos
                       select new BaseVM
                       {
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<BaseVM> fieldLookup()
        {
            IQueryable<BaseVM> vReturn;

            var oQRY = from tb in this.db.Base_infos
                       select new BaseVM
                       {
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method
        private IQueryable<BaseVM> fieldIndex()
        {
            IQueryable<BaseVM> vReturn;

            var oQRY = from tb in this.db.Base_infos
                       select new BaseVM
                       {
                       };
            vReturn = oQRY;

            return vReturn;
        } //End Method


        public List<BaseVM> getDatalist(IQueryable<BaseVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldAll().ToList();
        } //End Method
        public List<BaseVM> getDatalist_lookup(IQueryable<BaseVM> poFieldsToselect = null)
        {
            if (poFieldsToselect != null) return poFieldsToselect.ToList();
            return this.fieldLookup().ToList();
        } //End Method
        public BaseVM getData(int? id, IQueryable<BaseVM> poFieldsToselect = null)
        {
            IQueryable<BaseVM> oQRY = null;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            else oQRY = this.fieldAll();

            return oQRY.Where(fld => fld.ID == id).SingleOrDefault();
        } //End Method
    } //End Class
} //End namespace
