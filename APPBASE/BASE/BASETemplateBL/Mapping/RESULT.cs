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
        //Error
        protected string _ERRMSG_data;
        public string ERRMSG_result { get; set; }
        protected Boolean _RESULT;
        public Boolean RESULT { get { return this._RESULT; } }

        //HEADER
        private BaseVM _HEADER_result;
        public BaseVM HEADER_result { get { return this._HEADER_result; } }

        //DETAIL
        private List<Base_detailVM> _DETAIL_resultlist;
        public List<Base_detailVM> DETAIL_resultlist { get { return this._DETAIL_resultlist; } }
    } //End public partial class TrnstockVM
} //End namespace APPBASE.Models
