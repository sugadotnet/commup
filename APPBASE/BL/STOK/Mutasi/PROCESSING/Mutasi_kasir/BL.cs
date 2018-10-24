using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_kasirBL : MutasiBL
    {
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public Mutasi_kasirBL() : base() { } //End Constructor
        //Constructor 2
        public Mutasi_kasirBL(DBMAINContext poDB) : base(poDB) { } //End Constructor

        //Process
        public override Boolean Process()
        {
            base.Process();
            this.calcDETAIL();

            //Return
            return true;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
