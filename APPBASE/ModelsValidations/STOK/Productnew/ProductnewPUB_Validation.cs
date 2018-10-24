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
    public partial class Productnew_Validation
    {
        private ProductnewVM oViewModel;
        private ProductnewDS oDS = new ProductnewDS();
        public List<ValidationMSG_VM> aValidationMSG = new List<ValidationMSG_VM>();
        private Barcode_13chars oBarCode;

        //Constructor 1
        public Productnew_Validation(ProductnewVM poViewModel)
        {
            this.oViewModel = poViewModel;
        } //End public Productnew_Validation()
        //Constructor 2
        public Productnew_Validation(ProductnewVM poViewModel, Barcode_13chars poBarCode)
        {
            this.oViewModel = poViewModel;
            this.oBarCode = poBarCode;
        } //End public Productnew_Validation()
        public void Validate_Create()
        {
            //this.Validate_ID();
            this.Validate_PRODNEW_CODE();
        } //End public void Validate_Create()
        public void Validate_barcode()
        {
            this.Validate_COUNTRY_ID();
            this.Validate_VENDOR_ID();
            this.Validate_PRODTYPE_ID();
            this.Validate_PRODSUBTYPE_ID();
            this.Validate_SERIAL_ID();
            this.Validate_FINISHING_ID();
            this.Validate_UKURAN_ID();
        } //End public void Validate_Create()
        public void Validate_Edit()
        {
            //Validate_ID();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            //Validate_ID();
        } //End public void Validate_Delete()
    } //End public partial class Productnew_Validation
} //End namespace APPBASE.Models
