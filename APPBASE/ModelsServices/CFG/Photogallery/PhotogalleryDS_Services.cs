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
    public class PhotogalleryDS
    {
        //Constructor
        public PhotogalleryDS() { } //End public PhotogalleryDS
        public List<PhotogallerylistVM> getDatalist()
        {
            List<PhotogallerylistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Photogallerys
                           select new PhotogallerylistVM
                           {
                               ID = tb.ID,
                               TITLE = tb.TITLE,
                               PHOTO_IMG = tb.PHOTO_IMG,
                               SHORT_DESC = tb.SHORT_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<PhotogallerylistVM> getDatalist()
        public PhotogallerydetailVM getData(int? id = null)
        {
            PhotogallerydetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Photogallerys
                           where tb.ID == id
                           select new PhotogallerydetailVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               TITLE = tb.TITLE,
                               PHOTO_IMG = tb.PHOTO_IMG,
                               SHORT_DESC = tb.SHORT_DESC,
                               FULL_DESC = tb.FULL_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public PhotogallerydetailVM getData(int? id = null)


        public List<PhotogallerylookupVM> getDatalist_lookup()
        {
            List<PhotogallerylookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Photogallerys
                           select new PhotogallerylookupVM
                           {
                               ID = tb.ID,
                               TITLE = tb.TITLE,
                               SHORT_DESC = tb.SHORT_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<PhotogallerylookupVM> getDatalist_lookup()
    } //End public class PhotogalleryDS
} //End namespace APPBASE.Models
