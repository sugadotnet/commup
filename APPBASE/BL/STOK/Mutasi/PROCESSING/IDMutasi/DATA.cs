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
        //FLAG
        protected Boolean _IS_NEW = false;
        protected Boolean _IS_MANUAL = false;
        //MONTHS
        protected String[] _MONTHS_CODE = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };
        //PRODUCTS
        private IdmutasiVM _IDMUTASI;
        public void inject_IDMUTASI(IdmutasiVM poDATA = null)
        {
            //if (poDATA == null) this._IDMUTASI = new IdmutasiVM();
            //else this._IDMUTASI = poDATA;
            this._IDMUTASI = poDATA;
        } //End Method


    } //End Method
} //End namespace APPBASE.Models
