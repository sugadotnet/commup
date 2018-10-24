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
    public partial class Trnstockgudang_bController : TrnstockController
    {
        //Constructor 1
        public Trnstockgudang_bController(): base(new DBMAINContext()) {
            ViewBag.Storagebasename = "Gudang Bawah";
            ViewBag.Controllername = "Trnstockgudang_b";
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_GBAWAH;
            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_GudangB(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiGBawah();
            this.isShowLogbook = false;
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_GDGB)
            {
                this.isShowLogbook = true;
                this.View_index = "~/Views/Trnstock/Logbook.cshtml";
            } //end if
        }
    } //End public partial class Trnstockgudang_bController : Controller
} //End namespace APPBASE.Controllers
