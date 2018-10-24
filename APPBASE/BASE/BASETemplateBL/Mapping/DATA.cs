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
        //HEADER
        private BaseVM _HEADER_data;
        public BaseVM HEADER_data { set { this._HEADER_data = value; } }

        //DETAIL
        private List<Base_detailVM> _DETAIL_datalist;
        public List<Base_detailVM> DETAIL_datalist { set { this._DETAIL_datalist = value; } }
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
