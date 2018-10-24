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
    public partial class UserBRANCH_Validation
    {
        private void Validate_USERNAMENEW()
        {
            Boolean bIsvalid = true;
            //[Username] - Required
            if ((oViewModel.USERNAME == "") || (oViewModel.USERNAME == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "USERNAME1";
                oMSG.VAL_ERRMSG = "Username harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[USERNAME] - Unique
            if (oDS.isExists_Username(oViewModel.USERNAME))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "USERNAME2";
                oMSG.VAL_ERRMSG = "Username " + oViewModel.ID + " sudah digunakan";
                aValidationMSG.Add(oMSG);
            } //End if

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "USERNAME0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_USERNAMENEW()
        private void Validate_USERNAMEEDIT()
        {
            Boolean bIsvalid = true;
            //[Username] - Required
            if ((oViewModel.USERNAME == "") || (oViewModel.USERNAME == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "USERNAME1";
                oMSG.VAL_ERRMSG = "Username harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "USERNAME0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_USERNAMEEDIT()
        private void Validate_PASSWORD()
        {
            Boolean bIsvalid = true;
            //[Password] - Required
            if ((oViewModel.PASSWORD == "") || (oViewModel.PASSWORD == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PASSWORD1";
                oMSG.VAL_ERRMSG = "Password harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if
            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PASSWORD0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_PASSWORD()
        private void Validate_DISPLAY_NAME()
        {
            Boolean bIsvalid = true;
            //[Password] - Required
            if ((oViewModel.DISPLAY_NAME == "") || (oViewModel.DISPLAY_NAME == null))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "DISPLAY_NAME1";
                oMSG.VAL_ERRMSG = "Nama Alias harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if
            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "DISPLAY_NAME0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_PASSWORD()
        private void Validate_EMAIL()
        {
            Boolean bIsvalid = true;
            //[Password] - Required
            if ((oViewModel.EMAIL != "") && (oViewModel.EMAIL != null))
            {
                if (!hlpValidation.isValidEmail(oViewModel.EMAIL)) {
                    bIsvalid = false;
                    ValidationMSG_VM oMSG = new ValidationMSG_VM();
                    oMSG.VAL_ERRID = "EMAIL1";
                    oMSG.VAL_ERRMSG = "Format email tidak sesuai (contoh yang benar : example@email.com)";
                    aValidationMSG.Add(oMSG);
                } //End if (!hlpValidation.isValidEmail(oViewModel.EMAIL))
            } //End if
            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "EMAIL0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_PASSWORD()
        private void Validate_ROLE_ID()
        {
            Boolean bIsvalid = true;
            //[Password] - Required
            if (oViewModel.ROLE_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ROLE_ID1";
                oMSG.VAL_ERRMSG = "Hak akses harus ditentukan";
                aValidationMSG.Add(oMSG);
            } //End if
            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "ROLE_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ROLE_ID()
        private void Validate_RES_ID()
        {
            Boolean bIsvalid = true;
            //[Password] - Required
            if (oViewModel.RES_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "RES_ID1";
                oMSG.VAL_ERRMSG = "Harap pilih karyawan";
                aValidationMSG.Add(oMSG);
            } //End if
            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "RES_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_RES_ID()
        private void Validate_BRANCH_ID()
        {
            Boolean bIsvalid = true;
            //[Password] - Required
            if (oViewModel.BRANCH_ID == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "BRANCH_ID1";
                oMSG.VAL_ERRMSG = "Cabang harus dipilih";
                aValidationMSG.Add(oMSG);
            } //End if
            //[ID] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "BRANCH_ID0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_BRANCH_ID()
    } //End public partial class User_Validation
} //End namespace APPBASE.Models

