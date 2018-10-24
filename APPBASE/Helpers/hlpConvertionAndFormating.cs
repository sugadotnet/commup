using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using APPBASE.Helpers;

namespace APPBASE.Helpers
{
    public static class hlpConvertionAndFormating
    {
        #region 01 - String TO Any
            public static DateTime? ConvertStringToDate(string psValue, string psDateFormat)
            {
                DateTime? vReturn = null; ;
                if ((psValue != "") && (psDateFormat != ""))
                    vReturn = DateTime.ParseExact(psValue, psDateFormat, CultureInfo.InvariantCulture);
                return vReturn;
            }
            public static DateTime? ConvertStringToDateShort(string psValue)
            {
                DateTime? vReturn = null;
                if (psValue != "")
                    vReturn = DateTime.ParseExact(psValue, HttpContext.Current.Session["AppDefDateFormatShort"].ToString(), CultureInfo.InvariantCulture);
                return vReturn;
            }
            public static DateTime? ConvertStringToDateLong(string psValue)
            {
                DateTime? vReturn = null;
                if (psValue != "")
                    vReturn = DateTime.ParseExact(psValue, HttpContext.Current.Session["AppDefDateFormatLong"].ToString(), CultureInfo.InvariantCulture);
                return vReturn;
            }
            public static int? ConvertStringToInt(string psValue)
            {
                int? vReturn = null;
                if ((psValue != "") && (psValue != null))
                {
                    string vsValue = psValue;
                    vsValue = vsValue.Replace(HttpContext.Current.Session["AppDef1000Separator"].ToString(), "").Trim();
                    vReturn = Convert.ToInt32(vsValue);
                }
                return vReturn;
            }
            public static decimal? ConvertStringToDecimal(string psValue)
            {
                decimal? vReturn = null;
                if ((psValue != "") && (psValue != null))
                {
                    string vsValue = psValue;
                    vsValue = vsValue.Replace(HttpContext.Current.Session["AppDef1000Separator"].ToString(), "").Trim();
                    vReturn = Convert.ToDecimal(vsValue);
                }
                return vReturn;
            }
        #endregion

        #region 02 - Any TO String
            public static string ConvertDateToStringDateShortFmt(DateTime? pdDateValue)
            {
                string vReturn = "";
                if (pdDateValue != null) {
                    vReturn = string.Format("{0:" + HttpContext.Current.Session["AppDefDateFormatShort"].ToString() + "}", pdDateValue);
                    //DateTime vd = Convert.ToDateTime(pdDateValue);
                    //string vReturn = vd.ToString(HttpContext.Current.Session["AppDefDateFormatShort"].ToString());
                } //End if
                
                return vReturn;
            }
            public static string ConvertDateToStringDateLongFmt(DateTime? pdDateValue)
            {
                string vReturn = string.Format("{0:" + HttpContext.Current.Session["AppDefDateFormatLong"].ToString() + "}", pdDateValue);
                return vReturn;
            }

            public static string ConvertDateToStringMonthID(DateTime? pdDateValue)
            {

                string vReturn = "";
                int nMonthValue = pdDateValue.Value.Month;

                if (nMonthValue == 1) vReturn = "Januari";
                if (nMonthValue == 2) vReturn = "Februari";
                if (nMonthValue == 3) vReturn = "Maret";
                if (nMonthValue == 4) vReturn = "April";
                if (nMonthValue == 5) vReturn = "Mei";
                if (nMonthValue == 6) vReturn = "Juni";
                if (nMonthValue == 7) vReturn = "Juli";
                if (nMonthValue == 8) vReturn = "Agustus";
                if (nMonthValue == 9) vReturn = "September";
                if (nMonthValue == 10) vReturn = "Oktober";
                if (nMonthValue == 11) vReturn = "November";
                if (nMonthValue == 12) vReturn = "Desember";

                return vReturn;
            }
            public static string ConvertDateToStringDayID(DateTime? pdDateValue)
            {

                string vReturn = "";
                string[] hari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jum\'at", "Sabtu" };
                int nDay = (int)pdDateValue.Value.DayOfWeek;
                vReturn = hari[nDay];
                return vReturn;
            }

            public static string ConvertDateToStringDayIDLongFmt(DateTime? pdDateValue)
            {
                string vReturn = "";
                if (pdDateValue != null) {
                    vReturn = ConvertDateToStringDayID(pdDateValue) + ", " +
                                     pdDateValue.Value.Day.ToString() + " " +
                                     ConvertDateToStringMonthID(pdDateValue) + " " +
                                     pdDateValue.Value.Year.ToString();
                } //End if (pdDateValue != null)

                return vReturn;
            }
            public static string ConvertDateToStringLongFmt(DateTime? pdDateValue)
            {

                int nTes = (int)pdDateValue.Value.DayOfWeek;

                string vReturn = pdDateValue.Value.Day.ToString() + " " +
                                 ConvertDateToStringMonthID(pdDateValue) + " " +
                                 pdDateValue.Value.Year.ToString();
                return vReturn;
            }
            public static string ConvertDateToStringMMMFmt(DateTime? pdDateValue)
            {
                string vReturn = "";

                if (pdDateValue!=null)
                vReturn = pdDateValue.Value.Day.ToString() + " " +
                          ConvertDateToStringMonthID(pdDateValue).Substring(0,3) + " " +
                          pdDateValue.Value.Year.ToString();

                return vReturn;
            }

            public static string constructDecimalDigitFormatByPar(int pnDecimal)
            {
                string vReturn = "";
                int vnLoop = pnDecimal;

                for (int i = 0; i < vnLoop; i++)
                {
                    vReturn = vReturn + "0";
                }

                return vReturn;
            }
            public static string constructDecimalDigitFormat()
            {
                string vReturn = "";
                int vnLoop = Convert.ToInt32(HttpContext.Current.Session["AppDefDecimalDigit"].ToString().Trim());

                for (int i = 0; i < vnLoop; i++)
                {
                    vReturn = vReturn + "0";
                }

                return vReturn;
            }

            public static string ConvertDecimalToStringFmt(decimal? pnValue)
            {
                string vReturn = "";
                string vsFmt = "{0:#0." + constructDecimalDigitFormat() + "}";
                vReturn = String.Format(vsFmt, pnValue);
                return vReturn;
            }
            public static string ConvertDecimalToStringFmtRound(decimal? pnValue, int pnRound)
            {
                string vReturn = "";
                string vsFmt = "{0:#0." + constructDecimalDigitFormatByPar(pnRound) + "}";
                vReturn = String.Format(vsFmt, pnValue);
                return vReturn;
            }

            public static string ConvertDecimalToStringFmtThousand(decimal? pnValue)
            {
                string vReturn = "";
                string vsFmt = "{0:#,##0." + constructDecimalDigitFormat() + "}";
                vReturn = String.Format(vsFmt, pnValue);
                return vReturn;
            }
        #endregion

        #region 03 - Terbilang
            public static string ConvertDecimalToTerbilang(decimal? pnValue)
            {
                string vReturn = "";

                using (var oVar = new hlpTerbilang(pnValue)) {
                    vReturn = oVar.Hasil();
                } //End using (var oVar = new hlpTerbilang())

                return vReturn;
            } //End public static string ConvertDecimalToTerbilang(decimal? pnValue)
        #endregion
    } //End public class hlpConvertionAndFormating
} //End namespace APPBASE.Helper
