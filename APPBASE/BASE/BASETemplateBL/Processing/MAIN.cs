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
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public TemplateBL() {
            this._RESULT = true;
            this.db = new DBMAINContext();
        } //End Constructor
        //Constructor 2
        public TemplateBL(DBMAINContext poDB) {
            this._RESULT = true;
            this.db = poDB;
        } //End Constructor
        //Initialize
        public Boolean Init() {
            if (this._RESULT == true) {
                //HEADER
                //DETAIL
                //Return
            } //End if
            return this._RESULT;
        } //End Method
        //Process
        public virtual Boolean Process()
        {
            if (this._RESULT == true) {
                //Set HEADER ADD
                if (!this.setHEADER()) { this._RESULT = false; return false; } //End return false
                //Set DETAIL ADD
                if (!this.setDETAIL()) { this._RESULT = false; return false; } //End return false
            } //End if

            //Return
            return this._RESULT;
        } //End Method
        //Save
        public Boolean Save() {
            if (this._RESULT == true) {
                //HEADER-TRNSTOCK
                if (!this.saveHEADER()) { this._RESULT = false; return false; } //End return false
                //DETAIL-TRNSTOCKD
                if (!this.saveDETAIL()) { this._RESULT = false; return false; } //End return false
            } //End if
            
            //Return
            return this._RESULT;
        } //End Method
        //Commit
        public Boolean Commit()
        {
            try { if (this._RESULT) this.db.SaveChanges(); } //End try
            catch (Exception e) { this._RESULT = false; this._ERRMSG_result = e.Message; } //End catch
            //Return
            return this._RESULT; ;
        } //End Method
        //Rollback
        public Boolean Rollback()
        {
            try { this.db.Dispose(); } //End try
            catch (Exception e) { this._RESULT = false; this._ERRMSG_result = e.Message; } //End catch
            //Return
            return true;
        } //End Method

        //Dispose
        public void Dispose() { } //End dispose
    } //End Class
} //End namespace APPBASE.Models
