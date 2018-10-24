using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class MutasiBL
    {
        //To be saved
        //TRNSTOCK
        protected TrnstockVM __TRNSTOCK;
        //TRNSTOCKDS
        protected List<TrnstockdVM> __TRNSTOCKDS;
        //PRODUCTSTOCK
        protected ProductstockVM __PRODUCTSTOCK;
        //PRODUCTSTOCKS
        protected List<ProductstockVM> __PRODUCTSTOCKS_NEW;
        protected List<ProductstockVM> __PRODUCTSTOCKS_UPDATE;
    } //End Method
} //End namespace APPBASE.Models
