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
    public partial class Incometype_Validation
    {
        private void Validate_LOV_DESC()
        {
            Boolean bIsvalid = true;
            //[LOV_DESC] - Required
            if (oViewModel.LOV_DESC == null)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "LOV_DESC1";
                oMSG.VAL_ERRMSG = "Jenis Penerimaan harus diisi";
                aValidationMSG.Add(oMSG);
            } //End if
            ////[LOV_DESC] - Unique
            //if (oDS.isExists_LOV_DESC(oViewModel.LOV_DESC))
            //{
            //    bIsvalid = false;
            //    ValidationMSG_VM oMSG = new ValidationMSG_VM();
            //    oMSG.VAL_ERRID = "LOV_DESC2";
            //    oMSG.VAL_ERRMSG = "ID " + oViewModel.LOV_DESC + " sudah digunakan";
            //    aValidationMSG.Add(oMSG);
            //} //End if

            //[LOV_DESC] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "LOV_DESC0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_LOV_DESC()
    } //End public partial class Incometype_Validation
} //End namespace APPBASE.Models
