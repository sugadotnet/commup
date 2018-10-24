using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_newBL : MutasiBL
    {
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public Mutasi_newBL() : base() { } //End Constructor
        //Constructor 2
        public Mutasi_newBL(DBMAINContext poDB) : base(poDB) { } //End Constructor

        //Process
        public override Boolean Process()
        {
            //Map HEADER
            if (!this.mapHEADER()) return false;
            //Map DETAIL
            if (!this.mapDETAIL()) return false;
            //base.Process();
            //Set HEADER ADD
            if (!this.setHEADER()) return false;
            //Set DETAIL ADD
            if (!this.setDETAIL()) return false;
            //this.calcDETAIL();

            //Return
            return true;
        } //End Method
        //Save
        public override Boolean Save()
        {
            //HEADER-TRNSTOCK
            if (!this.saveHEADER()) return false;
            //DETAIL-TRNSTOCKD
            if (!this.saveDETAIL()) return false;

            //Return
            return true;
        } //End Method

    } //End Method
} //End namespace APPBASE.Models
