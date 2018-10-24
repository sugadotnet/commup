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
    public class TrnstockDS
    {
        private DBMAINContext db;

        //Constructor 1
        public TrnstockDS() {
            this.db = new DBMAINContext();
        } //End public TrnstockDS
        //Constructor 2
        public TrnstockDS(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End public ProductstockDS(DBMAINContext poDBMAINContext)

        public List<TrnstockVM> getDatalist()
        {
            List<TrnstockVM> vReturn;
            var oQRY = from tb in this.db.Trnstock_infos
                       select new TrnstockVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           TRN_STS = tb.TRN_STS,
                           TRN_TYPEID = tb.TRN_TYPEID,
                           TRN_SUBTYPEID = tb.TRN_SUBTYPEID,
                           TRN_DT = tb.TRN_DT,
                           TRN_CODE = tb.TRN_CODE,
                           TRN_GIVER = tb.TRN_GIVER,
                           TRN_RECIPIENT = tb.TRN_RECIPIENT,
                           TRN_DESC = tb.TRN_DESC,
                           TRN_AMOUNT = tb.TRN_AMOUNT,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_BASESEQNO = tb.STORAGE_BASESEQNO,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME,
                           STORAGE_TARGETSEQNO = tb.STORAGE_TARGETSEQNO,
                           TRNTYPE_CODE = tb.TRNTYPE_CODE,
                           TRNTYPE_NAME = tb.TRNTYPE_NAME
                       };
            vReturn = oQRY.ToList();
            return vReturn;
        } //End public List<TrnstocklistVM> getDatalist()
        public TrnstockVM getData(int? id = null)
        {
            TrnstockVM oReturn;
            var oQRY = from tb in this.db.Trnstock_infos
                       where tb.ID == id
                       select new TrnstockVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           TRN_STS = tb.TRN_STS,
                           TRN_TYPEID = tb.TRN_TYPEID,
                           TRN_SUBTYPEID = tb.TRN_SUBTYPEID,
                           TRN_DT = tb.TRN_DT,
                           TRN_CODE = tb.TRN_CODE,
                           TRN_GIVER = tb.TRN_GIVER,
                           TRN_RECIPIENT = tb.TRN_RECIPIENT,
                           TRN_DESC = tb.TRN_DESC,
                           TRN_AMOUNT = tb.TRN_AMOUNT,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_BASESEQNO = tb.STORAGE_BASESEQNO,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME,
                           STORAGE_TARGETSEQNO = tb.STORAGE_TARGETSEQNO,
                           TRNTYPE_CODE = tb.TRNTYPE_CODE,
                           TRNTYPE_NAME = tb.TRNTYPE_NAME
                       };
            oReturn = oQRY.SingleOrDefault();
            return oReturn;
        } //End public TrnstockdetailVM getData(int? id = null)

        public List<TrnstockVM> getDatalist_lookup()
        {
            List<TrnstockVM> vReturn;
            var oQRY = from tb in this.db.Trnstock_infos
                       select new TrnstockVM
                       {
                           ID = tb.ID,
                           DTA_STS = tb.DTA_STS,
                           TRN_STS = tb.TRN_STS,
                           TRN_TYPEID = tb.TRN_TYPEID,
                           TRN_SUBTYPEID = tb.TRN_SUBTYPEID,
                           TRN_DT = tb.TRN_DT,
                           TRN_CODE = tb.TRN_CODE,
                           TRN_GIVER = tb.TRN_GIVER,
                           TRN_RECIPIENT = tb.TRN_RECIPIENT,
                           TRN_DESC = tb.TRN_DESC,
                           TRN_AMOUNT = tb.TRN_AMOUNT,
                           STORAGE_BASEID = tb.STORAGE_BASEID,
                           STORAGE_TARGETID = tb.STORAGE_TARGETID,
                           STORAGE_BASECODE = tb.STORAGE_BASECODE,
                           STORAGE_BASENAME = tb.STORAGE_BASENAME,
                           STORAGE_BASESEQNO = tb.STORAGE_BASESEQNO,
                           STORAGE_TARGETCODE = tb.STORAGE_TARGETCODE,
                           STORAGE_TARGETNAME = tb.STORAGE_TARGETNAME,
                           STORAGE_TARGETSEQNO = tb.STORAGE_TARGETSEQNO,
                           TRNTYPE_CODE = tb.TRNTYPE_CODE,
                           TRNTYPE_NAME = tb.TRNTYPE_NAME
                       };
            vReturn = oQRY.ToList();
            return vReturn;
        } //End public List<TrnstocklookupVM> getDatalist_lookup()
    } //End public class TrnstockDS
} //End namespace APPBASE.Models
