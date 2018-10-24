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
    public class Rptrekap_mutasiDS
    {
        protected DBMAINContext db;
        protected List<Rekap_mutasiVM> oData_list;
        protected List<Balance_trnVM> oBeginBalance_list;
        protected List<Balance_trnVM> oCurrentBalance_list;
        protected List<Balance_trnVM> oBalance_list;

        //Constructor 1
        public Rptrekap_mutasiDS() { this.db = new DBMAINContext(); } //End Constructor
        //Constructor 2
        public Rptrekap_mutasiDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor

        public List<Rekap_mutasiVM> getResult(int? pnStorageId,
            List<Balance_trnVM> poBeginBalance_list, List<Balance_trnVM> poCurrentBalance_list, List<Balance_trnVM> poBalance_list)
        {
            //Set Balance data
            this.oBalance_list = poBalance_list;
            this.oBeginBalance_list = poBeginBalance_list;
            this.oCurrentBalance_list = poCurrentBalance_list;
            //Distinct product item and put in oData
            this.distinctItemProduct(this.oBalance_list);
            //List Index Position
            int nIndex = 0;
            //BEGIN BALANCE
            int? nQTY_BEGIN_IN = 0;
            int? nQTY_BEGIN_OUT = 0;
            int? nQTY_BEGIN = 0;
            //BALANCE-IN
            int? nQTY_IN = 0;
            //BALANCE-OUT
            int? nQTY_OUT = 0;
            //ENDING BALANCE
            int? nQTY_ENDING = 0;

            //Loop balance sum by Products and Storages
            foreach (var item in this.oData_list)
            {
                //Init List Position
                nIndex = this.oData_list.FindIndex(fld => fld.PROD_ID == item.PROD_ID);
                //Init BEGIN BALANCE
                nQTY_BEGIN_IN = 0;
                nQTY_BEGIN_OUT = 0;
                nQTY_BEGIN = 0;
                //Init BALANCE-IN
                nQTY_IN = 0;
                //Init BALANCE-OUT
                nQTY_OUT = 0;
                //Init ENDING BALANCE
                nQTY_ENDING = 0;

                //BEGIN BALANCE
                nQTY_BEGIN_IN = this.oBeginBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_TARGETID == pnStorageId)
                    .Sum(fld => fld.TRN_QTY);
                nQTY_BEGIN_OUT = this.oBeginBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_BASEID == pnStorageId)
                    .Sum(fld => fld.TRN_QTY);
                nQTY_BEGIN = nQTY_BEGIN_IN - nQTY_BEGIN_OUT;
                //BALANCE-IN
                nQTY_IN = this.oCurrentBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_TARGETID == pnStorageId)
                    .Sum(fld => fld.TRN_QTY);
                //BALANCE-OUT
                nQTY_OUT = this.oCurrentBalance_list
                    .Where(fld => fld.PROD_ID == item.PROD_ID && fld.STORAGE_BASEID == pnStorageId)
                    .Sum(fld => fld.TRN_QTY);
                //ENDING BALANCE
                nQTY_ENDING = nQTY_BEGIN + (nQTY_IN - nQTY_OUT);

                this.oData_list[nIndex].QTY_BEGIN = nQTY_BEGIN;
                this.oData_list[nIndex].QTY_IN = nQTY_IN;
                this.oData_list[nIndex].QTY_OUT = nQTY_OUT;
                this.oData_list[nIndex].QTY_ENDING = nQTY_ENDING;
            } //end loop

            return this.oData_list;
        } //End Method
        protected void distinctItemProduct(List<Balance_trnVM> poBalance_list)
        {
            //Instantiate oData if null
            if (this.oData_list == null) this.oData_list = new List<Rekap_mutasiVM>();
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
                .Select(fld => new Rekap_mutasiVM {
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
    } //End Class
} //End namespace
