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
    [MyActionFilterAttribute]
    public partial class LookupController : Controller
    {
        private DBMAINContext db = new DBMAINContext();
        RoleDS oDSRole = new RoleDS();
        public ActionResult ShowRoleHQ(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSRole.getDatalistHQ_lookup());
        } //End public ActionResult ShowRoleHQ
        public ActionResult ShowRoleBRANCH(List<string> paSearchValue, List<string> paTargetTag)
        {
            //TODO: Buat Access Control untuk lookup tertentu/Pilih Akses kontrol yang pas dari menu
            //hlpSecurity.CredentialInfo.isValidAccessMenu(MNURUID_CCS_INPUT_PJX_REG);

            //Tag to Target
            ViewBag.ID_TAG = paTargetTag[0];
            ViewBag.CODE_TAG = paTargetTag[1];
            ViewBag.DESC_TAG = paTargetTag[2];
            return View(oDSRole.getDatalistBRANCH_lookup());
        } //End public ActionResult ShowRoleBRANCH
    } //End public class LookupController : Controller
} //End namespace APPBASE.Controllers
