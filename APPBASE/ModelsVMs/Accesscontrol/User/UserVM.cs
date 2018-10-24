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
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class UserlistVM
    {
        public int? ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string ROLE_DISPLAY_NAME { get; set; }
        public int? USER_STS { get; set; }
    } //End public partial class UserloginVM

    public partial class UserdetailVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? RES_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string EMAIL { get; set; }
        public int? USER_STS { get; set; }
        public string USER_IMG { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? MDLE_ID { get; set; }
        public string ROLE_CD { get; set; }
        public string ROLE_DISPLAY_NAME { get; set; }

        public string PASSWORD_OLD { get; set; }
        public string PASSWORD_NEW1 { get; set; }
        public string PASSWORD_NEW2 { get; set; }

        public string PREV_URL { get; set; }
    } //End public partial class UserdetailVM
    public partial class UserdetailHQVM {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? RES_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string EMAIL { get; set; }
        public int? USER_STS { get; set; }
        public string USER_IMG { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? MDLE_ID { get; set; }
        public string ROLE_CD { get; set; }
        public string ROLE_DISPLAY_NAME { get; set; }
        public Byte? BRANCH_TYPE { get; set; }
        public string BRANCH_DESC { get; set; }
        public string RES_NAME { get; set; }
        public string RES_NIP { get; set; }
        public Byte? RES_JOBTITLE_ID { get; set; }
        public string JOBTITLE_CODE { get; set; }
        public string JOBTITLE_DESC { get; set; }
    } //End public partial class UserdetailHQVM
    public partial class UserdetailBRANCHVM {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? RES_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string EMAIL { get; set; }
        public int? USER_STS { get; set; }
        public string USER_IMG { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? MDLE_ID { get; set; }
        public string ROLE_CD { get; set; }
        public string ROLE_DISPLAY_NAME { get; set; }
        public Byte? BRANCH_TYPE { get; set; }
        public string BRANCH_DESC { get; set; }
        public string RES_NAME { get; set; }
        public string RES_NIP { get; set; }
        public Byte? RES_JOBTITLE_ID { get; set; }
        public string JOBTITLE_CODE { get; set; }
        public string JOBTITLE_DESC { get; set; }
    } //End public partial class UserdetailBRANCHVM
    public partial class UserdetailPARENTVM {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public int? RES_ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string EMAIL { get; set; }
        public int? USER_STS { get; set; }
        public string USER_IMG { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? MDLE_ID { get; set; }
        public string ROLE_CD { get; set; }
        public string ROLE_DISPLAY_NAME { get; set; }
        public string RES_NAME { get; set; }
        public string RES_NIS { get; set; }
        public int? RES_YEAR_ID { get; set; }
        public Byte? RES_SEMESTER_ID { get; set; }
        public Byte? RES_CLASSTYPE_ID { get; set; }
        public string RES_YEAR_DESC { get; set; }
        public string RES_SEMESTER_DESC { get; set; }
        public string RES_CLASSTYPE_DESC { get; set; }
    } //End public partial class UserdetailPARENTVM


    public partial class UsercreateVM
    {
        public int? ID { get; set; }
        public int? RES_ID { get; set; }
        public string RES_CD { get; set; }

        public int? ROLE_ID { get; set; }
        public string ROLE_DISPNAME { get; set; }

        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string EMAIL { get; set; }
    } //End public partial class UsercreateVM
    public partial class UserloginVM
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PASSWORD_NEW1 { get; set; }
        public string PASSWORD_NEW2 { get; set; }
    } //End public partial class UserloginVM
    public partial class UsercredentialVM
    {
        public int? RES_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string DISPLAY_NAME { get; set; }
        public int? ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string USER_IMG { get; set; }
    } //End public partial class UsercredentialVM


    public partial class UseremployeelookupVM
    {
        public int? ID { get; set; }
        public int? ROLE_ID { get; set; }
        public string DISPLAY_NAME { get; set; }
        public string ROLE_DISPLAY_NAME { get; set; }
        public int? USER_STS { get; set; }
        public string RES_NAME { get; set; }
        public string RES_NIP { get; set; }
        public string JOBTITLE_DESC { get; set; }
    } //End public partial class UserlookupVM

} //End namespace APPBASE.Models

