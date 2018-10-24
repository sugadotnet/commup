using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_kasirBL : MutasiBL
    {
        protected override Boolean setSTOCKS() {
            base.setSTOCKS();
            //this.__PRODUCTSTOCKS_NEW.RemoveAll(fld => fld.STORAGE_ID == null);

            for (int i = 0; i < this.__PRODUCTSTOCKS_NEW.Count; i++)
            {
                this.__PRODUCTSTOCKS_NEW[i].STORAGE_ID = 4; //Kasir
            } //End for
   
            //Return
            return true;
        } //End Method
        
    } //End Method
} //End namespace APPBASE.Models
