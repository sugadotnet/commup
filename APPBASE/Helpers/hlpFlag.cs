using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using APPBASE.Svcbiz;

namespace APPBASE.Helpers
{
    public class hlpFlagInfo
    {
        public static string getFlagValid()
        {
            return "Y";
        }
        public static string getFlagNotValid()
        {
            return "N";
        }

        public static string getFlagUserStatus(int? id=null)
        {
            if (id == valFLAG.FLAG_USER_STS_ACTIVE_ID) return valFLAG.FLAG_USER_STS_ACTIVE;
            if (id == valFLAG.FLAG_USER_STS_INACTIVE_ID) return valFLAG.FLAG_USER_STS_INACTIVE;
            return "";
        }


        public static string getNumSuccess()
        {
            return "0";
        }
        public static string getNumFailed()
        {
            return "1";
        }
        public static string getNumErrApp()
        {
            return "1";
        }
        public static string getNumErrSys()
        {
            return "2";
        }

    } //End public class FlagInfo
} //End namespace APPBASE.Helper
