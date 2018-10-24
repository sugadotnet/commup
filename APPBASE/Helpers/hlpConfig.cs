using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data;
using System.Data.Entity;
using APPBASE.Helpers;

namespace APPBASE.Helpers
{
    public class hlpConfig
    {
        public class SessionInfo {
            public static void setDefSession() {

                //User Login Information
                HttpContext.Current.Session["AppUsername"] = ""; //modif this line for testing = SYSADMIN (God user)
                HttpContext.Current.Session["AppUserdisplayname"] = ""; //modif this line for testing = SYSADMIN (God user)
                HttpContext.Current.Session["AppUserId"] = null; //modif this line for testing = 1/2/3/...
                
                HttpContext.Current.Session["AppRoleId"] = null; //modif this line for testing = 1/2/3/...
                HttpContext.Current.Session["AppMdleId"] = null; //modif this line for testing = 1/2/3/...
                HttpContext.Current.Session["AppResId"] = null; //modif this line for testing = RES_ID

                HttpContext.Current.Session["AppUserIMG"] = null; //modif this line for testing = AppUserIMG
                HttpContext.Current.Session["AppResIMG"] = null; //modif this line for testing = AppResIMG
                HttpContext.Current.Session["AppResinfo1"] = null; //modif this line for testing = AppResinfo1
                HttpContext.Current.Session["AppResinfo2"] = null; //modif this line for testing = AppResinfo2
                HttpContext.Current.Session["AppResinfo3"] = null; //modif this line for testing = AppResinfo3
                HttpContext.Current.Session["AppResinfo4"] = null; //modif this line for testing = AppResinfo4

                HttpContext.Current.Session["AppProgID"] = "";
                HttpContext.Current.Session["AppIsLoggedIn"] = hlpFlagInfo.getFlagNotValid();
                HttpContext.Current.Session["AppDefDateFormatShort"] = ConstantaInfo.FMT_DTSHT;
                HttpContext.Current.Session["AppDefDateFormatLong"] = ConstantaInfo.FMT_DTLONG;
                HttpContext.Current.Session["AppDef1000Separator"] = ConstantaInfo.SGN_1000SEP;
                HttpContext.Current.Session["AppDefDecimalSign"] = ConstantaInfo.SGN_DECSEP;
                HttpContext.Current.Session["AppDefDecimalDigit"] = ConstantaInfo.FMT_DECNUM;
                HttpContext.Current.Session["AppDefCurrencySign"] = ConstantaInfo.SGN_CURR;
                HttpContext.Current.Session["AppDefLanguage"] = ConstantaInfo.LNG_DEFF;
                //Input Mask
                HttpContext.Current.Session["AppDefDateInputMaskShort"] = ConstantaInfo.IMSK_DTSHT;
            } //End public static void setDefSession
            //Set Credential
            public static void setAppUsername(string psValue=null) { HttpContext.Current.Session["AppUsername"] = psValue; }
            public static void setAppUserdisplayname(string psValue = null) { HttpContext.Current.Session["AppUserdisplayname"] = psValue; }
            public static void setAppUserId(int? pnValue = null) { HttpContext.Current.Session["AppUserId"] = pnValue; }
            public static void setAppRoleId(int? pnValue = null) { HttpContext.Current.Session["AppRoleId"] = pnValue; }
            public static void setAppMdleId(int? pnValue = null) { HttpContext.Current.Session["AppMdleId"] = pnValue; }
            public static void setAppResId(int? pnValue = null) { HttpContext.Current.Session["AppResId"] = pnValue; }
            public static void setAppUserIMG(string psValue = null) { HttpContext.Current.Session["AppUserIMG"] = psValue; }
            public static void setAppResIMG(string psValue = null) { HttpContext.Current.Session["AppResIMG"] = psValue; }
            public static void setAppResinfo1(string psValue = null) { HttpContext.Current.Session["AppResinfo1"] = psValue; }
            public static void setAppResinfo2(string psValue = null) { HttpContext.Current.Session["AppResinfo2"] = psValue; }
            public static void setAppResinfo3(string psValue = null) { HttpContext.Current.Session["AppResinfo3"] = psValue; }
            public static void setAppResinfo4(string psValue = null) { HttpContext.Current.Session["AppResinfo4"] = psValue; }

            //Get Credential
            public static string getAppUsername() { return HttpContext.Current.Session["AppUsername"].ToString(); }
            public static string getAppUserdisplayname() { return HttpContext.Current.Session["AppUserdisplayname"].ToString(); }
            public static int? getAppUserId() { return Convert.ToInt32(HttpContext.Current.Session["AppUserId"]); }
            public static int? getAppRoleId() { return Convert.ToInt32(HttpContext.Current.Session["AppRoleId"]); }
            public static int? getAppMdleId() { return Convert.ToInt32(HttpContext.Current.Session["AppMdleId"]); }
            public static int? getAppResId() { return Convert.ToInt32(HttpContext.Current.Session["AppResId"]); }
            public static string getAppUserIMG() { return HttpContext.Current.Session["AppUserIMG"].ToString(); }
            public static string getAppResIMG() { return HttpContext.Current.Session["AppResIMG"].ToString(); }
            public static string getAppResinfo1() { return HttpContext.Current.Session["AppResinfo1"].ToString(); }
            public static string getAppResinfo2() { return HttpContext.Current.Session["AppResinfo2"].ToString(); }
            public static string getAppResinfo3() { return HttpContext.Current.Session["AppResinfo3"].ToString(); }
            public static string getAppResinfo4() { return HttpContext.Current.Session["AppResinfo4"].ToString(); }

            //Set Application Information
            public static void setAppProgID(string psValue) { HttpContext.Current.Session["AppProgID"] = psValue; }
            public static void setAppIsLoggedIn(string psValue) { HttpContext.Current.Session["AppIsLoggedIn"] = psValue; }
            //Get Application Information
            public static string getAppProgID() { return HttpContext.Current.Session["AppProgID"].ToString(); }
            public static string getAppIsLoggedIn() { return HttpContext.Current.Session["AppIsLoggedIn"].ToString(); }



        } //End public class SessionInfo
        public class ConstantaInfo {
            //Formats
            public const string FMT_DTSHT = "dd/MM/yyyy";
            public const string FMT_DTSHT_JS = "dd/mm/yy";
            public const string FMT_DTLONG = "dd/MM/yyyy hh:mm:ss";
            public const string FMT_DTLONG_JS = "dd/MM/yy hh:mm:ss";
            public const string FMT_DECNUM = "2";
            //Input mask
            public const string IMSK_DTSHT = "99/99/9999";
            //Sign and Symbols
            public const string SGN_1000SEP = ",";
            public const string SGN_DECSEP = ".";
            public const string SGN_CURR = "Rp.";
            //Codes
            public const string LNG_DEFF = "ID";
            //BaseURL
            //public const string BASE_URL = 
            //Application Module
            public const int MDLE_ID = 1; //modif this line for testing = CCS/HCIS/HRIS

        } //End public class ConstantaInfo
    } //End public class hlpConfig
} //End namespace APPBASE.Helper
