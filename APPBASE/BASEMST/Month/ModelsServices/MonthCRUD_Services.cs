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
using APPBASE.Svcapp;
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public class MonthCRUD
    {
        private DBMAINContext db;
        private Month oModel;
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor 1
        public MonthCRUD() { this.db = new DBMAINContext(); } //End public MonthCRUD()
        //Constructor 2
        public MonthCRUD(DBMAINContext poDB)
        { this.db = poDB; } //End public MonthCRUD()

        public void Create(MonthVM poViewModel)
        {
            try
            {
                this.oModel = new Month();
                //Map Form Data
                this.oModel.InjectFrom(poViewModel);
                //Set Field Header
                this.oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                //Set DTA_STS
                //this.oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                //Process CRUD
                this.db.Months.Add(this.oModel);
                //this.db.SaveChanges();
                //this.ID = this.oModel.ID;
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(MonthVM poViewModel)
        {
            try
            {
                this.oModel = this.db.Months.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                //Map Form Data
                this.oModel.InjectFrom(poViewModel);
                //Set Field Header
                this.oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                //Set DTA_STS
                //this.oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                //Process CRUD
                this.db.Entry(this.oModel).State = EntityState.Modified;
                //this.db.SaveChanges();
                //this.ID = this.oModel.ID;
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update
        public void Delete(int? id)
        {
            try
            {
                this.oModel = this.db.Months.Find(id);
                this.db.Months.Remove(this.oModel);
                //this.db.SaveChanges();
                //this.ID = this.oModel.ID;
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete
        public void Commit()
        {
            this.db.SaveChanges();
            this.ID = this.oModel.ID;
        } //End public void Commit()
    } //End public class MonthCRUD
} //End namespace APPBASE.Models
