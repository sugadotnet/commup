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
using APPBASE;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Incometype_Validation
    {
        private IncometypedetailVM oViewModel;
        private IncometypeDS oDS = new IncometypeDS();
        public List<ValidationMSG_VM> aValidationMSG = new List<ValidationMSG_VM>();

        //Constructor
        public Incometype_Validation(IncometypedetailVM poViewModel)
        {
            oViewModel = poViewModel;
        } //End public Incometype_Validation()
        public void Validate_Create()
        {
            Validate_LOV_DESC();
        } //End public void Validate_Create()
        public void Validate_Edit()
        {
            Validate_LOV_DESC();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            //Validate_LOV_DESC();
        } //End public void Validate_Delete()
    } //End public partial class Incometype_Validation
} //End namespace APPBASE.Models
