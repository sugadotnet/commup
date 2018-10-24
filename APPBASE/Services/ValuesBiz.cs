using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPBASE.Svcbiz
{
    public class valFLAG : Svcapp.valFLAG
    {
        //Employee BP_STS Active/Inactive
        public const string FLAG_EMPBPSTS_ACTIVE = "LOV_HRS_EMP_EXISTS_ACTIVE";
        public const string FLAG_EMPBPSTS_INACTIVE = "LOV_HRS_EMP_EXISTS_QUIT";

        //USER_STS
        public const int FLAG_USER_STS_ACTIVE_ID = 1;
        public const string FLAG_USER_STS_ACTIVE = "Aktif";
        public const int FLAG_USER_STS_INACTIVE_ID = 0;
        public const string FLAG_USER_STS_INACTIVE = "Tidak Aktif";

        //STORAGE_ID
        public const int STORAGE_ID_GATAS = 1;
        public const int STORAGE_ID_GBAWAH = 2;
        public const int STORAGE_ID_DISPLAY = 3;
        public const int STORAGE_ID_KASIR = 4;
        //TRN_TYPEID
        public const int TRN_TYPEID_NEW = 0;
        public const int TRN_TYPEID_MUTASI = 1;
        public const int TRN_TYPEID_SELL = 2;
        public const int TRN_TYPEID_REVADD = 3;
        public const int TRN_TYPEID_REVSUB = 4;

        //ROLE_ID
        public const int FLAG_ROLE_ADM = 1;
        public const int FLAG_ROLE_GDGA = 2;
        public const int FLAG_ROLE_GDGB = 3;
        public const int FLAG_ROLE_SLS = 4;
        public const int FLAG_ROLE_CSR = 5;

    } //End public class valFLAG
} //End namespace APPBASE.Svcbiz