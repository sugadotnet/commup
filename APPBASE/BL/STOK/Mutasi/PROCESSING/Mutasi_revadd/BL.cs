using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_revaddBL : Mutasi_revBL
    {
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public Mutasi_revaddBL() : base() { } //End Constructor
        //Constructor 2
        public Mutasi_revaddBL(DBMAINContext poDB) : base(poDB) { } //End Constructor
    } //End Method
} //End namespace APPBASE.Models
