using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_newBL : MutasiBL {
        protected override Boolean setDETAIL() {
            base.setDETAIL();
            foreach (var item in this._TRNSTOCKDS)
            {
                item.STORAGE_BASEID = null;
            } //End foreach
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
