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
    public partial class Trnstockgudang_aController : TrnstockController
    {
        //Constructor 1
        public Trnstockgudang_aController(): base(new DBMAINContext()) {
            ViewBag.Storagebasename = "Gudang Atas";
            ViewBag.Controllername = "Trnstockgudang_a";
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_GATAS;
            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_GudangA(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiGAtas();
            this.isShowLogbook = false;
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_GDGA) {
                this.isShowLogbook = true;
                this.View_index = "~/Views/Trnstock/Logbook.cshtml";
            } //end if
        }
    } //End public partial class Trnstockgudang_aController : Controller
} //End namespace APPBASE.Controllers
