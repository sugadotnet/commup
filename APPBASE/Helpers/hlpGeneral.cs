using System;
using System.Collections.Generic;
using System.Web;
using System.IO;

namespace APPBASE.Helpers
{
    public class hlpGeneral
    {
        #region 02 - Class Web
        public class ClientSystemInfo
        {

            #region 01 - Get Area

            public static string getClientIPAddress()
            {
                string vReturn = "";
                HttpContext voContext = HttpContext.Current;
                string vsHTTP_X_FORWARDED_FOR = voContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                string vsREMOTE_ADDR = voContext.Request.ServerVariables["REMOTE_ADDR"];

                if (!string.IsNullOrEmpty(vsHTTP_X_FORWARDED_FOR))
                    vReturn = vsHTTP_X_FORWARDED_FOR;
                else
                    vReturn = vsREMOTE_ADDR;

                return vReturn;
            }
            public static string getClientComputerName()
            {
                string vReturn = "";

                //HttpContext voContext = HttpContext.Current;

                //string vsHTTP_X_FORWARDED_FOR = voContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                //string vsREMOTE_ADDR = voContext.Request.ServerVariables["REMOTE_ADDR"];

                //if (!string.IsNullOrEmpty(vsHTTP_X_FORWARDED_FOR))
                //    vReturn = System.Net.Dns.GetHostByAddress(vsHTTP_X_FORWARDED_FOR).HostName;
                //else
                //    vReturn = System.Net.Dns.GetHostByAddress(vsREMOTE_ADDR).HostName;

                return vReturn.ToUpper();
            }
            public static string getLoggedInUserID()
            {
                string vReturn = HttpContext.Current.Session["AppUsername"].ToString();
                return vReturn;
            }
            public static string getAppProgID()
            {
                string vReturn = HttpContext.Current.Session["AppProgID"].ToString();
                return vReturn;
            }
            public static DateTime getAppDateTime()
            {
                DateTime vReturn = DateTime.Now;
                return vReturn;
            }

            #endregion

            #region 02 - Set Area

            public static void setLoggedInUserID(string psUserID)
            {
                HttpContext.Current.Session["AppUsername"] = psUserID;
                HttpContext.Current.Session["AppIsLoggedIn"] = hlpFlagInfo.getFlagValid();
            }
            public static void setAppProgID(string psProgID)
            {
                HttpContext.Current.Session["AppProgID"] = psProgID;
            }

            #endregion

        }
        public class AppUploadInfo
        {

            //Root
            public static string getPathPhoto()
            {
                string vReturn = "";
                //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                //vReturn = voPage.ResolveUrl("~/App_DataUpload/Photo/");
                vReturn = "~/App_DataUpload/Photo/";
                return vReturn;
            }
            public static string getDefaultPhoto()
            {
                string vReturn = "";
                //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                //vReturn = voPage.ResolveUrl("~/App_DataUpload/Photo/PhotoNA.jpg");
                vReturn = "~/App_DataUpload/Photo/PhotoNA.jpg";
                return vReturn;
            }
            public static string getPhoto(string psRUID)
            {
                string vsErrMsg = "";
                string vReturn = "";
                string vsFileName = "";
                string vsRUIDFileName = "";
                string vsDefFileName = "";

                try
                {
                    //Check if RUID is empty then get default image
                    if (psRUID != "")
                        vsFileName = psRUID + ".jpg";
                    else
                        vsFileName = "EmpPhotoNA.jpg";

                    vsRUIDFileName = "~/App_DataUpload/Photo/" + vsFileName;
                    vsDefFileName = "~/App_DataUpload/Photo/EmpPhotoNA.jpg";

                    //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                    //vsRUIDFileName = VirtualPathUtility.ToAbsolute("~/App_DataUpload/Photo/" + vsFileName);
                    //vsDefFileName = VirtualPathUtility.ToAbsolute("~/App_DataUpload/Photo/EmpPhotoNA.jpg");
                    //vsRUIDFileName = voPage.ResolveUrl("~/App_DataUpload/APP_HR/EmpPhoto/" + vsFileName);
                    //vsDefFileName = voPage.ResolveUrl("~/App_DataUpload/APP_HR/EmpPhoto/EmpPhotoNA.jpg");

                    //Check if image file exist

                    if (File.Exists(HttpContext.Current.Server.MapPath(vsRUIDFileName)))
                        vReturn = vsRUIDFileName;
                    else
                        vReturn = vsDefFileName;
                }
                catch (System.Exception e) { vsErrMsg = e.Message; }
                finally { }



                return vReturn;
            }

