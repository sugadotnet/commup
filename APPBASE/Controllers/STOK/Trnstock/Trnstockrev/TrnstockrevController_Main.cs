using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPBASE.Models;
using APPBASE.Helpers;
using APPBASE.Filters;
using APPBASE.Svcbiz;


namespace APPBASE.Controllers
{
    public partial class TrnstockrevController : TrnstockController
    {
        protected int? STORAGE_REVBASEID;
        protected int? STORAGE_REVTARGETID;
        protected int? TRN_TYPEID;
        protected List<TrnstockdVM> oVMTransactions;
        protected TrnstockdDS oDSTransactiond;

        //Constructor 1
        public TrnstockrevController() : base(new DBMAINContext()) { this.oDSTransactiond = new TrnstockdDS(this.db); }
        //Constructor 2
        public TrnstockrevController(DBMAINContext poDB) : base(poDB) { this.oDSTransactiond = new TrnstockdDS(poDB); }

        public virtual ActionResult Logbook_trn()
        {
            oVMTransactions = oDSTransactiond.getDatalist_logbook(this.TRN_TYPEID, this.STORAGE_REVBASEID, this.STORAGE_REVTARGETID);
            if (oVMTransactions != null) oVMTransactions = oVMTransactions.OrderByDescending(fld => fld.TRN_DT).ToList();
            return View("~/Views/Trnstockrev/Logbook_trn.cshtml", oVMTransactions);
        }

    } //End class
} //End namespace
