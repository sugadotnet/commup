using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using APPBASE.Helpers;
using APPBASE.Models;

namespace APPBASE.Filters
{
//    public class MyActionFilterAttribute : ActionFilterAttribute

    public class MyActionFilterAttribute : ActionFilterAttribute, IResultFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            hlpCredentialInfo.isValidCredential(context);
            base.OnActionExecuted(context);
        } //End public override void OnActionExecuting(ActionExecutingContext context)
    } //End public class MyActionFilterAttribute
} //End namespace APPBASE.Filters