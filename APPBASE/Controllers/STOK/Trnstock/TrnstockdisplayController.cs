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
    public partial class TrnstockdisplayController : TrnstockController
    {
        //Constructor 1
        public TrnstockdisplayController(): base(new DBMAINContext()) {
            ViewBag.Storagebasename = "Display";
            ViewBag.Controllername = "Trnstockdisplay";
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_DISPLAY;
            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_Display(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiDisplay();
            this.isShowLogbook = false;
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_SLS)
            {
                this.isShowLogbook = true;
                this.View_index = "~/Views/Trnstock/Logbook.cshtml";
            } //end if
        }
    } //End public partial class
} //End namespace APPBASE.Controllers
