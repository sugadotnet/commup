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
    public partial class Summary_sell_Validation
    {
        private Summary_sellVM oViewModel;
        private Summary_sellDS oDS;
        public List<ValidationMSG_VM> aValidationMSG;

        //Constructor 1
        public Summary_sell_Validation(Summary_sellVM poViewModel)
        {
            this.oViewModel = poViewModel;
            this.oDS = new Summary_sellDS();
            aValidationMSG = new List<ValidationMSG_VM>();
        } //End Constructor 1
        //Constructor 2
        public Summary_sell_Validation(Summary_sellVM poViewModel, Summary_sellDS poDS)
        {
            this.oViewModel = poViewModel;
            this.oDS = poDS;
            aValidationMSG = new List<ValidationMSG_VM>();
        } //End Constructor 2

        public void Validate_Create()
        {
            //Validate_();
        } //End public void Validate_Create()
        public void Validate_Edit()
        {
            //Validate_();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            //Validate_();
        } //End public void Validate_Delete()
    } //End public partial class Summary_sell_Validation
} //End namespace APPBASE.Models
