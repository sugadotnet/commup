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
        protected virtual Boolean setHEADER() {
            this._HEADER_result = this._HEADER_data;
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
