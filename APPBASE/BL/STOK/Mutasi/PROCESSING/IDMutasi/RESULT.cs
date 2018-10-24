using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class IDMutasiBL
    {
        //ID
        protected string __ID = "";
        public string ID { get { return this.__ID; } set { this.__ID = value; } }

        //IDMutasi
        private IdmutasiVM __IDMUTASI;
    } //End Method
} //End namespace APPBASE.Models
