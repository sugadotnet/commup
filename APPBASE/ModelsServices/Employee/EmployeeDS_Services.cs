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
    public class EmployeeDS
    {
        //Constructor
        public EmployeeDS() { } //End public EmployeeDS
        public List<EmployeelistVM> getDatalist()
        {
            List<EmployeelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Employee_infos
                           select new EmployeelistVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               NIP = tb.NIP,
                               NAME = tb.NAME,
                               JOBTITLE_ID = tb.JOBTITLE_ID,
                               JOBTITLE_DESC = tb.JOBTITLE_DESC,
                               EMPLOYEE_IMG = tb.EMPLOYEE_IMG
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EmployeelistVM> getDatalist()
        public EmployeedetailVM getData(int? id = null)
        {
            EmployeedetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Employee_infos
                           where tb.ID == id
                           select new EmployeedetailVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               NIP = tb.NIP,
                               KTP = tb.KTP,
                               NPWP = tb.NPWP,
                               PINREG = tb.PINREG,
                               NAME = tb.NAME,
                               NICKNAME = tb.NICKNAME,
                               SEX_ID = tb.SEX_ID,
                               POB = tb.POB,
                               DOB = tb.DOB,
                               RELIGION_ID = tb.RELIGION_ID,
                               NATIONALITY_ID = tb.NATIONALITY_ID,
                               LANGUAGE = tb.LANGUAGE,
                               ETHNIC = tb.ETHNIC,
                               MARITAL_ID = tb.MARITAL_ID,
                               ADDR_COUNTRY_ID = tb.ADDR_COUNTRY_ID,
                               ADDR_CITY = tb.ADDR_CITY,
                               ADDR_KEC = tb.ADDR_KEC,
                               ADDR_KEL = tb.ADDR_KEL,
                               ADDR_ZIP = tb.ADDR_ZIP,
                               ADDR_STREET1 = tb.ADDR_STREET1,
                               ADDR_STREET2 = tb.ADDR_STREET2,
                               HOME_PHONE = tb.HOME_PHONE,
                               CELL_PHONE = tb.CELL_PHONE,
                               EMAIL = tb.EMAIL,
                               FACEBOOK = tb.FACEBOOK,
                               TWITTER = tb.TWITTER,
                               BLOOD_TYPE_ID = tb.BLOOD_TYPE_ID,
                               WEIGHT_KG = tb.WEIGHT_KG,
                               HEIGHT_CM = tb.HEIGHT_CM,
                               MEDICAL_STORY1 = tb.MEDICAL_STORY1,
                               MEDICAL_STORY2 = tb.MEDICAL_STORY2,
                               JOIN_DT = tb.JOIN_DT,
                               EMPLSTS_ID = tb.EMPLSTS_ID,
                               JOBTITLE_ID = tb.JOBTITLE_ID,
                               EDU_ID = tb.EDU_ID,
                               EMPLHIST_COMPANY1 = tb.EMPLHIST_COMPANY1,
                               EMPLHIST_ADDR11 = tb.EMPLHIST_ADDR11,
                               EMPLHIST_ADDR21 = tb.EMPLHIST_ADDR21,
                               EMPLHIST_JOBTITLE1 = tb.EMPLHIST_JOBTITLE1,
                               EMPLHIST_FROMDT1 = tb.EMPLHIST_FROMDT1,
                               EMPLHIST_TODT1 = tb.EMPLHIST_TODT1,
                               EMPLHIST_JOBDESC1 = tb.EMPLHIST_JOBDESC1,
                               EMPLHIST_COMPANY2 = tb.EMPLHIST_COMPANY2,
                               EMPLHIST_ADDR12 = tb.EMPLHIST_ADDR12,
                               EMPLHIST_ADDR22 = tb.EMPLHIST_ADDR22,
                               EMPLHIST_JOBTITLE2 = tb.EMPLHIST_JOBTITLE2,
                               EMPLHIST_FROMDT2 = tb.EMPLHIST_FROMDT2,
                               EMPLHIST_TODT2 = tb.EMPLHIST_TODT2,
                               EMPLHIST_JOBDESC2 = tb.EMPLHIST_JOBDESC2,
                               EMPLHIST_COMPANY3 = tb.EMPLHIST_COMPANY3,
                               EMPLHIST_ADDR13 = tb.EMPLHIST_ADDR13,
                               EMPLHIST_ADDR23 = tb.EMPLHIST_ADDR23,
                               EMPLHIST_JOBTITLE3 = tb.EMPLHIST_JOBTITLE3,
                               EMPLHIST_FROMDT3 = tb.EMPLHIST_FROMDT3,
                               EMPLHIST_TODT3 = tb.EMPLHIST_TODT3,
                               EMPLHIST_JOBDESC3 = tb.EMPLHIST_JOBDESC3,
                               EMPLHIST_COMPANY4 = tb.EMPLHIST_COMPANY4,
                               EMPLHIST_ADDR14 = tb.EMPLHIST_ADDR14,
                               EMPLHIST_ADDR24 = tb.EMPLHIST_ADDR24,
                               EMPLHIST_JOBTITLE4 = tb.EMPLHIST_JOBTITLE4,
                               EMPLHIST_FROMDT4 = tb.EMPLHIST_FROMDT4,
                               EMPLHIST_TODT4 = tb.EMPLHIST_TODT4,
                               EMPLHIST_JOBDESC4 = tb.EMPLHIST_JOBDESC4,
                               EMPLHIST_COMPANY5 = tb.EMPLHIST_COMPANY5,
                               EMPLHIST_ADDR15 = tb.EMPLHIST_ADDR15,
                               EMPLHIST_ADDR25 = tb.EMPLHIST_ADDR25,
                               EMPLHIST_JOBTITLE5 = tb.EMPLHIST_JOBTITLE5,
                               EMPLHIST_FROMDT5 = tb.EMPLHIST_FROMDT5,
                               EMPLHIST_TODT5 = tb.EMPLHIST_TODT5,
                               EMPLHIST_JOBDESC5 = tb.EMPLHIST_JOBDESC5,
                               BRANCH_ID = tb.BRANCH_ID,
                               MUTATIONSTS_ID = tb.MUTATIONSTS_ID,
                               EMPLOYEE_IMG = tb.EMPLOYEE_IMG,
                               SEX_CODE = tb.SEX_CODE,
                               SEX_DESC = tb.SEX_DESC,
                               RELIGION_CODE = tb.RELIGION_CODE,
                               RELIGION_DESC = tb.RELIGION_DESC,
                               MARITAL_CODE = tb.MARITAL_CODE,
                               MARITAL_DESC = tb.MARITAL_DESC,
                               BLOOD_TYPE_CODE = tb.BLOOD_TYPE_CODE,
                               BLOOD_TYPE_DESC = tb.BLOOD_TYPE_DESC,
                               EMPLSTS_CODE = tb.EMPLSTS_CODE,
                               EMPLSTS_DESC = tb.EMPLSTS_DESC,
                               JOBTITLE_CODE = tb.JOBTITLE_CODE,
                               JOBTITLE_DESC = tb.JOBTITLE_DESC,
                               EDU_CODE = tb.EDU_CODE,
                               EDU_DESC = tb.EDU_DESC,
                               BRANCH_TYPE = tb.BRANCH_TYPE,
                               BRANCH_DESC = tb.BRANCH_DESC,
                               MUTATIONSTS_CODE = tb.MUTATIONSTS_CODE,
                               MUTATIONSTS_DESC = tb.MUTATIONSTS_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public EmployeedetailVM getData(int? id = null)
        public EmployeedetailVM getData_shortinfo(int? id = null)
        {
            EmployeedetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Employee_infos
                           where tb.ID == id
                           select new EmployeedetailVM
                           {
                               ID = tb.ID,
                               EMPLOYEE_IMG = tb.EMPLOYEE_IMG,
                               JOBTITLE_DESC = tb.JOBTITLE_DESC,
                               BRANCH_DESC = tb.BRANCH_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public EmployeedetailVM getData(int? id = null)


        public List<EmployeelookupVM> getDatalist_lookup()
        {
            List<EmployeelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Employee_infos
                           select new EmployeelookupVM
                           {
                               ID = tb.ID,
                               NIP = tb.NIP,
                               NAME = tb.NAME,
                               JOBTITLE_DESC = tb.JOBTITLE_DESC,
                               EMPLOYEE_IMG = tb.EMPLOYEE_IMG
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<EmployeelookupVM> getDatalist_lookup()
    } //End public class EmployeeDS
} //End namespace APPBASE.Models

