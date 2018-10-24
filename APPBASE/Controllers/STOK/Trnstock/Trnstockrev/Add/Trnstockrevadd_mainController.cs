using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPBASE.Models;
using APPBASE.Helpers;
using APPBASE.Filters;
using APPBASE.Svcbiz;


namespace APPBASE.Controllers
{
    [MyActionFilterAttribute]
    public partial class TrnstockrevaddController : TrnstockrevController
    {
        protected void generalInitialize()
        {
            ViewBag.IndexButtonTitle = "Tambah Stok";
            ViewBag.IndexActionTitle = "Tambah Stok";
            this.TRN_TYPEID = valFLAG.TRN_TYPEID_REVADD;
        } //end method

        //Constructor 1
        public TrnstockrevaddController() : base(new DBMAINContext()) { this.generalInitialize(); }
        //Constructor 2
        public TrnstockrevaddController(DBMAINContext poDB) : base(poDB) { this.generalInitialize(); }
    } //End class
} //End namespace
