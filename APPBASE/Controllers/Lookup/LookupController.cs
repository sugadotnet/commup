using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Filters;
using APPBASE.Svcbiz;

namespace APPBASE.Controllers
{
    public partial class LookupController : Controller
    {
        BranchallDS oDSBranchall = new BranchallDS();
        public ActionResult ShowBranch(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSBranchall.getDatalist_lookup());
        } //End public ActionResult ShowBranch

        GenderDS oDSGender = new GenderDS();
        public ActionResult ShowGender(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSGender.getDatalist_lookup());
        } //End public ActionResult ShowGender
        ReligionDS oDSReligion = new ReligionDS();
        public ActionResult ShowReligion(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSReligion.getDatalist_lookup());
        } //End public ActionResult ShowReligion
        BloodtypeDS oDSBloodtype = new BloodtypeDS();
        public ActionResult ShowBloodtype(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSBloodtype.getDatalist_lookup());
        } //End public ActionResult ShowBloodtype

        EducationDS oDSEducation = new EducationDS();
        public ActionResult ShowEducation(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSEducation.getDatalist_lookup());
        } //End public ActionResult ShowEducation
        JobtypeDS oDSJobtype = new JobtypeDS();
        public ActionResult ShowJobtype(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSJobtype.getDatalist_lookup());
        } //End public ActionResult ShowJobtype
        MaritalDS oDSMarital = new MaritalDS();
        public ActionResult ShowMarital(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSMarital.getDatalist_lookup());
        } //End public ActionResult ShowMarital

        JobtitleDS oDSJobtitle = new JobtitleDS();
        public ActionResult ShowJobtitle(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSJobtitle.getDatalist_lookup());
        } //End public ActionResult ShowJobtitle
        EmplstsDS oDSEmplsts = new EmplstsDS();
        public ActionResult ShowEmplsts(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSEmplsts.getDatalist_lookup());
        } //End public ActionResult ShowEmplsts


        EmployeeDS oDSEmployee = new EmployeeDS();
        public ActionResult ShowEmployee(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            ViewBag.OTHER_TAG = paTargetTag[3];
            return View(oDSEmployee.getDatalist_lookup());
        } //End public ActionResult ShowEmployee
    } //End public class LookupController : Controller
} //End namespace APPBASE.Controllers
