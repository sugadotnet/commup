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
    public partial class Employee_Validation
    {
        private void Validate_NIP()
        {
            Boolean bIsvalid = true;
            //[NIP] - Required
            if (oViewModel.NIP == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "NIP1";
                oMSG.VAL_ERRMSG = "NIP harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if
            ////[NIP] - Unique
            //if (oDS.isExists_NIP(oViewModel.NIP))
            //{
            //    bIsvalid = false;
            //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
            //    oMSG.VAL_ERRID = "NIP2";
            //    oMSG.VAL_ERRMSG = "ID " + oViewModel.NIP + " sudah digunakan";
            //    aValidationMSG.Add(oMSG);
            //} //End if

            //[NIP] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "NIP0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_NIP()
    } //End public partial class Employee_Validation
} //End namespace APPBASE.Models

