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
        //HEADER
        private BaseVM _HEADER_data;
        public BaseVM HEADER_data { set { this._HEADER_data = value; } }

        //DETAIL
        private Base_detailVM _DETAIL_data;
        public Base_detailVM DETAIL_data { set { this._DETAIL_data = value; } }
        //DETAIL list
        private List<Base_detailVM> _DETAIL_datalist;
        public List<Base_detailVM> DETAIL_datalist { set { this._DETAIL_datalist = value; } }
    } //End Method
} //End namespace APPBASE.Models
