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
    public class Rptrekap_sellDS
    {
        protected DBMAINContext db;
        protected List<Rekap_sellVM> oData_list;
        protected List<Balance_trnsellVM> oBeginBalance_list;
        protected List<Balance_trnsellVM> oCurrentBalance_list;
        protected List<Balance_trnsellVM> oBalance_list;

        //Constructor 1
        public Rptrekap_sellDS() { this.db = new DBMAINContext(); } //End Constructor
        //Constructor 2
        public Rptrekap_sellDS(DBMAINContext poDBMAINContext)
        {
            this.db = poDBMAINContext;
        } //End Constructor

        public List<Rekap_sellVM> getResult(int? pnStorageId,
            List<Balance_trnsellVM> poBeginBalance_list, List<Balance_trnsellVM> poCurrentBalance_list, List<Balance_trnsellVM> poBalance_list)
        {
            //Set Balance data
            this.oBalance_list = poBalance_list;
            this.oBeginBalance_list = poBeginBalance_list;
            this.oCurrentBalance_list = poCurrentBalance_list;
            //Distinct product item and put in oData
            this.distinctItemProduct(this.oBalance_list);
            //List Index Position
            int nIndex = 0;
            int? nQTY = 0;
            //Loop balance sum by Products and Storages
            foreach (var item in this.oData_list)
            {
                //Init List Position
                nIndex = this.oData_list.FindIndex(fld => fld.PROD_ID == item.PROD_ID);
                //Calculation
                //--> Code here
                this.oData_list[nIndex].QTY_TOTAL = 0;
                this.oData_list[nIndex].QTY = new List<int?>();
                for (int i = 0; i < 12; i++)
                {
                    nQTY = this.sumQty(i + 1);
                    this.oData_list[nIndex].QTY.Add(nQTY);
                    this.oData_list[nIndex].QTY_TOTAL = this.oData_list[nIndex].QTY_TOTAL + nQTY;
                } //end loop
            } //end loop

            return this.oData_list;
        } //End Method
        protected void distinctItemProduct(List<Balance_trnsellVM> poBalance_list)
        {
            //Instantiate oData if null
            if (this.oData_list == null) this.oData_list = new List<Rekap_sellVM>();
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
                .Select(fld => new Rekap_sellVM {
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
        protected int? sumQty(int? pnMonth)
        {
            int? nResult = 0;
            int? nMonth = pnMonth;

            nResult = this.oBalance_list.Where(fld => fld.TRN_MONTH == nMonth).Sum(fld => fld.TRN_QTY);

            return nResult;
        } //end method
    } //End Class
} //End namespace
