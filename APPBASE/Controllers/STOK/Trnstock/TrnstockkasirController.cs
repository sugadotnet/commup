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
    public partial class TrnstockkasirController : TrnstockController
    {
        //BL
        protected Mutasi_kasirBL oBLMutasi_kasir;
        
        //Constructor 1
        public TrnstockkasirController(): base(new DBMAINContext()) {
            oBLMutasi_kasir = new Mutasi_kasirBL(this.db);
            ViewBag.Storagebasename = "Kasir";
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_DISPLAY;
            //this.OVERRIDE = true;
            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_Display(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiDisplay();
            if (this.ROLE_ID != valFLAG.FLAG_ROLE_CSR) this.View_index = "~/Views/Trnstock/Logbook.cshtml";
        }
        //Constructor 2
        public TrnstockkasirController(DBMAINContext poDB): base(poDB) {
            oBLMutasi_kasir = new Mutasi_kasirBL(this.db);
            ViewBag.Storagebasename = "Kasir";
            this.STOCKSTORAGE_ID = valFLAG.STORAGE_ID_DISPLAY;
            //this.OVERRIDE = true;
            this.oVMProductstok.LIST_INDEX = this.oDSProductstock.getDatalist_Display(oDSProductstock.FIELD_INDEX);
            this.oVMStorage = oDSStorage.getDatalist_mutasiDisplay();
        }


        //GET-Create
        protected override Boolean _Create()
        {
            //ViewBag.AC_MENU_ID = valMENU.MODULE_CREATE;
            ViewBag.CRUD_type = hlpFlags_CRUDOption.CREATE;

            this.oData = new TrnstockVM();
            ProductstockVM oViewModel = new ProductstockVM();
            if (Session[SESSION_PRODUCTSTOCK] != null)
            {
                oViewModel = (ProductstockVM)Session[SESSION_PRODUCTSTOCK];

                this.oMAPStock.Init();
                this.oMAPStock.DATETIME_data = DateTime.Now;
                //TRNSTOCK
                this.oMAPStock.TRNSTOCK_data = this.oData;
                //PRODUCTSTOCK data
                this.oMAPStock.PRODUCTSTOCK_data = oViewModel;
                //PRODUCTSTOCK datas
                this.oMAPStock.PRODUCTSTOCK_datas = oDSProductstock.getDatalist();
                this.oMAPStock.Process();
                this.oData = this.oMAPStock.TRNSTOCK_result;

                //this.oData.mapToInput(oViewModel);
            } //End if (TempData[TEMPDATA_PRODUCTSTOCK] != null)

            this.prepareLookup();
            return true;
        } //End Method
        public override ActionResult Create()
        {
            this._Create();
            return View(this.oData);
        } //End Action
        //POST-Create
        protected override Boolean _Create_post(TrnstockVM poViewModel)
        {
            TrnstockVM oViewModel = poViewModel;
            int nIndex = -1;
            foreach (var item in oViewModel.LISTITEM)
            {
                nIndex = oViewModel.LISTITEM.FindIndex(fld => fld.PRODSTOCK_ID == item.PRODSTOCK_ID);
                oViewModel.LISTITEM[nIndex].TRND_PRICE = hlpConvertionAndFormating.ConvertStringToDecimal(item.TRND_PRICE_S);
            } //end loop
            this.oDataproductstock_list = oDSProductstock.getDatalist();
            if (this.oDataproductstock_list != null) {
                this.oDataproductstock_list =
                    this.oDataproductstock_list
                    .Where(fld => fld.STORAGE_ID == valFLAG.STORAGE_ID_DISPLAY).ToList();
            } //end if
            oVAL = new Trnstock_Validation(oViewModel, this.oDataproductstock_list);
            oVAL.Validate_Create_csr();

            //Add Error if exists
            for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            {
                ModelState.AddModelError(oVAL.aValidationMSG[i].VAL_ERRID, oVAL.aValidationMSG[i].VAL_ERRMSG);
            } //End for (int i = 0; i < oVAL.aValidationMSG.Count; i++)
            //var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                /*>>>>> AUTOGENERATE NUMBER [oBLIDMutasi] <<<<< */
                //0-Initialize
                this.oBLIDMutasi.Init(oViewModel.TRN_CODE);
                //1-Inject 1
                this.oBLIDMutasi.inject_IDMUTASI(oDSIdmutasi.getData_byYearAndMonth(DateTime.Now));
                //1-Inject 2
                this.oBLIDMutasi.inject_IdmutasiCRUD(this.oCRUDIdmutasi);
                //2-Process
                this.oBLIDMutasi.Process();
                oViewModel.TRN_CODE = oBLIDMutasi.ID;

                /*>>>>> TRN HEADER,DETAIL DAN STOCK [oBL] <<<<< */
                //0-Initialize
                this.oBLMutasi_kasir.Init();
                //1-Inject DATA 1-Trnstock (oViewModel)
                this.oBLMutasi_kasir.TRNSTOCK = oViewModel; //this.oBL.inject_TRNSTOCK(oViewModel);
                //1-Inject DATA 2-Trnstockd (oViewModel.LISTITEM)
                this.oBLMutasi_kasir.TRNSTOCKDS = oViewModel.LISTITEM; //this.oBL.inject_TRNSTOCKDS(oViewModel.LISTITEM);
                //1-Inject DATA 3-Products
                this.oBLMutasi_kasir.PRODUCTS = oDSProduct.getDatalist(); //this.oBL.inject_PRODUCTS(oDSProduct.getDatalist());
                //1-Inject DATA 4-Productstocks
                this.oBLMutasi_kasir.PRODUCTSTOCKS = oDSProductstock.getDatalist(); //End this.oBL.inject_PRODUCTSTOCKS(oDSProductstock.getDatalist());
                //2-Inject CRUD 1
                this.oBLMutasi_kasir.CRUD = this.oCRUD;
                //2-Inject CRUD 2
                this.oBLMutasi_kasir.CRUDDetail = this.oCRUDDetail;
                //2-Inject CRUD 3
                this.oBLMutasi_kasir.CRUDProductstock = this.oCRUDProductstock;
                //3-Process
                this.oBLMutasi_kasir.Process();
                //5-Save Mutasi
                if (!this.oBLMutasi_kasir.Save()) return false;
                //5-Commit Mutasi
                this.oBLMutasi_kasir.Commit();

                /*>>>>> AUTOGENERATE NUMBER [oBLIDMutasi] <<<<< */
                //3-Save
                this.oBLIDMutasi.Save();
                //4-Commit
                this.oBLIDMutasi.Commit();
                //Return
                return true;
            } //End if (ModelState.IsValid)

            //Prepare
            this.prepareLookup();
            //Return
            return false;
        } //End Method
        [HttpPost]
        public override ActionResult Create(TrnstockVM poViewModel)
        {
            TrnstockVM oViewModel = poViewModel;
            //If Process Success
            if (this._Create_post(oViewModel))
            {
                TempData["CRUDSavedOrDelete"] = valFLAG.FLAG_TRUE;
                return RedirectToAction("Reportprint", new { id = oBLMutasi_kasir.CRUD.ID });
            } //End if (!oCRUD.isERR)
            //If Error on CRUD Operation
            if ((oCRUD.ERRMSG != "") && (oCRUD.ERRMSG != null)) {
                TempData["ERRMSG"] = oCRUD.ERRMSG;
                return RedirectToAction("ErrorSYS", "Error");
            } //End if
            this.prepareLookup();

            foreach (var item in oViewModel.LISTITEM)
            {
                item.TRND_DISCRATE = hlpConvertionAndFormating.ConvertStringToDecimal(item.TRND_DISCRATE_S);
            }

            return View(oViewModel);
        } //End Action

        public override ActionResult Reportprint(int? id = null)
        {
            this._Reportprint(id);
            //return View("~/Views/Trnstock/Reportprint.cshtml", this.oData);
            return View(this.oData);
        }
    } //End class
} //End namespace APPBASE.Controllers
