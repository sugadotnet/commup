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
        protected Boolean saveDETAIL()
        {
            //TRNSTOCKD
            this.__TRNSTOCK.ID = _CRUD.ID;
            foreach (var item in this.__TRNSTOCKDS)
            {
                item.TRN_ID = this.__TRNSTOCK.ID;
            } //End foreach
            if (this._CRUD.ID > 0) _CRUDDetail.Create(this.__TRNSTOCKDS);
            if (_CRUDDetail.isERR)
            {
                _CRUD.Delete(_CRUD.ID);
                return false;
            } //End if

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
