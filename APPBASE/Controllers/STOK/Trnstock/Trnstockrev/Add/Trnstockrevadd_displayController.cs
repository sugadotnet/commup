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
    [MyActionFilterAttribute]
    public partial class Trnstockrevadd_displayController : TrnstockrevaddController
    {
        protected void Initialize() {
            ViewBag.Storagebasename = "Display";
            ViewBag.Controllername = "Trnstockrevadd_display";
            this.View_index = "~/Views/Trnstockrev/Index.cshtml";
            this.oBLMutasi_revadd = new Mutasi_revaddBL(this.db);
            this.STORAGE_REVBASEID = null;
            this.STORAGE_REVTARGETID = valFLAG.STORAGE_ID_DISPLAY;
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_DISPLAY;

            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_Display(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiDisplay();
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_SLS) this.View_index = "~/Views/Trnstockrev/Logbook.cshtml";
        } //end method

        //Constructor 1
        public Trnstockrevadd_displayController(): base(new DBMAINContext()) {
            this.Initialize();
        }
        //Constructor 2
        public Trnstockrevadd_displayController(DBMAINContext poDB): base(poDB) {
            this.Initialize();
        }
    } //End class
} //End namespace
