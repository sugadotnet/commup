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
        private Boolean saveDETAIL_single()
        {
            //HEADER
            this._HEADER_result.ID = _CRUD.ID;
            //DETAIL
            this._DETAIL_result.HEADER_ID = this._HEADER_result.ID;
            this._DETAIL_resultlist.Add(this._DETAIL_result);
            //CRUD
            this._CRUD_detail.Create(this._DETAIL_result);
            if (this._CRUD_detail.isERR)
            {
                this._CRUD.Delete(_CRUD.ID);
                this._CRUD.Commit();
                return false;
            } //End if
            
            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
