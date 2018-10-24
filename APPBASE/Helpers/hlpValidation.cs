using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;

namespace APPBASE.Helpers
{
    public class hlpValidation
    {
        public static bool isValidEmail(string psEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(psEmail))
                return (true);
            else
                return (false);
        }
    } //End public class hlpGeneral
} //End namespace APPBASE.Helper
