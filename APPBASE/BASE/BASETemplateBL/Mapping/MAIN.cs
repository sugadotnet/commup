using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class TemlateMAP
    {
        private DBMAINContext db;
        public DBMAINContext DB { get { return this.db; } set { this.db = value; } }

        //Constructor 1
        public TemlateMAP() {
            this._RESULT = true;
            this.db = new DBMAINContext();
        } //End Constructor
        //Constructor 2
        public TemlateMAP(DBMAINContext poDB) {
            this._RESULT = true;
            this.db = poDB;
        } //End Constructor
        //Initialize
        public Boolean Init() {

            //Return
            return this._RESULT;
        } //End Method
        //Process
        public Boolean Process()
        {
            //Return
            return this._RESULT;
        } //End Method
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
