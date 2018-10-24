using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using APPBASE.Helpers;

namespace APPBASE.Svcutil
{
    public class Utility_FileUploadDownload
    {
        private const string PATH_PHOTOUSER = "App_DataUpload/UserPhoto/";
        private const string PATH_PHOTOEMP = "App_DataUpload/EmpPhoto/";
        private const string PATH_PHOTOSTUDENT = "App_DataUpload/StudentPhoto/";
        private const string PATH_PHOTOGALLERY = "App_DataUpload/Gallery/";
        private const string PATH_PHOTOSONG = "App_DataUpload/Song/";
        private const string PATH_PHOTOPRODUCT = "App_DataUpload/Product/";
        private const string PHOTO_NA = "PhotoNA.jpg";


        //General
        public static Boolean isImageMaxdim100x100(HttpPostedFileBase poFileimage)
        {
            string vsMsgErr = "";

            try
            {
                
                System.IO.Stream stream = poFileimage.InputStream;
                System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                int nHeight = image.Height;
                int nWidth = image.Width;
                if ((nHeight == 100) && (nWidth == 100)) { return true; }
            } //End try
            catch (Exception e) { vsMsgErr = e.Message; } //End catch
            return false;
        } //End public static void saveImage(HttpPostedFileBase poFileimage, string psFilename, string psPATH)
        public static string setImage(string psFilename=null) {
            string sFilename = psFilename;
            if ((sFilename == null) || (sFilename == "")) { sFilename = Guid.NewGuid().ToString() + ".jpg"; }
            return sFilename;
        } //End public static string setImageName(string psFilename)
        public static string getImage(string psFilename = null, string psPATH = null)
        {
            string sFilepath = "";
            string sFilename = "";
            string sPhotoNA = PHOTO_NA;

            if ((psFilename == null) || (psFilename == ""))
            {

                //sFilename = Helpers.hlpConfig.SessionInfo.getAppUsrIMG_SRC();
                if ((sFilename == null) || (sFilename == "")) { sFilename = sPhotoNA; }
            }
            else
            {
                sFilename = psFilename;
            } //End if ((psFilename == null) || (psFilename == ""))

            sFilepath = HttpContext.Current.Request.MapPath("~/" + psPATH + sFilename);
            if (!System.IO.File.Exists(sFilepath))
            {
                sFilename = sPhotoNA;
            } //End if (!System.IO.File.Exists(sFilepath))

            return psPATH + sFilename;
        } //End public static string getImage_Student(string psFilename)
        public static string getImageNA(string psPATH)
        {
            return psPATH + PHOTO_NA;
        } //End public static string getImageNA(string psPATH)
        public static void saveImage(HttpPostedFileBase poFileimage, string psFilename, string psPATH)
        {
            string vsMsgErr = "";
            string sFilename = setImage(psFilename);
            try
            {
                if (poFileimage != null)
                {
                    int nSize = poFileimage.ContentLength;
                    string sFiletype = poFileimage.ContentType;
                    var oFile = HttpContext.Current.Server.MapPath("~/" + psPATH + sFilename);
                    poFileimage.SaveAs(oFile);
                } //End if (poFileimage != null)
            }
            catch (Exception e) { vsMsgErr = e.Message; } //End catch
        } //End public static void saveImage(HttpPostedFileBase poFileimage, string psFilename, string psPATH)
        public static void deleteImage(string psFilename, string psPATH)
        {
            string vsMsgErr = "";
            string sFilename = psFilename;

            try
            {
                //string sFilename = HttpContext.Current.Server.MapPath(psPATH);
                string sFile1 = HttpContext.Current.Server.MapPath("~/" + psPATH + sFilename);
                string sFile2 = HttpContext.Current.Server.MapPath("~/" + psPATH + sFilename);
                string sFile3 = HttpContext.Current.Server.MapPath("~/" + psPATH + sFilename);

                FileInfo oFile1 = new FileInfo(sFile1);
                FileInfo oFile2 = new FileInfo(sFile2);
                FileInfo oFile3 = new FileInfo(sFile3);

                //FileInfo oFile1 = new FileInfo(sFilename + psFilename + ".jpg");
                //FileInfo oFile2 = new FileInfo(sFilename + psFilename + ".bmp");
                //FileInfo oFile3 = new FileInfo(sFilename + psFilename + ".gif");

                if (oFile1.Exists) { oFile1.Delete(); }
                if (oFile2.Exists) { oFile2.Delete(); }
                if (oFile3.Exists) { oFile3.Delete(); }
            }
            catch (Exception e) { vsMsgErr = e.Message; } //End catch
        } //End public static void deleteImage(string psFilename, string psPATH)

