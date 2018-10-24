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
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public IDMutasiBL() {
            this.db = new DBMAINContext();
        } //End Constructor
        //Constructor 2
        public IDMutasiBL(DBMAINContext poDB) {
            this.db = poDB;
        } //End Constructor
        //Initialize
        public Boolean Init(string psID) {
            this.__IDMUTASI = new IdmutasiVM();
            this.__ID = psID;
            //Return
            return true;
        } //End Method
        //Process
        public Boolean Process()
        {
            if ((this.__ID == null) || (this.__ID == "")) return this.setGenerateID();
            else return this.setManualID();
        } //End Method

        //Save
        public Boolean Save() {
            if (!_IS_MANUAL) {
                if (this._IS_NEW) this._CRUD.Create(__IDMUTASI);
                else this._CRUD.Update(__IDMUTASI);
            } //End if
            
            //Return
            return true;
        } //End Method
        //Commit
        public Boolean Commit()
        {
            if (!_IS_MANUAL) {
                this._CRUD.Commit();
            } //End if
            return true;
        } //End Method

        //Dispose
        public void Dispose() { }
    } //End Method
} //End namespace APPBASE.Models
