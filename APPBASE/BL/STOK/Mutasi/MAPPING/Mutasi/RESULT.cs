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
    public partial class StockMAP
    {
        //Error Message
        protected string _ERRMSG;
        public string ERRMSG_result { get; set; }

        //TRNSTOCK
        protected TrnstockVM _TRNSTOCK_result;
        public TrnstockVM TRNSTOCK_result { get { return this._TRNSTOCK_result; } }
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
