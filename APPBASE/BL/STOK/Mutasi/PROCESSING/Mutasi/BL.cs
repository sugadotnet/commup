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
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public MutasiBL() {
            this.db = new DBMAINContext();
        } //End Constructor
        //Constructor 2
        public MutasiBL(DBMAINContext poDB) {
            this.db = poDB;
        } //End Constructor
        //Initialize
        public Boolean Init() {
            //CRUD HEADER
            //this._CRUD = new TrnstockCRUD();
            //CRUD DETAIL
            //this._CRUDDetail = new TrnstockdCRUD();
            //CRUD PRODUCTSTOCK
            //this._CRUDProductstock = new ProductstockCRUD(db);

            //HEADER
            this.__TRNSTOCK = new TrnstockVM();
            //DETAIL
            this.__TRNSTOCKDS = new List<TrnstockdVM>();
            this._TRNSTOCKD = new TrnstockdVM();
            //STOCK
            this.__PRODUCTSTOCKS_NEW = new List<ProductstockVM>();
            this.__PRODUCTSTOCKS_UPDATE = new List<ProductstockVM>();

            return true;
        } //End Method
        //Process
        public virtual Boolean Process()
        {
            //Set HEADER ADD
            if (!this.setHEADER()) return false;
            //Set DETAIL ADD
            if (!this.setDETAIL()) return false;
            //Set STOCK UPDATE
            if (!this.setSTOCKS()) return false;

            //Return
            return true;
        } //End Method

        //Save
        public virtual Boolean Save() {
            //HEADER-TRNSTOCK
            if (!this.saveHEADER()) return false;
            //DETAIL-TRNSTOCKD
            if (!this.saveDETAIL()) return false;
            //STOCK-PRODUCTSTOCK
            if (!this.saveSTOCK()) return false;

            //Return
            return true;
        } //End Method
        //Commit
        public Boolean Commit()
        {
            this._CRUDProductstock.Commit();
            return true;
        } //End Method

        //Dispose
        public void Dispose() { }
    } //End Method
} //End namespace APPBASE.Models
