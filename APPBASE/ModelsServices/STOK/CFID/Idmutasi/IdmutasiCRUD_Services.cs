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
    public class IdmutasiCRUD
    {
        public int? ID { get; set; }
        public Boolean isERR { get; set; }
        public string ERRMSG { get; set; }
        private DBMAINContext db;
        private Idmutasi oModel;

        //Constructor 1
        public IdmutasiCRUD() { } //End public IdmutasiCRUD()
        //Constructor 1
        public IdmutasiCRUD(DBMAINContext poDB) {
            if (poDB == null) this.db = new DBMAINContext();
            else this.db = poDB;
        } //End public IdmutasiCRUD()

        public void Create(IdmutasiVM poViewModel)
        {
            try
            {
                oModel = new Idmutasi();
                //Map Form Data
                oModel.InjectFrom(poViewModel);
                //Set Field Header
                oModel.setFIELD_HEADER(hlpFlags_CRUDOption.CREATE);
                //Set DTA_STS
                oModel.DTA_STS = valFLAG.FLAG_DTA_STS_CREATE;
                //Process CRUD
                this.db.Idmutasis.Add(oModel);
                this.db.SaveChanges();
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Create: " + e.Message; } //End catch
        } //End public void Create
        public void Update(IdmutasiVM poViewModel)
        {
            try
            {
                oModel = null;
                oModel = this.db.Idmutasis.AsNoTracking().SingleOrDefault(fld => fld.ID == poViewModel.ID);
                //Map Form Data
                oModel.InjectFrom(poViewModel);
                //Set Field Header
                oModel.setFIELD_HEADER(hlpFlags_CRUDOption.UPDATE);
                //Set DTA_STS
                oModel.DTA_STS = valFLAG.FLAG_DTA_STS_UPDATE;
                //Process CRUD
                this.db.Entry(oModel).State = EntityState.Modified;
                this.db.SaveChanges();
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Update" + e.Message; } //End catch
        } //End public void Update
        public void Delete(int? id)
        {
            try
            {
                Idmutasi oModel = db.Idmutasis.Find(id);
                this.db.Idmutasis.Remove(oModel);
                this.db.SaveChanges();
            } //End try
            catch (Exception e) { isERR = true; this.ERRMSG = "CRUD - Delete" + e.Message; } //End catch
        } //End public void Delete

        public void Commit()
        {
            this.db.SaveChanges();
            this.ID = oModel.ID;
        } //End public void Commit()
    } //End public class IdmutasiCRUD
} //End namespace APPBASE.Models
