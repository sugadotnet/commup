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
        protected virtual Boolean setDETAIL() {
            this._DETAIL_resultlist = this._DETAIL_datalist;
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
