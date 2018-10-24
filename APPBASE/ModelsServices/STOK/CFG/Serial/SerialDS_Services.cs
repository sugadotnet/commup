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
    public class SerialDS
    {
        //Constructor
        public SerialDS() { } //End public SerialDS
        public List<SerialVM> getDatalist(int? id=null)
        {
            List<SerialVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Serial_infos
                           select new SerialVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               SERIAL_CODE = tb.SERIAL_CODE,
                               SERIAL_NAME = tb.SERIAL_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                if (id != null) oQRY = oQRY.Where(fld => fld.PRODTYPE_ID == id);
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<SeriallistVM> getDatalist()
        public SerialVM getData(int? id = null)
        {
            SerialVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Serial_infos
                           where tb.ID == id
                           select new SerialVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               SERIAL_CODE = tb.SERIAL_CODE,
                               SERIAL_NAME = tb.SERIAL_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public SerialdetailVM getData(int? id = null)


        public List<SerialVM> getDatalist_lookup(int? ProdTypeId=null)
        {
            List<SerialVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Serial_infos
                           select new SerialVM
                           {
                               ID = tb.ID,
                               DTA_STS = tb.DTA_STS,
                               SERIAL_CODE = tb.SERIAL_CODE,
                               SERIAL_NAME = tb.SERIAL_NAME,
                               PRODTYPE_ID = tb.PRODTYPE_ID,
                               PRODTYPE_CODE = tb.PRODTYPE_CODE,
                               PRODTYPE_NAME = tb.PRODTYPE_NAME
                           };
                if (ProdTypeId != null) oQRY = oQRY.Where(fld => fld.PRODTYPE_ID == ProdTypeId);
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<SeriallookupVM> getDatalist_lookup()
    } //End public class SerialDS
} //End namespace APPBASE.Models
