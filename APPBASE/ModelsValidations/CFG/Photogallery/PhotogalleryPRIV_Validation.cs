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
    public partial class Photogallery_Validation
    {
        private void Validate_TITLE()
        {
            Boolean bIsvalid = true;
            //[TITLE] - Required
            if (oViewModel.TITLE == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TITLE1";
                oMSG.VAL_ERRMSG = "TITLE harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if
            ////[TITLE] - Unique
            //if (oDS.isExists_TITLE(oViewModel.TITLE))
            //{
            //    bIsvalid = false;
            //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
            //    oMSG.VAL_ERRID = "TITLE2";
            //    oMSG.VAL_ERRMSG = "ID " + oViewModel.TITLE + " sudah digunakan";
            //    aValidationMSG.Add(oMSG);
            //} //End if

            //[TITLE] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "TITLE0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_TITLE()
    } //End public partial class Photogallery_Validation
} //End namespace APPBASE.Models
