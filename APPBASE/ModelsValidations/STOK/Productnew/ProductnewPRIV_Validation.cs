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
    public partial class Productnew_Validation
    {
        private void Validate_ID()
        {
            Boolean bIsvalid = true;
            //[ID] - Required
            if (oViewModel.ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ID1";
                oMSG.VAL_ERRTYPE = "TEXT";
                oMSG.VAL_ERRMSG = "ID harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if
            ////[ID] - Unique
            //if (oDS.isExists_ID(oViewModel.ID))
            //{
            //    bIsvalid = false;
            //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
            //    oMSG.VAL_ERRID = "ID2";
            //    oMSG.VAL_ERRMSG = "ID " + oViewModel.ID + " sudah digunakan";
            //    aValidationMSG.Add(oMSG);
            //} //End if

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ID0";
                oMSG.VAL_ERRTYPE = "TEXT";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()
        private void Validate_PRODNEW_CODE()
        {
            Boolean bIsvalid = true;
            //[PRODNEW_CODE] - Required
            if ((oViewModel.PRODNEW_CODE == "") || (oViewModel.PRODNEW_CODE == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODNEW_CODE1";
                oMSG.VAL_ERRTYPE = "TEXT";
                oMSG.VAL_ERRMSG = "Kode tidak berhasil diproses";
                aValidationMSG.Add(oMSG);
            } //End if

            if (bIsvalid) {
                //[PRODNEW_CODE] - length
                if (oViewModel.PRODNEW_CODE.Length != 13)
                {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "PRODNEW_CODE2";
                    oMSG.VAL_ERRTYPE = "TEXT";
                    oMSG.VAL_ERRMSG = "Format kode tidak sesuai, seharusnya 13 digit";
                    aValidationMSG.Add(oMSG);
                } //End if
            } //end if

            //[PRODNEW_CODE] - Unique
            if (oDS.isExists_PRODNEW_CODE(oViewModel.ID, oViewModel.PRODNEW_CODE))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODNEW_CODE3";
                oMSG.VAL_ERRTYPE = "LINK";
                oMSG.VAL_ERRMSG = "Kode " + oViewModel.PRODNEW_CODE + " sudah pernah digunakan";
                aValidationMSG.Add(oMSG);
            } //End if

            //[PRODNEW_CODE] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODNEW_CODE0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_PRODNEW_CODE()

        private void Validate_COUNTRY_ID()
        {
            Boolean bIsvalid = true;
            //[COUNTRY_ID] - Required
            if (oViewModel.COUNTRY_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "COUNTRY_ID1";
                oMSG.VAL_ERRMSG = "Kode negara harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[COUNTRY_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "COUNTRY_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_COUNTRY_ID()
        private void Validate_VENDOR_ID()
        {
            Boolean bIsvalid = true;
            //[VENDOR_ID] - Required
            if (oViewModel.VENDOR_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "VENDOR_ID1";
                oMSG.VAL_ERRMSG = "Vendor harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[VENDOR_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "VENDOR_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_VENDOR_ID()
        private void Validate_PRODTYPE_ID()
        {
            Boolean bIsvalid = true;
            //[PRODTYPE_ID] - Required
            if (oViewModel.PRODTYPE_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODTYPE_ID1";
                oMSG.VAL_ERRMSG = "Tipe produk harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[PRODTYPE_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODTYPE_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_PRODTYPE_ID()
        private void Validate_PRODSUBTYPE_ID()
        {
            Boolean bIsvalid = true;
            //[PRODSUBTYPE_ID] - Required
            if (oViewModel.PRODSUBTYPE_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODSUBTYPE_ID1";
                oMSG.VAL_ERRMSG = "Jenis produk harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[PRODSUBTYPE_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODSUBTYPE_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_PRODSUBTYPE_ID()
        private void Validate_SERIAL_ID()
        {
            Boolean bIsvalid = true;
            //[SERIAL_ID] - Required
            if (oViewModel.SERIAL_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "SERIAL_ID1";
                oMSG.VAL_ERRMSG = "Serial harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[SERIAL_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "SERIAL_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_SERIAL_ID()
        private void Validate_FINISHING_ID()
        {
            Boolean bIsvalid = true;
            //[FINISHING_ID] - Required
            if (oViewModel.FINISHING_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "FINISHING_ID1";
                oMSG.VAL_ERRMSG = "Finishing harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[FINISHING_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "FINISHING_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_FINISHING_ID()
        private void Validate_UKURAN_ID()
        {
            Boolean bIsvalid = true;
            //[UKURAN_ID] - Required
            if (oViewModel.UKURAN_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "UKURAN_ID1";
                oMSG.VAL_ERRMSG = "Ukuran harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[UKURAN_ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "UKURAN_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_UKURAN_ID()

    } //End public partial class Productnew_Validation
} //End namespace APPBASE.Models
