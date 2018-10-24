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
    public partial class Trnstockrevsub_gudangaController : TrnstockrevsubController
    {
        protected void Initialize() {
            ViewBag.Storagebasename = "Gudang Atas";
            ViewBag.Controllername = "Trnstockrevsub_gudanga";
            ViewBag.Title = "Kurangi Stok Gudang Atas Barang / Furniture";

            this.View_index = "~/Views/Trnstockrev/Index.cshtml";
            this.oBLMutasi_revsub = new Mutasi_revsubBL(this.db);
            this.STORAGE_REVBASEID = null;
            this.STORAGE_REVTARGETID = valFLAG.STORAGE_ID_GATAS;
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_GATAS;

            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_GudangA(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiGAtas();
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_GDGA) this.View_index = "~/Views/Trnstockrev/Logbook.cshtml";
        } //end method

        //Constructor 1
        public Trnstockrevsub_gudangaController(): base(new DBMAINContext()) {
            this.Initialize();
        }
        //Constructor 2
        public Trnstockrevsub_gudangaController(DBMAINContext poDB): base(poDB) {
            this.Initialize();
        }
    } //End class
} //End namespace
