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
    public class ProductnewCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor
        public ProductnewCRUD() { } //End public ProductnewCRUD()
        public void Create(ProductnewVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Productnew oModel = new Productnew();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                    //Set Image file name
                    oModel.PRODNEW_IMAGE = Utility_FileUploadDownload.setImage_Product();

                    //Process CRUD
                    db.Productnews.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                        if ((oModel.PRODNEW_IMAGE == null) || (oModel.PRODNEW_IMAGE == "")) { oModel.PRODNEW_IMAGE = Utility_FileUploadDownload.setImage_Product(); }
                    { Utility_FileUploadDownload.saveImage_Product(poFileimage, oModel.PRODNEW_IMAGE); } //End if (poFileimage != null)
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(ProductnewVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Productnew oModel = db.Productnews.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                    //Set Image file name
                    if (poFileimage != null) { if ((oModel.PRODNEW_IMAGE == null) || (oModel.PRODNEW_IMAGE == "")) { oModel.PRODNEW_IMAGE = Utility_FileUploadDownload.setImage_Product(); } } //End if (poFileimage != null)

                    //Process CRUD
                    db.Entry(oModel).State = EntityState.Modified;
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                        if ((oModel.PRODNEW_IMAGE == null) || (oModel.PRODNEW_IMAGE == "")) { oModel.PRODNEW_IMAGE = Utility_FileUploadDownload.setImage_Product(); }
                    { Utility_FileUploadDownload.saveImage_Product(poFileimage, oModel.PRODNEW_IMAGE); } //End if (poFileimage != null)
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
                    Productnew oModel = db.Productnews.Find(id);
                    db.Productnews.Remove(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;
                    //Delete Image file
                    Utility_FileUploadDownload.deleteImage_Product(oModel.PRODNEW_IMAGE);
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete
    } //End public class ProductnewCRUD
} //End namespace APPBASE.Models
