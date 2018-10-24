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
using APPBASE;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Trnstock_Validation
    {
        private void Validate_items()
        {
            Boolean bIsvalid = true;

            foreach (var item in oViewModel.LISTITEM)
            {
                this.oViewModel_productstock = this.oViewModel_productstock_list
                    .Where(fld => fld.ID == item.PRODSTOCK_ID).FirstOrDefault();
                if (item.TRND_QTY > this.oViewModel_productstock.STOCK_QTY) {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Stock " + this.oViewModel_productstock.PROD_NAME + " Tidak cukup";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == null)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah mutasi harus diisi";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == 0)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah mutasi tidak boleh nol";
                    aValidationMSG.Add(oMSG);
                } //end if

                if (item.STORAGE_TARGETID==null)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "STORAGE_TARGETID#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Tujuan mutasi harus diisi";
                    aValidationMSG.Add(oMSG);
                } //end if

                if (!bIsvalid)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "ITEM#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "ERROR";
                    aValidationMSG.Add(oMSG);
                } //End if
            } //end loop

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ITEM0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()
        private void Validate_items_csr()
        {
            Boolean bIsvalid = true;

            foreach (var item in oViewModel.LISTITEM)
            {
                this.oViewModel_productstock = this.oViewModel_productstock_list
                    .Where(fld => fld.ID == item.PRODSTOCK_ID).FirstOrDefault();
                if (item.TRND_QTY > this.oViewModel_productstock.STOCK_QTY)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Stock " + this.oViewModel_productstock.PROD_NAME + " Tidak cukup";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == null)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah penjualan harus diisi";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == 0)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah penjualan tidak boleh nol";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_PRICE == null)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_PRICE#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Harga jual harus diisi";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_PRICE <= 0)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_PRICE#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Harga jual tidak boleh nol atau minus";
                    aValidationMSG.Add(oMSG);
                } //end if

                if (!bIsvalid)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "ITEM#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "ERROR";
                    aValidationMSG.Add(oMSG);
                } //End if
            } //end loop

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ITEM0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()
        private void Validate_items_revadd()
        {
            Boolean bIsvalid = true;

            foreach (var item in oViewModel.LISTITEM)
            {
                if (item.TRND_QTY == null)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah Penambahan harus diisi";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == 0)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah Penambahan tidak boleh nol";
                    aValidationMSG.Add(oMSG);
                } //end if

                //if (item.STORAGE_TARGETID == null)
                //{
                //    bIsvalid = false;
                //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                //    oMSG.VAL_ERRID = "STORAGE_TARGETID#" + item.PRODSTOCK_ID;
                //    oMSG.VAL_ERRMSG = "Tujuan mutasi harus diisi";
                //    aValidationMSG.Add(oMSG);
                //} //end if

                if (!bIsvalid)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "ITEM#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "ERROR";
                    aValidationMSG.Add(oMSG);
                } //End if
            } //end loop

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ITEM0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()
        private void Validate_items_revsub()
        {
            Boolean bIsvalid = true;

            foreach (var item in oViewModel.LISTITEM)
            {
                this.oViewModel_productstock = this.oViewModel_productstock_list
                    .Where(fld => fld.ID == item.PRODSTOCK_ID).FirstOrDefault();
                if (item.TRND_QTY > this.oViewModel_productstock.STOCK_QTY)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Stock " + this.oViewModel_productstock.PROD_NAME + " Tidak cukup";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == null)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah pengurangan harus diisi";
                    aValidationMSG.Add(oMSG);
                } //end if
                if (item.TRND_QTY == 0)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "TRND_QTY#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "Jumlah pengurangan tidak boleh nol";
                    aValidationMSG.Add(oMSG);
                } //end if

                //if (item.STORAGE_TARGETID == null)
                //{
                //    bIsvalid = false;
                //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                //    oMSG.VAL_ERRID = "STORAGE_TARGETID#" + item.PRODSTOCK_ID;
                //    oMSG.VAL_ERRMSG = "Tujuan mutasi harus diisi";
                //    aValidationMSG.Add(oMSG);
                //} //end if

                if (!bIsvalid)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "ITEM#" + item.PRODSTOCK_ID;
                    oMSG.VAL_ERRMSG = "ERROR";
                    aValidationMSG.Add(oMSG);
                } //End if
            } //end loop

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ITEM0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()

        private void Validate_TRN_DT()
        {
            Boolean bIsvalid = true;
            //[TRN_DT] - Required
            if (oViewModel.TRN_DT == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_DT1";
                oMSG.VAL_ERRMSG = "Tanggal mutasi harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[TRN_DT] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_DT0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_TRN_DT()
        private void Validate_TRN_CODE()
        {
            Boolean bIsvalid = true;
            //[TRN_CODE] - Required
            if ((oViewModel.TRN_CODE == "") || (oViewModel.TRN_CODE == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_CODE1";
                oMSG.VAL_ERRMSG = "Nomor mutasi harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[TRN_CODE] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_CODE0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_TRN_CODE()
        private void Validate_TRN_RECIPIENT()
        {
            Boolean bIsvalid = true;
            //[TRN_RECIPIENT] - Required
            if ((oViewModel.TRN_RECIPIENT == "") || (oViewModel.TRN_RECIPIENT == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_RECIPIENT1";
                oMSG.VAL_ERRMSG = "Kolom diterima oleh harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[TRN_RECIPIENT] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_RECIPIENT0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_TRN_RECIPIENT()
        private void Validate_TRN_DESC()
        {
            Boolean bIsvalid = true;
            //[TRN_DESC] - Required
            if ((oViewModel.TRN_DESC == "") || (oViewModel.TRN_DESC == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_DESC1";
                oMSG.VAL_ERRMSG = "Alamat harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[TRN_DESC] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TRN_DESC0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_TRN_DESC()
    } //End public partial class Trnstock_Validation
} //End namespace APPBASE.Models
