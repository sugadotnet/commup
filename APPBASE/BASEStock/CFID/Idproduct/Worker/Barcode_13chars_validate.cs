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
using System.Text.RegularExpressions;

namespace APPBASE.Models
{
    public partial class Barcode_13chars : IDisposable
    {
        protected Boolean validateNull() {
            if (this.BARCODE.SEGMENT01 == null) return false;
            if (this.BARCODE.SEGMENT02 == null) return false;
            if (this.BARCODE.SEGMENT03 == null) return false;
            if (this.BARCODE.SEGMENT04 == null) return false;
            if (this.BARCODE.SEGMENT05 == null) return false;
            if (this.BARCODE.SEGMENT06 == null) return false;
            if (this.BARCODE.SEGMENT07 == null) return false;

            if (this.BARCODE.SEGMENT01 == "") return false;
            if (this.BARCODE.SEGMENT02 == "") return false;
            if (this.BARCODE.SEGMENT03 == "") return false;
            if (this.BARCODE.SEGMENT04 == "") return false;
            if (this.BARCODE.SEGMENT05 == "") return false;
            if (this.BARCODE.SEGMENT06 == "") return false;
            if (this.BARCODE.SEGMENT07 == "") return false;
            return true;
        } //end method
        protected Boolean validateLength()
        {
            if (this.BARCODE.SEGMENT01.Length < 3) return false;
            if (this.BARCODE.SEGMENT02.Length != 1) return false;
            if (this.BARCODE.SEGMENT03.Length != 1) return false;
            if (this.BARCODE.SEGMENT04.Length != 2) return false;
            if (this.BARCODE.SEGMENT05.Length != 2) return false;
            if (this.BARCODE.SEGMENT06.Length != 2) return false;
            if (this.BARCODE.SEGMENT07.Length != 1) return false;
            return true;
        } //end method
        protected Boolean validateNumericChar()
        {
            string sCompare = "^[0-9]+$";
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT01)) return false;
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT02)) return false;
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT03)) return false;
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT04)) return false;
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT05)) return false;
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT06)) return false;
            if (!(new Regex(sCompare)).IsMatch(this.BARCODE.SEGMENT07)) return false;

            return true;
        } //end method
        protected Boolean validateSegment()
        {
            if (this.validateNull() == false) return false;
            if (this.validateLength() == false) return false;
            if (this.validateNumericChar() == false) return false;
            return true;
        } //end method
        protected Boolean validate()
        {
            if (this.validateSegment() == false) return false;
            return true;
        } //end method
    } //End class
} //End namespace
