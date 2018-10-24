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
        private Boolean saveDETAIL()
        {
            //HEADER
            this._HEADER_result.ID = _CRUD.ID;
            //DETAIL
            foreach (var item in this._DETAIL_datalist)
            {
                item.HEADER_ID = this._HEADER_result.ID;
                //Code detail mapping here...

                this._DETAIL_resultlist.Add(item);
                this._DETAIL_result = item;
                this._CRUD_detail.Create(this._DETAIL_result);
                if (_CRUD_detail.isERR)
                {
                    _CRUD.Delete(_CRUD.ID);
                    return false;
                } //End if
            } //End foreach
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
