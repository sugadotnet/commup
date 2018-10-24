using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_revsubBL : Mutasi_revBL {
        protected override Boolean setHEADER() {
            base.setHEADER();
            this.__TRNSTOCK.TRN_TYPEID = valFLAG.TRN_TYPEID_REVSUB;
            this.__TRNSTOCK.TRN_DESC = "Pengurangan stok";
            this.__TRNSTOCK.STORAGE_TARGETID = _STORAGE.ID;
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
