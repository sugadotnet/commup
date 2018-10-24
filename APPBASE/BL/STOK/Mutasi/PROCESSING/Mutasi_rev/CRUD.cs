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
        //TRNSTOCK
        protected TrnstockCRUD _CRUD;
        public TrnstockCRUD CRUD { get { return this._CRUD; } set { this._CRUD = value; } }
        //TRNSTOCKD
        protected TrnstockdCRUD _CRUDDetail;
        public TrnstockdCRUD CRUDDetail { get { return this._CRUDDetail; } set { this._CRUDDetail = value; } }
        //PRODUCTSTOCK
        protected ProductstockCRUD _CRUDProductstock;
        public ProductstockCRUD CRUDProductstock { get { return this._CRUDProductstock; } set { this._CRUDProductstock = value; } }
    } //End Method
} //End namespace APPBASE.Models
