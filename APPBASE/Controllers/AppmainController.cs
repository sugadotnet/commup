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
//using APPBASE.Svcapp;
using APPBASE.Svcbiz;


namespace APPBASE.Controllers
{
    [MyActionFilterAttribute]
    public partial class AppmainController : Controller
    {
        public string AC_MENU_RUID = "";
    } //End public partial class AppmainController : Controller
} //End namespace APPBASE.Controllers

