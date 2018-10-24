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
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcapp;
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public partial class Barcode_13chars: IDisposable
    {
        protected BarcodeVM BARCODE { get; set; }
        //Constructor
        public Barcode_13chars(ProductnewVM poViewModel)
        {
            this.initilize();
            this.generate(poViewModel);
        } //end constructor
        protected void initilize()
        {
            this.BARCODE = new BarcodeVM();
            this.BARCODE.RESULT_STATUS = false;
            this.BARCODE.RESULT_STATUS_MESSAGE = "Failed....";
            this.BARCODE.RESULT_VALUE = "";
        } //end method
        protected BarcodeVM generate(ProductnewVM poViewModel) {
            BarcodeVM vResult = this.BARCODE;

            this.BARCODE.SEGMENT01 = poViewModel.COUNTRY_CODE;
            this.BARCODE.SEGMENT02 = poViewModel.VENDOR_CODE;
            this.BARCODE.SEGMENT03 = poViewModel.PRODTYPE_CODE;
            this.BARCODE.SEGMENT04 = poViewModel.PRODSUBTYPE_CODE;
            this.BARCODE.SEGMENT05 = poViewModel.SERIAL_CODE;
            this.BARCODE.SEGMENT06 = poViewModel.FINISHING_CODE;
            this.BARCODE.SEGMENT07 = poViewModel.UKURAN_CODE;
            if (validateSegment() == true) this.BARCODE.SEGMENT08 = this.getChecksum();
            if (this.validate() == true) this.BARCODE.RESULT_VALUE =
                  this.BARCODE.SEGMENT01 + this.BARCODE.SEGMENT02 +
                  this.BARCODE.SEGMENT03 + this.BARCODE.SEGMENT04 +
                  this.BARCODE.SEGMENT05 + this.BARCODE.SEGMENT06 +
                  this.BARCODE.SEGMENT07 + this.BARCODE.SEGMENT08;

            vResult = this.BARCODE;
            return vResult;
        } //end method
        
        public string getResult() {
            return this.BARCODE.RESULT_VALUE;
        } //end method
        public Boolean isSuccess()
        {
            return this.BARCODE.RESULT_STATUS;
        } //end method
        public string gerStatusMessage()
        {
            return this.BARCODE.RESULT_STATUS_MESSAGE;
        } //end method

        public void Dispose() { }
    } //End class
} //End namespace