            //HR
            public static string getPathEmpPhotoHR()
            {
                string vReturn = "";
                //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                //vReturn = voPage.ResolveUrl("~/App_DataUpload/APP_HR/EmpPhoto/");
                vReturn = "~/App_DataUpload/APP_HR/EmpPhoto/";
                return vReturn;
            }
            public static string getDefaultEmpPhotoHR()
            {
                string vReturn = "";
                //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                //vReturn = voPage.ResolveUrl("~/App_DataUpload/DATA_HR/EmpPhoto/EmpPhotoNA.jpg");
                vReturn = "~/App_DataUpload/DATA_HR/EmpPhoto/EmpPhotoNA.jpg";
                return vReturn;
            }
            public static string getEmpPhotoHR(string psRUID)
            {
                string vsErrMsg = "";
                string vReturn = "";
                string vsFileName = "";
                string vsRUIDFileName = "";
                string vsDefFileName = "";

                try
                {
                    //Check if RUID is empty then get default image
                    if (psRUID != "")
                        vsFileName = psRUID + ".jpg";
                    else
                        vsFileName = "EmpPhotoNA.jpg";

                    vsRUIDFileName = "~/App_DataUpload/APP_HR/EmpPhoto/" + vsFileName;
                    vsDefFileName = "~/App_DataUpload/APP_HR/EmpPhoto/EmpPhotoNA.jpg";

                    //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                    //vsRUIDFileName = VirtualPathUtility.ToAbsolute("~/App_DataUpload/APP_HR/EmpPhoto/" + vsFileName);
                    //vsDefFileName = VirtualPathUtility.ToAbsolute("~/App_DataUpload/APP_HR/EmpPhoto/EmpPhotoNA.jpg");
                    //vsRUIDFileName = voPage.ResolveUrl("~/App_DataUpload/APP_HR/EmpPhoto/" + vsFileName);
                    //vsDefFileName = voPage.ResolveUrl("~/App_DataUpload/APP_HR/EmpPhoto/EmpPhotoNA.jpg");

                    //Check if image file exist

                    if (File.Exists(HttpContext.Current.Server.MapPath(vsRUIDFileName)))
                        vReturn = vsRUIDFileName;
                    else
                        vReturn = vsDefFileName;
                }
                catch (System.Exception e) { vsErrMsg = e.Message; }
                finally { }



                return vReturn;
            }

            //ASM
            public static string getDefaultEmpPhotoASM()
            {
                string vReturn = "";
                //System.Web.UI.Page voPage = HttpContext.Current.Handler as System.Web.UI.Page;
                //vReturn = voPage.ResolveUrl("~/App_DataUpload/APP_ASM/EmpPhoto/EmpPhotoNA.jpg");
                vReturn = "~/App_DataUpload/APP_ASM/EmpPhoto/EmpPhotoNA.jpg";
                return vReturn;
            }
        }
        #endregion

        #region 03 Class LKP Default Value
        public class LKPDefaultValue
        {
            #region 01 - Get Area
            public static string getLocalCountryID() { return "ID"; }
            public static string getLocalCountryNm() { return "Indonesia"; }
            #endregion
        }
        #endregion

        #region 04 Class Pagination
        public class Pagination
        {
            public static Boolean isMOD(int pnTROW, int pnRPP)
            {
                Boolean vReturn = false;
                int vnMOD = pnTROW % pnRPP;
                if (vnMOD > 0)
                    vReturn = true;
                return vReturn;
            } //End function isMOD
            public static int getPCOUNT(int pnTROW, int pnRPP)
            {
                int vReturn = 0;
                string vsErrMsg = "";
                int vnMOD = 0;
                int vnTROW = 0;
                int vnPCOUNT = 0;

                try
                {
                    if (pnTROW < pnRPP)
                    {
                        vnPCOUNT = 1;
                    }
                    else
                    {
                        vnMOD = pnTROW % pnRPP;
                        vnTROW = pnTROW - vnMOD;
                        vnPCOUNT = vnTROW / pnRPP;
                        if (vnMOD > 0)
                            vnPCOUNT = vnPCOUNT + 1;
                    } //End if
                } //End try
                catch (System.Exception e) { vsErrMsg = e.Message; } //End catch
                finally { } //End Catch

                vReturn = vnPCOUNT;
                return vReturn;
            } //End function getPCOUNT
            public static int getRSTART(int pnTROW, int pnRPP, int pnPCURR)
            {
                int vReturn = 0;
                string vsErrMsg = "";
                int vnMOD = 0;
                int vnTROW = 0;
                int vnPCOUNT = 0;
                int vnRSTART = 0;
                int vnREND = 0;
                try
                {
                    vnMOD = pnTROW % pnRPP;
                    vnTROW = pnTROW - vnMOD;

                    if (pnRPP > 0)
                    {
                        vnPCOUNT = getPCOUNT(pnTROW, pnRPP);

                        if (pnPCURR < vnPCOUNT)
                        {
                            vnREND = pnRPP * pnPCURR;
                            vnRSTART = (vnREND - pnRPP) + 1;
                        }
                        else
                        {
                            if (vnMOD > 0)
                            {
                                vnRSTART = vnTROW + 1;
                                vnREND = pnTROW;
                            } //End if
                        } //End if
                    } //End if

                } //End try
                catch (System.Exception e) { vsErrMsg = e.Message; } //End catch
                finally { } //End finally
                vReturn = vnRSTART;
                return vReturn;
            } //End function getREND
            public static int getREND(int pnTROW, int pnRPP, int PCURR)
            {
                int vReturn = 0;
                string vsErrMsg = "";
                try { } //End try
                catch (System.Exception e) { vsErrMsg = e.Message; } //End catch
                finally { } //End finally
                return vReturn;
            } //End function getREND
        } //End class Pagination
        #endregion

        #region 05 Class LOV
        public class LOV_ATTRIBUTE
        {
            public static string DESCTYPE_NM = "NM";
            public static string DESCTYPE_SYM = "SYM";
            public static string DESCTYPE_VALNUM = "VALNUM";
            public static string DESCTYPE_VALSTR = "VALSTR";
        } //End class LOV_ATTRIBUTE
        #endregion
    } //End public class hlpGeneral
} //End namespace APPBASE.Helper
