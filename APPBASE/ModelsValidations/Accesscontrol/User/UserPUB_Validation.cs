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
    public partial class User_Validation
    {
        private UserdetailVM oViewModel;
        private UserDS oDS = new UserDS();
        public List<ValidationMSG_VM> aValidationMSG = new List<ValidationMSG_VM>();

        //Constructor
        public User_Validation(UserdetailVM poViewModel)
        {
            oViewModel = poViewModel;
        } //End public User_Validation()
        public void Validate_Create()
        {
            Validate_USERNAMENEW();
            Validate_PASSWORD();
            Validate_DISPLAY_NAME();
            Validate_EMAIL();
            Validate_ROLE_ID();
            Validate_RES_ID();
        } //End public void Validate_Create()
        public void Validate_Edit()
        {
            Validate_USERNAMEEDIT();
            Validate_PASSWORD();
            Validate_DISPLAY_NAME();
            Validate_EMAIL();
            Validate_ROLE_ID();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            //Validate_ID();
        } //End public void Validate_Delete()
        public void Validate_Changepassword()
        {
            Validate_PASSWORD();
            Validate_PASSWORD_NEW1();
            Validate_PASSWORD_NEW2();
        } //End public void Validate_Edit()
    } //End public partial class User_Validation
} //End namespace APPBASE.Models

