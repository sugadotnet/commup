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
using APPBASE.Svcutil;
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public class UserCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor
        public UserCRUD() { this.isERR = false; this.ERRMSG = ""; } //End public UserCRUD()

        public void Create(UserdetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    User oModel = new User();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                    //USER_STS
                    oModel.USER_STS = valFLAG.FLAG_ACTIVE_ID;
                    //Set Image file name
                    if (poFileimage != null) { oModel.USER_IMG = Utility_FileUploadDownload.setImage_User(); } //End if (poFileimage != null)

                    //Process CRUD
                    db.Users.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                    { Utility_FileUploadDownload.saveImage_User(poFileimage, oModel.USER_IMG); } //End if (poFileimage != null)

                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(UserdetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    User oModel = db.Users.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                    int? nROLE_ID = oModel.ROLE_ID;
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Get existing field value
                    if (nROLE_ID == 7) { oModel.ROLE_ID = nROLE_ID; }
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //Set Image Filename
                    if (poFileimage != null)
                    {
                        if ((oModel.USER_IMG == null) || (oModel.USER_IMG == "")) { oModel.USER_IMG = Utility_FileUploadDownload.setImage_User(); }
                    } //End if (poFileimage != null)
                    //DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                    //Process CRUD
                    db.Entry(oModel).State = EntityState.Modified;
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                    { 
                        Utility_FileUploadDownload.saveImage_User(poFileimage, oModel.USER_IMG);
                    } //End if (poFileimage != null)
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update
        public void Delete(int? id)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    User oModel = db.Users.Find(id);
                    db.Users.Remove(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Delete Image file
                    Utility_FileUploadDownload.deleteImage_User(oModel.USER_IMG);
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete

        public void Changepassword(UserdetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    User oModel = db.Users.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                    //Change password
                    oModel.PASSWORD = poViewModel.PASSWORD_NEW1;
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                    //Process CRUD
                    db.Entry(oModel).State = EntityState.Modified;
                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update
    } //End public class UserCRUD
} //End namespace APPBASE.Models

