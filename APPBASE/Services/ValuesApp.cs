using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPBASE.Svcapp
{
    public class valDFLT
    {
        //Attribut Default User
        public const string SYSADMIN_USER = "SYSADMIN";
        public const string SYSADMIN_PASSWORD = "kuy4bulu5";
    } //End public class valDFLT


    public class valFLAG {
        //True/False
        public const string FLAG_TRUE = "TRUE";
        public const string FLAG_FALSE = "FALSE";

        //Active/Inactive
        public const string FLAG_YES = "Y";
        public const string FLAG_NO = "N";

        //Active/Inactive
        public const string FLAG_ACTIVE = "ACTIVE";
        public const string FLAG_INACTIVE = "INACTIVE";
        public const int FLAG_ACTIVE_ID = 1;
        public const int FLAG_INACTIVE_ID = 0;

        //CRUDOPT
        public const string FLAG_CRUDOPT_CREATE = "CREATE";
        public const string FLAG_CRUDOPT_UPDATE = "UPDATE";
        public const string FLAG_CRUDOPT_DELETE = "DELETE";

        //DTA_STS
        public const Byte FLAG_DTA_STS_CREATE = 1;
        public const Byte FLAG_DTA_STS_UPDATE = 2;
        public const Byte FLAG_DTA_STS_DELETE = 3;

        //UOM
        public const string FLAG_UOM_PCT = "LOV_UOM_PCT";
        public const string FLAG_UOM_VAL = "LOV_UOM_VAL";
        public const string FLAG_UOM_QTY = "LOV_UOM_QTY";
        public const string FLAG_UOM_UNT = "LOV_UOM_UNT";
        public const string FLAG_UOM_MNYRP = "LOV_UOM_MNYRP";
        public const string FLAG_UOM_MNYUSD = "LOV_UOM_MNYUSD";

        //RNGOPR
        public const string FLAG_RNGOPR_001 = "LOV_RNGOPR_001";
        public const string FLAG_RNGOPR_002 = "LOV_RNGOPR_002";
        public const string FLAG_RNGOPR_003 = "LOV_RNGOPR_003";
        public const string FLAG_RNGOPR_004 = "LOV_RNGOPR_004";
        public const string FLAG_RNGOPR_005 = "LOV_RNGOPR_005";
        public const string FLAG_RNGOPR_006 = "LOV_RNGOPR_006";
        public const string FLAG_RNGOPR_007 = "LOV_RNGOPR_007";
        public const string FLAG_RNGOPR_008 = "LOV_RNGOPR_008";

        //MAXLENGTH
        public const int FLAG_MAXLENGTH_ID = 30;
        public const int FLAG_MAXLENGTH_NM = 100;
        public const int FLAGL_MAXLENGTH_REMARKSHORT = 30;
        public const int FLAG_MAXLENGTH_REMARKLONG = 50;
        public const int FLAG_MAXLENGTH_DESCSHORT = 100;
        public const int FLAG_MAXLENGTH_DESCLONG = 4000;
    } //End public class valFLAG
} //End namespace APPBASE.Svcapp