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
    public class TrnstockdCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }

        //Constructor
        public TrnstockdCRUD() { } //End public TrnstockdCRUD()
        public void Create(TrnstockdVM poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Trnstockd oModel = new Trnstockd();
                    //Map Form Data
                    oModel.InjectFrom(poViewModel);
                    //Set Field Header
                    oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                    //Set DTA_STS
                    oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                    //Process CRUD
                    db.Trnstockds.Add(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(TrnstockdVM poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Trnstockd oModel = db.Trnstockds.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
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
        public void Delete(int? id)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    Trnstockd oModel = db.Trnstockds.Find(id);
                    db.Trnstockds.Remove(oModel);
                    db.SaveChanges();
                    this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete


        public void Create(List<TrnstockdVM> poViewModel)
        {
            try
            {
                using (var db = new DBMAINContext())
                {
                    foreach (var item in poViewModel)
                    {
                        Trnstockd oModel = new Trnstockd();
                        //Map Form Data
                        oModel.InjectFrom(item);
                        //Set Field Header
                        oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                        //Set DTA_STS
                        oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                        //Process CRUD
                        db.Trnstockds.Add(oModel);
                    } //End foreach (var item in poViewModel)
                    db.SaveChanges();
                    //this.ID = oModel.ID;
                } //End using
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
    } //End public class TrnstockdCRUD
} //End namespace APPBASE.Models
