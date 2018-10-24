using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_kasirBL : MutasiBL {
        protected override Boolean setDETAIL() {
            base.setDETAIL();
            for (int i = 0; i < this.__TRNSTOCKDS.Count; i++)
            {
                this.__TRNSTOCKDS[i].STORAGE_TARGETID = 4; //Kasir
            } //End for
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
