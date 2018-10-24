using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class TemplateBL
    {
        //Error
        protected string _ERRMSG_result;
        public string ERRMSG_result { get; set; }
        protected Boolean _RESULT;
        public Boolean RESULT { get { return this._RESULT; } }

        //HEADER
        private BaseVM _HEADER_result;
        public BaseVM HEADER_result { get { return this._HEADER_result; } }
        //DETAIL
        private Base_detailVM _DETAIL_result;
        public Base_detailVM DETAIL_result { get { return this._DETAIL_result; } }
        //DETAIL list
        private List<Base_detailVM> _DETAIL_resultlist;
        public List<Base_detailVM> DETAIL_resultlist { get { return this._DETAIL_resultlist; } }
    } //End Method
} //End namespace APPBASE.Models
