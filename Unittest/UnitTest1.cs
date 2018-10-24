using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APPBASE.Models;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        protected ProductnewVM oViewModel;
        protected string sResult;

        protected void initialize() {
            this.oViewModel = new ProductnewVM();
            oViewModel.COUNTRY_CODE = "899";
            oViewModel.VENDOR_CODE = "3";
            oViewModel.PRODTYPE_CODE = "1";
            oViewModel.PRODSUBTYPE_CODE = "01";
            oViewModel.SERIAL_CODE = "05";
            oViewModel.FINISHING_CODE = "01";
            oViewModel.UKURAN_CODE = "0";
            this.sResult = (new Barcode_13chars(oViewModel)).getResult();
        } //end init

        [TestMethod]
        public void testBarcode_notNull()
        {
            this.initialize();
            Assert.AreNotEqual(this.sResult, "");
        } //end method
        [TestMethod]
        public void testBarcode_ValidValue()
        {
            this.initialize();
            Assert.AreEqual(this.sResult, "8993101050109");
        } //end method
    } //end class
} //end namspace
