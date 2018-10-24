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
        //DATETIME
        protected DateTime? _DATETIME;
        public DateTime? DATETIME_data { get; set; }

        //TRNSTOCK
        protected TrnstockVM _TRNSTOCK_data;
        public TrnstockVM TRNSTOCK_data { set { this._TRNSTOCK_data = value; } }

        //PRODUCTSTOCK data
        protected ProductstockVM _PRODUCTSTOCK_data;
        public ProductstockVM PRODUCTSTOCK_data { set { this._PRODUCTSTOCK_data = value; } }
        //PRODUCTSTOCK datas
        protected List<ProductstockVM> _PRODUCTSTOCK_datas;
        public List<ProductstockVM> PRODUCTSTOCK_datas { set { this._PRODUCTSTOCK_datas = value; } }
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
