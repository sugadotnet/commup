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
    public partial class Productstockgudang_bController : ProductstockController {
        //Constructor 1
        public Productstockgudang_bController(): base(new DBMAINContext()) {
            ViewBag.Storagebasename = "Gudang Bawah";
            ViewBag.Controllername = "Productstock";
            this.oData = new ProductstockVM();
            this.oData.LIST_INDEX = this.oDS.getDatalist_GudangB(oDS.FIELD_INDEX);
            //this.oVMStorage = oDSStorage.getDatalist_mutasiDisplay();
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_GDGB) this.View_index = "~/Views/Productstock/Logbook.cshtml";
        }
    } //End public partial class
} //End namespace APPBASE.Controllers
