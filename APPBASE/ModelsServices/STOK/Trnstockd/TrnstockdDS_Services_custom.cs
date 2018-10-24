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
        public List<TrnstockdVM> getDatalist(int? pnTRN_ID, IQueryable<TrnstockdVM> poFieldsToselect = null)
        {
            IQueryable<TrnstockdVM> oQRY;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            oQRY = this.fieldAll();

            if (pnTRN_ID != null) oQRY = oQRY.Where(fld => fld.TRN_ID == pnTRN_ID);
            return oQRY.ToList();
        } //End Method
        public List<TrnstockdVM> getDatalist_logbook(
            int? pnTRN_TYPEID = null, int? pnSTORAGE_BASEID = null, int? pnSTORAGE_TARGETID = null,
            IQueryable<TrnstockdVM> poFieldsToselect = null)
        {
            IQueryable<TrnstockdVM> oQRY;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            oQRY = this.fieldAll();
            //FILTER
            if (pnTRN_TYPEID != null) oQRY = oQRY.Where(fld => fld.TRN_TYPEID == pnTRN_TYPEID);
            if (pnSTORAGE_BASEID != null) oQRY = oQRY.Where(fld => fld.STORAGE_BASEID == pnSTORAGE_BASEID);
            if (pnSTORAGE_TARGETID != null) oQRY = oQRY.Where(fld => fld.STORAGE_TARGETID == pnSTORAGE_TARGETID);

            return oQRY.ToList();
        } //End Method
        public List<TrnstockdVM> getDatalist_logbook(
            int? pnTRN_TYPEID = null, int? pnSTORAGE_ID = null,
            IQueryable<TrnstockdVM> poFieldsToselect = null)
        {
            IQueryable<TrnstockdVM> oQRY;
            if (poFieldsToselect != null) oQRY = poFieldsToselect;
            oQRY = this.fieldAll();
            //FILTER
            if (pnTRN_TYPEID != null) oQRY = oQRY.Where(fld => fld.TRN_TYPEID == pnTRN_TYPEID);
            if (pnSTORAGE_ID != null) oQRY = oQRY.Where(fld => fld.STORAGE_BASEID == pnSTORAGE_ID ||
                fld.STORAGE_TARGETID == pnSTORAGE_ID);

            return oQRY.ToList();
        } //End Method
    } //End public class TrnstockdDS
} //End namespace APPBASE.Models
