using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class TemplateBL
    {
        //HEADER
        private BaseCRUD _CRUD;
        public BaseCRUD CRUD { get { return this._CRUD; } set { this._CRUD = value; } }

        //DETAIL
        private Base_detailCRUD _CRUD_detail;
        public Base_detailCRUD CRUD_detail { get { return this._CRUD_detail; } set { this._CRUD_detail = value; } }
    } //End Method
} //End namespace APPBASE.Models
