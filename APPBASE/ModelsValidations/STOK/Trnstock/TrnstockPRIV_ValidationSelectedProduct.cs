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
        private void Validate_SelectedProduct()
        {
            Boolean bIsvalid = true;
            Boolean selectedItem = true;
            //[SP - Selected Product] - Required
            if (this.oViewModel_productstock.LIST_INDEX == null)
            {
                selectedItem = false;
            }
            else {
                List<ProductstockVM> vTemp = this.oViewModel_productstock.LIST_INDEX.Where(f =>
                    f.ID != null).ToList();
                if (vTemp == null) selectedItem = false;
                else if (vTemp.Count <= 0) selectedItem = false;
            } //end if
            if (!selectedItem)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "SP1";
                oMSG.VAL_ERRMSG = "Produk belum dipilih";
                aValidationMSG.Add(oMSG);
            } //end if

            //[SP - Selected Product] - If has error(s)
            if (!bIsvalid)
            {
                bIsvalid = false;
                ValidationMSG_VM oMSG = new ValidationMSG_VM();
                oMSG.VAL_ERRID = "SP0";
                oMSG.VAL_ERRMSG = "ERROR";
                aValidationMSG.Add(oMSG);
            } //End if
        } //End private void Validate_ID()
    } //End public partial class Trnstock_Validation
} //End namespace APPBASE.Models