        //User
        public static string setImage_User() { return setImage(); } //End public static string setImage_User()
        public static string getImage_User(string psFilename = null)
        {
            return getImage(psFilename, PATH_PHOTOUSER);
        } //End public static string getImage_User(string psFilename)
        public static string getImage_UserNA()
        {
            return getImageNA(PATH_PHOTOUSER);
        } //End public static string getImage_UserNA(string psFilename)
        public static void saveImage_User(HttpPostedFileBase poFileimage, string psFilename)
        {
            saveImage(poFileimage, psFilename, PATH_PHOTOUSER);
        } //End public void saveImage_User()
        public static void deleteImage_User(string psFilename)
        {
            deleteImage(psFilename, PATH_PHOTOUSER);
        } //End public void deleteImage_User()

        //Employee
        public static string setImage_Employee() { return setImage(); } //End public static string setImage_Employee()
        public static string getImage_Employee(string psFilename = null)
        {
            return getImage(psFilename, PATH_PHOTOEMP);
        } //End public static string getEmpPhoto(string psFilename)
        public static string getImage_EmployeeNA()
        {
            return getImageNA(PATH_PHOTOEMP);
        } //End public static string getImage_EmployeeNA(string psFilename)
        public static void saveImage_Employee(HttpPostedFileBase poFileimage, string psFilename)
        {
            saveImage(poFileimage, psFilename, PATH_PHOTOEMP);
        } //End public void EmployeePhoto()
        public static void deleteImage_Employee(string psFilename)
        {
            deleteImage(psFilename, PATH_PHOTOEMP);
        } //End public void EmployeePhoto()

        //Student
        public static string setImage_Student() { return setImage(); } //End public static string setImage_Student()
        public static string getImage_Student(string psFilename = null)
        {
            return getImage(psFilename, PATH_PHOTOSTUDENT);
        } //End public static string getImage_Student(string psFilename = null)
        public static string getImage_StudentNA()
        {
            return getImageNA(PATH_PHOTOSTUDENT);
        } //End public static string getImage_StudentNA()
        public static void saveImage_Student(HttpPostedFileBase poFileimage, string psFilename)
        {
            saveImage(poFileimage, psFilename, PATH_PHOTOSTUDENT);
        } //End public static void saveImage_Student(HttpPostedFileBase poFileimage, string psFilename)
        public static void deleteImage_Student(string psFilename)
        {
            deleteImage(psFilename, PATH_PHOTOSTUDENT);
        } //End public static void deleteImage_Student(string psFilename)

        //Gallery
        public static string setImage_Gallery() { return setImage(); } //End public static string setImage_Gallery()
        public static string getImage_Gallery(string psFilename = null)
        {
            return getImage(psFilename, PATH_PHOTOGALLERY);
        } //End public static string getImage_Gallery(string psFilename = null)
        public static string getImage_GalleryNA()
        {
            return getImageNA(PATH_PHOTOGALLERY);
        } //End public static string getImage_GalleryNA()
        public static void saveImage_Gallery(HttpPostedFileBase poFileimage, string psFilename)
        {
            saveImage(poFileimage, psFilename, PATH_PHOTOGALLERY);
        } //End public static void saveImage_Gallery(HttpPostedFileBase poFileimage, string psFilename)
        public static void deleteImage_Gallery(string psFilename)
        {
            deleteImage(psFilename, PATH_PHOTOGALLERY);
        } //End public static void deleteImage_Gallery(string psFilename)

        //Song
        public static string setImage_Song() { return setImage(); } //End public static string setImage_Song()
        public static string getImage_Song(string psFilename = null)
        {
            return getImage(psFilename, PATH_PHOTOSONG);
        } //End public static string getImage_Song(string psFilename = null)
        public static string getImage_SongNA()
        {
            return getImageNA(PATH_PHOTOSONG);
        } //End public static string getImage_SongNA()
        public static void saveImage_Song(HttpPostedFileBase poFileimage, string psFilename)
        {
            saveImage(poFileimage, psFilename, PATH_PHOTOSTUDENT);
        } //End public static void saveImage_Song(HttpPostedFileBase poFileimage, string psFilename)
        public static void deleteImage_Song(string psFilename)
        {
            deleteImage(psFilename, PATH_PHOTOSONG);
        } //End public static void deleteImage_Song(string psFilename)

        //Product
        public static string setImage_Product() { return setImage(); } //End public static string setImage_Product()
        public static string getImage_Product(string psFilename = null)
        {
            return getImage(psFilename, PATH_PHOTOPRODUCT);
        } //End public static string getImage_Product(string psFilename = null)
        public static string getImage_ProductNA()
        {
            return getImageNA(PATH_PHOTOPRODUCT);
        } //End public static string getImage_ProductNA()
        public static void saveImage_Product(HttpPostedFileBase poFileimage, string psFilename)
        {
            saveImage(poFileimage, psFilename, PATH_PHOTOPRODUCT);
        } //End public static void saveImage_Product(HttpPostedFileBase poFileimage, string psFilename)
        public static void deleteImage_Product(string psFilename)
        {
            deleteImage(psFilename, PATH_PHOTOPRODUCT);
        } //End public static void deleteImage_Product(string psFilename)
    } //End public class Utility_FileUploadDownload
} //End namespace APPBASE.Services