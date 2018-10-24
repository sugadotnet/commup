using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public class UserDS
    {
        //Constructor
        public UserDS() { } //End public UserDS
        
        //Data List
        public List<UserlistVM> getDatalist()
        {
            List<UserlistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.User_infos
                           select new UserlistVM
                           {
                               ID = tb.ID,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               ROLE_DISPLAY_NAME = tb.ROLE_DISPLAY_NAME,
                               USER_STS = tb.USER_STS
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<User_ListVM> getDatalist()
        //Data Single
        public UserdetailVM getData(int? id = null)
        {
            UserdetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.User_infos
                           where tb.ID == id
                           select new UserdetailVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               RES_ID = tb.RES_ID,
                               ROLE_ID = tb.ROLE_ID,
                               USERNAME = tb.USERNAME,
                               PASSWORD = tb.PASSWORD,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               EMAIL = tb.EMAIL,
                               USER_STS = tb.USER_STS,
                               USER_IMG = tb.USER_IMG
                           };
                oReturn = oQRY.SingleOrDefault();
                oReturn.PASSWORD = hlpObf.randomDecrypt(oReturn.PASSWORD);
            } //End using (var = new DbContext())
            return oReturn;
        } //End public User_DetailVM getData(string id = null)
        public UsercredentialVM getData_Usercredential(string psUsername = null)
        {
            UsercredentialVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Users
                           where tb.USERNAME.ToUpper() == psUsername.ToUpper()
                           select new UsercredentialVM
                           {
                               RES_ID = tb.RES_ID,
                               USERNAME = tb.USERNAME,
                               PASSWORD = tb.PASSWORD,
                               DISPLAY_NAME = tb.DISPLAY_NAME,
                               ID = tb.ID,
                               ROLE_ID = tb.ROLE_ID,
                               USER_IMG = tb.USER_IMG
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public User_DetailVM getData(string id = null)
        public UserdetailVM getData_RES_ID(int? id = null)
        {
            UserdetailVM oReturn;
            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.User_infos
                           where tb.ID == id
                           select new UserdetailVM
                           {RES_ID = tb.RES_ID};
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public UserdetailVM getData_RES_ID(int? id = null)

        //Check Exists
        public Boolean isExists_Username(string psUsername = null)
        {


            using (var db = new DBMAINContext())
            {
                var oQRY = (from tb in db.User_infos
                            where tb.USERNAME == psUsername
                            select new { USERNAME = tb.USERNAME }).ToList();

                if (oQRY.Count > 0) { return true; }


            } //End using (var = new DbContext())
            return false;
        } //End public Boolean isExists_USR_ID(string id = null)
        //Check Granted user to menu
        public Boolean isGranted_menu(int? pnRoleId = null, int? pnMenuId = null)
        {
            Boolean vReturn = false;

            using (var db = new DBMAINContext())
            {
                //var oQRY = (from tb in db.Usermenus
                //            where tb.MNU_RUID == id && tb.MDLE_RUID == sMDLE_RUID && tb.USR_RUID == sUSR_RUID
                //            select new { MNU_RUID = tb.MNU_RUID }).ToList();

                //if (oQRY.Count > 0) { vReturn = true; }


            } //End using (var = new DbContext())
            return vReturn;
        } //End public Boolean isExists_USR_ID(string id = null)
    } //End public class UserDS
} //End namespace APPBASE.Models

