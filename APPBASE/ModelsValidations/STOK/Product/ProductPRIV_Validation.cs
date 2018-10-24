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
    public partial class Product_Validation
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
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()

        private void Validate_PRODNEW_ID()
        {
            Boolean bIsvalid = true;
            ////[PRODNEW_ID] - Required
            //if (oViewModel.PRODNEW_ID == null) {
            //    bIsvalid = false;
            //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
            //    oMSG.VAL_ERRID = "PRODNEW_ID1";
            //    oMSG.VAL_ERRMSG = "PRODNEW_ID harus diisi";
            //    aValidationMSG.Add(oMSG);
            //} //End if
            //[PRODNEW_ID] - Unique
            if (oDS.isExists_PRODNEW_ID(oViewModel.PRODNEW_ID))
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "PRODNEW_ID2";
                oMSG.VAL_ERRMSG = "Produk " + oViewModel.PROD_NAME + " sudah divalidasi";
                aValidationMSG.Add(oMSG);
            } //End if

            //[PRODNEW_ID] - If has error(s)
            //if (!bIsvalid)
            //{
            //    bIsvalid = false;
            //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
            //    oMSG.VAL_ERRID = "PRODNEW_ID0";
            //    oMSG.VAL_ERRMSG = "ERROR";
            //    aValidationMSG.Add(oMSG);
            //} //End if
        } //End private void Validate_PRODNEW_ID()
    
    } //End public partial class Product_Validation
} //End namespace APPBASE.Models
