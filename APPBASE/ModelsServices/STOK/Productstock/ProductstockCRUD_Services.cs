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
using Omu.ValueInjecter;

namespace APPBASE.Models
{
    public class ProductstockCRUD
    {
        private DBMAINContext db;
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor 1
        public ProductstockCRUD() { this.db = new DBMAINContext(); } //End public ProductstockCRUD()
        //Constructor 2
        public ProductstockCRUD(DBMAINContext poDBMAINContext) {
            this.db = poDBMAINContext;
        } //End public ProductstockDS(DBMAINContext poDBMAINContext)
        public void Create(ProductstockVM poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Productstock oModel = new Productstock();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                    //Process CRUD
                    db.Productstocks.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Create(List<ProductstockVM> poViewModel)
        {
            try
            {
                foreach (var item in poViewModel)
                {
                    Productstock oModel = new Productstock();
                    //Map Form Data
                    oModel.InjectFrom(item);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                    //Process CRUD
                    this.db.Productstocks.Add(oModel);
                } //End foreach (var item in poViewModel)
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Update

        public void Update(ProductstockVM poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Productstock oModel = db.Productstocks.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
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
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update
        public void Update(List<ProductstockVM> poViewModel)
        {
            try
            {
                foreach (var item in poViewModel)
                {
                    Productstock oModel = this.db.Productstocks.AsNoTracking().SingleOrDefault(fld => fld.ID == item.ID);
                    //Map Form Data
                    oModel.InjectFrom(item);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                    //Process CRUD
                    this.db.Entry(oModel).State = EntityState.Modified;
                } //End foreach (var item in poViewModel)
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update

        public void Delete(int? id)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Productstock oModel = db.Productstocks.Find(id);
                    db.Productstocks.Remove(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete

        public void Commit() {
            this.db.SaveChanges();
        } //End public void Commit()
    } //End public class ProductstockCRUD
} //End namespace APPBASE.Models
