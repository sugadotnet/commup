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
        protected override Boolean setHEADER() {
            base.setHEADER();
            this.__TRNSTOCK.TRN_TYPEID = 2; //Penjualan
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
