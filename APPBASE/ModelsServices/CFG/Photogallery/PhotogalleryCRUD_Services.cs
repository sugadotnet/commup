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
    public class PhotogalleryCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor
        public PhotogalleryCRUD() { } //End public PhotogalleryCRUD()
        public void Create(PhotogallerydetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Photogallery oModel = new Photogallery();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                    //Set Image file name
                    oModel.PHOTO_IMG = Utility_FileUploadDownload.setImage_Gallery();

                    //Process CRUD
                    db.Photogallerys.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                    { Utility_FileUploadDownload.saveImage_Gallery(poFileimage, oModel.PHOTO_IMG); } //End if (poFileimage != null)

                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(PhotogallerydetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Photogallery oModel = db.Photogallerys.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                    //Process CRUD
                    db.Entry(oModel).State = EntityState.Modified;
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                    if ((oModel.PHOTO_IMG == null) || (oModel.PHOTO_IMG == "")) { oModel.PHOTO_IMG = Utility_FileUploadDownload.setImage_Gallery(); }
                    { Utility_FileUploadDownload.saveImage_Gallery(poFileimage, oModel.PHOTO_IMG); } //End if (poFileimage != null)


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
                    Photogallery oModel = db.Photogallerys.Find(id);
                    db.Photogallerys.Remove(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Delete Image file
                    Utility_FileUploadDownload.deleteImage_Gallery(oModel.PHOTO_IMG);

                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete
    } //End public class PhotogalleryCRUD
} //End namespace APPBASE.Models
