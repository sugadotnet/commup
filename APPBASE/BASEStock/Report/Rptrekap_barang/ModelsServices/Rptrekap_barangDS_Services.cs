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
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public class Rptrekap_barangDS
    {
        protected DBMAINContext db;
        protected List<Rekap_barangVM> oData_list;
        protected List<Balance_trnVM> oBalance_list;

        //Constructor 1
        public Rptrekap_barangDS() { this.db = new DBMAINContext(); } //End Constructor
        //Constructor 2
        public Rptrekap_barangDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor

        public List<Rekap_barangVM> getResult(List<Balance_trnVM> poBalance_list = null)
        {
            //Set Balance data
            this.oBalance_list = poBalance_list;
            //Distinct product item and put in oData
            this.distinctItemProduct(this.oBalance_list);

            int nIndex = 0;
            int? nDISPLAY_QTY = 0; int? nDISPLAY_BASEQTY = 0;
            int? nGATAS_QTY = 0; int? nGATAS_BASEQTY = 0;
            int? nGBAWAH_QTY = 0; int? nGBAWAH_BASEQTY = 0;
            int? nSUM_QTY = 0;
            //Loop balance sum by Products and Storages
            foreach (var item in this.oData_list)
            {
                Rekap_barangVM oDataitem = new Rekap_barangVM();
                oDataitem = this.fillItem();
                //Init
                nIndex = this.oData_list.FindIndex(fld => fld.PROD_ID == item.PROD_ID);
                nDISPLAY_QTY = 0; nDISPLAY_BASEQTY = 0;
                nGATAS_QTY = 0; nGATAS_BASEQTY = 0;
                nGBAWAH_QTY = 0; nGBAWAH_BASEQTY = 0;
                //Sum Display
                nDISPLAY_QTY = this.oBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_TARGETID == valFLAG.STORAGE_ID_DISPLAY)
                    .Sum(fld => fld.TRN_QTY);
                nDISPLAY_BASEQTY = this.oBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_BASEID == valFLAG.STORAGE_ID_DISPLAY)
                    .Sum(fld => fld.TRN_QTY);
                if (nDISPLAY_BASEQTY!=null) nDISPLAY_QTY = nDISPLAY_QTY - nDISPLAY_BASEQTY;
                
                //Sum Gudang atas
                nGATAS_QTY = this.oBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_TARGETID == valFLAG.STORAGE_ID_GATAS)
                    .Sum(fld => fld.TRN_QTY);
                nGATAS_BASEQTY = this.oBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_BASEID == valFLAG.STORAGE_ID_GATAS)
                    .Sum(fld => fld.TRN_QTY);
                if (nGATAS_BASEQTY!=null) nGATAS_QTY = nGATAS_QTY - nGATAS_BASEQTY;

                //Sum Gudang bawah
                nGBAWAH_QTY = this.oBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_TARGETID == valFLAG.STORAGE_ID_GBAWAH)
                    .Sum(fld => fld.TRN_QTY);
                nGBAWAH_BASEQTY = this.oBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_BASEID == valFLAG.STORAGE_ID_GBAWAH)
                    .Sum(fld => fld.TRN_QTY);
                if (nGBAWAH_BASEQTY!=null) nGBAWAH_QTY = nGBAWAH_QTY - nGBAWAH_BASEQTY;

                //Sum Gudang bawah
                nSUM_QTY = nDISPLAY_QTY + nGATAS_QTY + nGBAWAH_QTY;

                //Apply Calculation
                this.oData_list[nIndex].DISPLAY_QTY = nDISPLAY_QTY;
                this.oData_list[nIndex].GATAS_QTY = nGATAS_QTY;
                this.oData_list[nIndex].GBAWAH_QTY = nGBAWAH_QTY;
                this.oData_list[nIndex].SUM_QTY = nSUM_QTY;
            } //end loop

            return this.oData_list;
        } //End Method
        protected void distinctItemProduct(List<Balance_trnVM> poBalance_list)
        {
            //Instantiate oData if null
            if (this.oData_list == null) this.oData_list = new List<Rekap_barangVM>();
            this.oData_list = poBalance_list
                .GroupBy(x => new {
                    PROD_ID = x.PROD_ID,
                    PROD_CODE = x.PROD_CODE,
                    PROD_DESC = x.PROD_DESC,
                    PROD_NAME = x.PROD_NAME,
                    PROD_IMAGE = x.PROD_IMAGE,
                    UOM_ID = x.UOM_ID,
                    UOM_CODE = x.UOM_CODE,
                    UOM_DESC = x.UOM_DESC,
                    UOM_SYM = x.UOM_SYM
                })
                .Select(fld => new Rekap_barangVM {
                PROD_ID = fld.Key.PROD_ID,
                PROD_CODE = fld.Key.PROD_CODE,
                PROD_DESC = fld.Key.PROD_DESC,
                PROD_NAME = fld.Key.PROD_NAME,
                PROD_IMAGE = fld.Key.PROD_IMAGE,
                UOM_ID = fld.Key.UOM_ID,
                UOM_CODE = fld.Key.UOM_CODE,
                UOM_DESC = fld.Key.UOM_DESC,
                UOM_SYM = fld.Key.UOM_SYM}).ToList();
            //this.oData_list = oVar.ToList();

        } //end method
        protected Rekap_barangVM fillItem() {
            Rekap_barangVM oResult = new Rekap_barangVM();
            //PRODUCT
            oResult.PROD_CODE = "001";
            oResult.PROD_NAME = "Sofa Tamu";
            oResult.PROD_DESC = "Sofa Tamu desc";
            oResult.PROD_IMAGE = "";
            //UOM
            oResult.UOM_ID = 0;
            oResult.UOM_CODE = "";
            oResult.UOM_DESC = "";
            oResult.UOM_SYM = "";
            //DISPLAY
            oResult.DISPLAY_QTY = 0;
            oResult.DISPLAY_GROSSAMOUNT = 0;
            oResult.DISPLAY_AMOUNT = 0;
            oResult.DISPLAY_AFTERTAXAMOUNT = 0;
            //GUDANG ATAS
            oResult.GATAS_QTY = 0;
            oResult.GATAS_GROSSAMOUNT = 0;
            oResult.GATAS_AMOUNT = 0;
            oResult.GATAS_AFTERTAXAMOUNT = 0;
            //GUDANG BAWAH
            oResult.GBAWAH_QTY = 0;
            oResult.GBAWAH_GROSSAMOUNT = 0;
            oResult.GBAWAH_AMOUNT = 0;
            oResult.GBAWAH_AFTERTAXAMOUNT = 0;

            return oResult;
        } //end method

        protected void sumBalance(List<Balance_trnVM> poBalance_list)
        {
            List<Balance_trnVM> oResult_list = poBalance_list;

            oResult_list = oResult_list
                .GroupBy(grp => new { PROD_ID = grp.PROD_ID, STORAGE_TARGETID = grp.STORAGE_TARGETID })
                .Select(fld => new Balance_trnVM()).ToList();

            this.oBalance_list = oResult_list;
        } //end method
    } //End Class
} //End namespace
