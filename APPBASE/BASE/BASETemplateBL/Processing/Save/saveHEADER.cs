using System;
using System.Collections.Generic;
using System.Linq;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class TemplateBL
    {
        private Boolean saveHEADER() {
            //HEADER
            this._CRUD.Create(this._HEADER_result);
            //Code header mapping here...

            if (this._CRUD.isERR) return false;
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
