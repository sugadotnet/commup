using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class IDMutasiBL
    {
        //TRNSTOCK
        private IdmutasiCRUD _CRUD;
        public IdmutasiCRUD CRUD { get { return this._CRUD; } set { this._CRUD = value; } }
        public void inject_IdmutasiCRUD(IdmutasiCRUD poDATA = null)
        {
            if (poDATA == null) this._CRUD = new IdmutasiCRUD();
            else this._CRUD = poDATA;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
