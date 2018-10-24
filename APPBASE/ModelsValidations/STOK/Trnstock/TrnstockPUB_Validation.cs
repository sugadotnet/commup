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
    public partial class Trnstock_Validation
    {
        private TrnstockVM oViewModel;
        private ProductstockVM oViewModel_productstock;
        private List<ProductstockVM> oViewModel_productstock_list;
        private TrnstockDS oDS = new TrnstockDS();
        public List<ValidationMSG_VM> aValidationMSG = new List<ValidationMSG_VM>();

        //Constructor 1
        public Trnstock_Validation(TrnstockVM poViewModel)
        {
            oViewModel = poViewModel;
        } //End public Trnstock_Validation()
        //Constructor 2
        public Trnstock_Validation(ProductstockVM poViewModel)
        {
            oViewModel_productstock = poViewModel;
        } //End public Trnstock_Validation()
        //Constructor 2
        public Trnstock_Validation(TrnstockVM poViewModel, List<ProductstockVM> poViewModel_productstock_list)
        {
            oViewModel = poViewModel;
            oViewModel_productstock_list = poViewModel_productstock_list;
        } //End public Trnstock_Validation()
        public void Validate_Index()
        {
            Validate_SelectedProduct();
        } //End public void Validate_Create()
        public void Validate_Create()
        {
            //Validate_ID();
            this.Validate_TRN_DT();
            this.Validate_TRN_CODE();
            this.Validate_TRN_RECIPIENT();
            this.Validate_items();
        } //End public void Validate_Create()
        public void Validate_Create_csr()
        {
            //Validate_ID();
            this.Validate_TRN_DT();
            this.Validate_TRN_CODE();
            this.Validate_TRN_RECIPIENT();
            this.Validate_items_csr();
        } //End public void Validate_Create()
        public void Validate_Create_revadd()
        {
            //Validate_ID();
            this.Validate_TRN_DT();
            this.Validate_TRN_CODE();
            this.Validate_TRN_RECIPIENT();
            this.Validate_items_revadd();
        } //End public void Validate_Create()
        public void Validate_Create_revsub()
        {
            //Validate_ID();
            this.Validate_TRN_DT();
            this.Validate_TRN_CODE();
            this.Validate_TRN_RECIPIENT();
            this.Validate_items_revsub();
        } //End public void Validate_Create()
        public void Validate_Edit()
        {
            //Validate_ID();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            //Validate_ID();
        } //End public void Validate_Delete()
    } //End public partial class Trnstock_Validation
} //End namespace APPBASE.Models
