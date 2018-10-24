using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class MutasiBL
    {
        protected virtual Boolean setHEADER() {
            this.__TRNSTOCK = this._TRNSTOCK;
            this.__TRNSTOCK.TRN_TYPEID = valFLAG.TRN_TYPEID_MUTASI;

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
