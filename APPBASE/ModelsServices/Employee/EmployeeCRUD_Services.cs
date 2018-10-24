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
    public class EmployeeCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor
        public EmployeeCRUD() { } //End public EmployeeCRUD()
        public void Create(EmployeedetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Employee oModel = new Employee();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Set Image file name
                    if (poFileimage != null) { oModel.EMPLOYEE_IMG = Utility_FileUploadDownload.setImage_Employee(); } //End if (poFileimage != null)
                    
                    //Process CRUD
                    db.Employees.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                    { Utility_FileUploadDownload.saveImage_Employee(poFileimage, oModel.EMPLOYEE_IMG); } //End if (poFileimage != null)
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(EmployeedetailVM poViewModel, HttpPostedFileBase poFileimage = null)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Employee oModel = db.Employees.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //Set Image file name
                    if (poFileimage != null) { if ((oModel.EMPLOYEE_IMG == null) || (oModel.EMPLOYEE_IMG == "")) { oModel.EMPLOYEE_IMG = Utility_FileUploadDownload.setImage_Employee(); } } //End if (poFileimage != null)
                    //Process CRUD
                    db.Entry(oModel).State = EntityState.Modified;
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Save file
                    if (poFileimage != null)
                    {
                        Utility_FileUploadDownload.saveImage_Employee(poFileimage, oModel.EMPLOYEE_IMG);
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
                    Employee oModel = db.Employees.Find(id);
                    db.Employees.Remove(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;

                    //Delete Image file name
                    Utility_FileUploadDownload.deleteImage_Employee(oModel.EMPLOYEE_IMG);
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete
    } //End public class EmployeeCRUD
} //End namespace APPBASE.Models

