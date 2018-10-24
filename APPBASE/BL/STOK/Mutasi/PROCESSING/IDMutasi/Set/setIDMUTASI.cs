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
        private DateTime? _DATETIME;

        private Boolean setGenerateID() {
            //Set default value
            this._IS_MANUAL = false;
            this._IS_NEW = false;
            this.__IDMUTASI = this._IDMUTASI;
            //Check if new row of IDMutasi
            if (this.__IDMUTASI == null) {
                this._IS_NEW = true;
                this.__IDMUTASI = new IdmutasiVM();
                this.__IDMUTASI.ID_COUNTER = 0;
            } //End if
            //Start map
            this._DATETIME = DateTime.Now;
            this.__IDMUTASI.ID_COUNTER = this.__IDMUTASI.ID_COUNTER + 1;
            this.__IDMUTASI.ID_YEAR = this._DATETIME.Value.Year;
            this.__IDMUTASI.ID_MONTH = this._DATETIME.Value.Month;
            //Set formating Number
            this.formatID();
            //Set current and last id
            this.__IDMUTASI.ID_LAST = this.__IDMUTASI.ID_CURRENT;
            this.__IDMUTASI.ID_CURRENT = this.__ID;
            //Return
            return true;
        } //End Method
        private Boolean setManualID()
        {
            this._IS_MANUAL = true;

            return true;
        } //End Method
        private Boolean formatID() {

            try
            {
                this.__ID = this.__IDMUTASI.ID_COUNTER.ToString() +
                            "/KMB/" +
                            this._MONTHS_CODE[(int)this.__IDMUTASI.ID_MONTH] + "/" +
                            this.__IDMUTASI.ID_YEAR.ToString();
            }
            catch (Exception) { return false; }

            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
