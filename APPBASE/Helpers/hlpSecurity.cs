using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Net;
using System.Web.Mvc;
using System.Web.Routing;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcapp;
using APPBASE.Svcutil;

namespace APPBASE.Helpers
{
    public class hlpCredentialInfo
    {
        //public static Boolean
        public static void isValidCredential(ActionExecutedContext context)
        {
            //Validate Is User logged in
            if ((hlpConfig.SessionInfo.getAppUsername() == "") ||
                (hlpConfig.SessionInfo.getAppUsername() == null))
            {

                context.Result = new RedirectToRouteResult(new RouteValueDictionary 
                { 
                    { "controller", "Account" }, 
                    { "action", "Login" }
                });
            } //End if ((hlpConfig.SessionInfo.getAppUsername() == "") ||


            //Validate user access control
            if ((context.Controller.ViewBag.AC_MENU_ID != null)&&
                (hlpConfig.SessionInfo.getAppUsername() != ""))
            {
                Boolean isValid = isGranted_menu(hlpConfig.SessionInfo.getAppUsername(), hlpConfig.SessionInfo.getAppRoleId(), context.Controller.ViewBag.AC_MENU_ID);
                if (!isValid)
                {

                    context.Result = new RedirectToRouteResult(new RouteValueDictionary 
                    { 
                        { "controller", "Error" }, 
                        { "action", "Error403" } 
                    });
                } //End if (!isValid)
            } //End if (sAC_MENU_RUID != null)

        } //End public static string isValidCredential
        public static Boolean isValidDBLogin(string psUsername, string psPassword, int? pnMdleId)
        {
            UserloginVM oVM = new UserloginVM(); ;


            //if Ultimate User
            if ((psUsername.ToUpper() == valDFLT.SYSADMIN_USER) && (psPassword == valDFLT.SYSADMIN_PASSWORD)) {
                setValidCredential(psUsername, valDFLT.SYSADMIN_USER, null, null, hlpConfig.ConstantaInfo.MDLE_ID);
                return true;
            } //End if ((psUsername.ToUpper() == "SYSADMIN") && (psPassword == "kuy4bulu5"))
            
            //if selain Ultimate User
            UserDS oDS = new UserDS();
            var oQRY = oDS.getData_Usercredential(psUsername);
            if (oQRY != null) {
                string stes = hlpObf.randomDecrypt(oQRY.PASSWORD);
                if ((psUsername.ToUpper() == oQRY.USERNAME.ToUpper()) &&
                    (psPassword == hlpObf.randomDecrypt(oQRY.PASSWORD)))
                {
                    //setValidCredential(psUsername, oQRY.DISPLAY_NAME, oQRY.ID, oQRY.ROLE_ID, hlpConfig.ConstantaInfo.MDLE_ID);
                    setValidCredential(psUsername, oQRY, hlpConfig.ConstantaInfo.MDLE_ID);
                    return true;
                } //End if ((psUsername.ToUpper() == oQRY.USERNAME) &&
            } //End if (oQRY != null)
            return false;
        } //End public static Boolean isValidDBLogin

        public static void setValidCredential(string psUsername = null, string psUserdisplayname = null, int? pnUserId = null, int? pnRoleId = null, int? pnMdleId = null)
        {
            hlpConfig.SessionInfo.setAppUsername(psUsername);
            hlpConfig.SessionInfo.setAppUserdisplayname(psUserdisplayname);
            hlpConfig.SessionInfo.setAppUserId(pnUserId);
            hlpConfig.SessionInfo.setAppRoleId(pnRoleId);
            hlpConfig.SessionInfo.setAppMdleId(pnMdleId);
        } //End public static void setValidCredential()
        public static void setValidCredential(string psUsername = null, UsercredentialVM poViewmodel = null, int? pnMdleId = null)
        {
            hlpConfig.SessionInfo.setAppUsername(psUsername);
            hlpConfig.SessionInfo.setAppUserdisplayname(poViewmodel.DISPLAY_NAME);
            hlpConfig.SessionInfo.setAppUserId(poViewmodel.ID);
            hlpConfig.SessionInfo.setAppRoleId(poViewmodel.ROLE_ID);
            hlpConfig.SessionInfo.setAppResId(poViewmodel.RES_ID);
            hlpConfig.SessionInfo.setAppMdleId(pnMdleId);
            hlpConfig.SessionInfo.setAppUserIMG(poViewmodel.USER_IMG);


            string sTempinfo1 = "";
            string sTempinfo2 = "";
            string sTempinfo3 = "";
            string sTempinfo4 = "";
            string sIMG = Utility_FileUploadDownload.getImage_UserNA();

            EmployeeDS oDSEmployee = new EmployeeDS();
            var oData = oDSEmployee.getData_shortinfo(poViewmodel.RES_ID);
            if (oData != null)
            {
                if (oData.EMPLOYEE_IMG != null) { sIMG = Utility_FileUploadDownload.getImage_Employee(oData.EMPLOYEE_IMG); }
                sTempinfo1 = "";
                if (oData.BRANCH_DESC != null) { sTempinfo1 = oData.BRANCH_DESC; }
                sTempinfo3 = "";
                if (oData.JOBTITLE_DESC != null) { sTempinfo3 = oData.JOBTITLE_DESC; }
            } //End if (oData != null)

            hlpConfig.SessionInfo.setAppResIMG(sIMG);
            hlpConfig.SessionInfo.setAppResinfo1(sTempinfo1);
            hlpConfig.SessionInfo.setAppResinfo2(sTempinfo2);
            hlpConfig.SessionInfo.setAppResinfo3(sTempinfo3);
            hlpConfig.SessionInfo.setAppResinfo4(sTempinfo4);

        } //End public static void setValidCredential()
        public static Boolean isGranted_menu(string psUsername, int? pnRoleId = null, int? pnMenuId = null)
        {
            if (psUsername.ToUpper() == valDFLT.SYSADMIN_USER) return true;
            //UserDS oDS = new UserDS();
            RolemenuDS oDS = new RolemenuDS();
            return oDS.isGranted_menu(pnRoleId, pnMenuId);
        } //End public static Boolean isValidMenu(string psAC_MENU_RUID)
    
    } //End public class CredentialInfo
} //End namespace APPBASE.Helper
