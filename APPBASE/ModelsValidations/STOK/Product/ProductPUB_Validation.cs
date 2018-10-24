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
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public partial class Product_Validation
    {
        private ProductVM oViewModel;
        private List<ProductVM> oViewModels;
        private ProductDS oDS = new ProductDS();
        public List<ValidationMSG_VM> aValidationMSG = new List<ValidationMSG_VM>();

        //Constructor 1
        public Product_Validation(ProductVM poViewModel)
        {
            oViewModel = poViewModel;
        } //End public Product_Validation()
        //Constructor 2
        public Product_Validation(List<ProductVM> poViewModels)
        {
            oViewModels = poViewModels;
        } //End public Product_Validation()
        public void Validate_Create()
        {
            //Validate_ID();
        } //End public void Validate_Create()
        public void Validate_Createbulk()
        {
            //Validate_ID();
            Validate_PRODNEW_ID();
        } //End public void Validate_Createbulk()
        public void Validate_Edit()
        {
            //Validate_ID();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            //Validate_ID();
        } //End public void Validate_Delete()
    } //End public partial class Product_Validation
} //End namespace APPBASE.Models
