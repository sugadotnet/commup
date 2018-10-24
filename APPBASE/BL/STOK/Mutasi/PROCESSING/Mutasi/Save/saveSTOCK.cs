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
        protected Boolean saveSTOCK()
        {
            //PRODUCTSTOCK
            this._CRUDProductstock.Create(this.__PRODUCTSTOCKS_NEW);
            this._CRUDProductstock.Update(this.__PRODUCTSTOCKS_UPDATE);
            this._CRUDProductstock.Commit();

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
