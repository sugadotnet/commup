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
    [Table("VWMST01EMPLOYEE_INFO")]
    public partial class Employee_info
    {
        public int? CREATEBY { get; set; }
        public int? UPDATEBY { get; set; }
        public DateTime? CREATEDT { get; set; }
        public DateTime? UPDATEDT { get; set; }
        [Key]
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public string NIP { get; set; }
        public string KTP { get; set; }
        public string NPWP { get; set; }
        public string PINREG { get; set; }
        public string NAME { get; set; }
        public string NICKNAME { get; set; }
        public int? SEX_ID { get; set; }
        public string POB { get; set; }
        public DateTime? DOB { get; set; }
        public Byte? RELIGION_ID { get; set; }
        public Byte? NATIONALITY_ID { get; set; }
        public string LANGUAGE { get; set; }
        public string ETHNIC { get; set; }
        public Byte? MARITAL_ID { get; set; }
        public Byte? ADDR_COUNTRY_ID { get; set; }
        public string ADDR_CITY { get; set; }
        public string ADDR_KEC { get; set; }
        public string ADDR_KEL { get; set; }
        public string ADDR_ZIP { get; set; }
        public string ADDR_STREET1 { get; set; }
        public string ADDR_STREET2 { get; set; }
        public string HOME_PHONE { get; set; }
        public string CELL_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string FACEBOOK { get; set; }
        public string TWITTER { get; set; }
        public Byte? BLOOD_TYPE_ID { get; set; }
        public Byte? WEIGHT_KG { get; set; }
        public Byte? HEIGHT_CM { get; set; }
        public string MEDICAL_STORY1 { get; set; }
        public string MEDICAL_STORY2 { get; set; }
        public DateTime? JOIN_DT { get; set; }
        public Byte? EMPLSTS_ID { get; set; }
        public Byte? JOBTITLE_ID { get; set; }
        public Byte? EDU_ID { get; set; }
        public string EMPLHIST_COMPANY1 { get; set; }
        public string EMPLHIST_ADDR11 { get; set; }
        public string EMPLHIST_ADDR21 { get; set; }
        public string EMPLHIST_JOBTITLE1 { get; set; }
        public DateTime? EMPLHIST_FROMDT1 { get; set; }
        public DateTime? EMPLHIST_TODT1 { get; set; }
        public string EMPLHIST_JOBDESC1 { get; set; }
        public string EMPLHIST_COMPANY2 { get; set; }
        public string EMPLHIST_ADDR12 { get; set; }
        public string EMPLHIST_ADDR22 { get; set; }
        public string EMPLHIST_JOBTITLE2 { get; set; }
        public DateTime? EMPLHIST_FROMDT2 { get; set; }
        public DateTime? EMPLHIST_TODT2 { get; set; }
        public string EMPLHIST_JOBDESC2 { get; set; }
        public string EMPLHIST_COMPANY3 { get; set; }
        public string EMPLHIST_ADDR13 { get; set; }
        public string EMPLHIST_ADDR23 { get; set; }
        public string EMPLHIST_JOBTITLE3 { get; set; }
        public DateTime? EMPLHIST_FROMDT3 { get; set; }
        public DateTime? EMPLHIST_TODT3 { get; set; }
        public string EMPLHIST_JOBDESC3 { get; set; }
        public string EMPLHIST_COMPANY4 { get; set; }
        public string EMPLHIST_ADDR14 { get; set; }
        public string EMPLHIST_ADDR24 { get; set; }
        public string EMPLHIST_JOBTITLE4 { get; set; }
        public DateTime? EMPLHIST_FROMDT4 { get; set; }
        public DateTime? EMPLHIST_TODT4 { get; set; }
        public string EMPLHIST_JOBDESC4 { get; set; }
        public string EMPLHIST_COMPANY5 { get; set; }
        public string EMPLHIST_ADDR15 { get; set; }
        public string EMPLHIST_ADDR25 { get; set; }
        public string EMPLHIST_JOBTITLE5 { get; set; }
        public DateTime? EMPLHIST_FROMDT5 { get; set; }
        public DateTime? EMPLHIST_TODT5 { get; set; }
        public string EMPLHIST_JOBDESC5 { get; set; }
        public int? BRANCH_ID { get; set; }
        public int? MUTATIONSTS_ID { get; set; }
        public string EMPLOYEE_IMG { get; set; }
        public string SEX_CODE { get; set; }
        public string SEX_DESC { get; set; }
        public string RELIGION_CODE { get; set; }
        public string RELIGION_DESC { get; set; }
        public string MARITAL_CODE { get; set; }
        public string MARITAL_DESC { get; set; }
        public string BLOOD_TYPE_CODE { get; set; }
        public string BLOOD_TYPE_DESC { get; set; }
        public string EMPLSTS_CODE { get; set; }
        public string EMPLSTS_DESC { get; set; }
        public string JOBTITLE_CODE { get; set; }
        public string JOBTITLE_DESC { get; set; }
        public string EDU_CODE { get; set; }
        public string EDU_DESC { get; set; }
        public Byte? BRANCH_TYPE { get; set; }
        public string BRANCH_DESC { get; set; }
        public string MUTATIONSTS_CODE { get; set; }
        public string MUTATIONSTS_DESC { get; set; }
    } //End public partial class Employee_info
} //End namespace APPBASE.Models

