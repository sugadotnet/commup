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

namespace APPBASE.Models
{
    public class CRUD
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ID { get; set; }

        //Constructor 1
        public CRUD()
        {
        } //End public Cutibesar()
        public void setFIELD_HEADER(int? pnCRUD_Option)
        {
            if (hlpConfig.SessionInfo.getAppUsername().ToUpper() != valDFLT.SYSADMIN_USER) { UPDATEBY = hlpConfig.SessionInfo.getAppUserId(); }
            UPDATEDT = hlpGeneral.ClientSystemInfo.getAppDateTime();
            if (pnCRUD_Option == hlpFlags_CRUDOption.CREATE)
            {
                ID = 0; //HACK: (Akal2an untuk mancing autoincremental field)
                if (hlpConfig.SessionInfo.getAppUsername().ToUpper() != valDFLT.SYSADMIN_USER) { CREATEBY = hlpConfig.SessionInfo.getAppUserId(); }
                CREATEDT = hlpGeneral.ClientSystemInfo.getAppDateTime();
            } //End if
        } //End public void setFIELD_HEADER(string psCRUD_Option)
        public int? setDTA_STS(int? pnCRUD_Option)
        {
            return pnCRUD_Option;
        } //End public void setFIELD_HEADER(string psCRUD_Option)
    } //End public class CRUD
} //End namespace APPBASE.Models

