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
    public partial class Barcode_13chars : IDisposable
    {
        protected string getChecksum() {
            return getChecksum_8segments();
        } //end method

        protected string getChecksum_8segments()
        {
            string vResult = "";
            int nChecksum = 0;
            int nCounterAB = 0;
            int nCounterAB_roundup = 0;

            //Counter A
            int nCounterA = 0;
            List<int> nCounterA_list = new List<int>();
            //1
            nCounterA_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT01.Substring(0,1)));
            //2
            nCounterA_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT01.Substring(this.BARCODE.SEGMENT01.Length - 2, 1)));
            //3
            nCounterA_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT03));
            //4
            nCounterA_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT04.Substring(this.BARCODE.SEGMENT04.Length - 1, 1)));
            //5
            nCounterA_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT05.Substring(this.BARCODE.SEGMENT05.Length - 1, 1)));
            //6
            nCounterA_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT06.Substring(this.BARCODE.SEGMENT06.Length - 1, 1)));
            foreach (var item in nCounterA_list)
            {
                nCounterA = nCounterA + item;
            } //end loop

            //Counter B
            int nCounterB = 0;
            List<int> nCounterB_list = new List<int>();
            //1
            nCounterB_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT01.Substring(1,1)));
            //2
            nCounterB_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT02));
            //3
            nCounterB_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT04.Substring(0, 1)));
            //4
            nCounterB_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT05.Substring(0, 1)));
            //5
            nCounterB_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT06.Substring(0, 1)));
            //6
            nCounterB_list.Add(Convert.ToInt32(this.BARCODE.SEGMENT07));
            foreach (var item in nCounterB_list)
            {
                nCounterB = nCounterB + item;
            } //end loop
            nCounterB = nCounterB * 3;

            nCounterAB = nCounterA + nCounterB;
            nCounterAB_roundup = (nCounterAB) + ((10) - (nCounterAB % 10));
            nChecksum = nCounterAB_roundup - nCounterAB;

            vResult = nChecksum.ToString();
            return vResult;
        } //end method
    } //End class
} //End namespace
