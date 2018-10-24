using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_revBL
    {
        private Boolean saveHEADER() {
            //TRNSTOCK
            this._CRUD.Create(this.__TRNSTOCK);
            if (this._CRUD.isERR) return false;

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
