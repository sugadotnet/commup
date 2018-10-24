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
    public class JobtitleDS
    {
        //Constructor
        public JobtitleDS() { } //End public JobtitleDS
        public List<JobtitlelistVM> getDatalist()
        {
            List<JobtitlelistVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Jobtitles
                           select new JobtitlelistVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<JobtitlelistVM> getDatalist()
        public JobtitledetailVM getData(int? id = null)
        {
            JobtitledetailVM oReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Jobtitles
                           where tb.ID == id
                           select new JobtitledetailVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                oReturn = oQRY.SingleOrDefault();
            } //End using (var = new DbContext())
            return oReturn;
        } //End public JobtitledetailVM getData(int? id = null)


        public List<JobtitlelookupVM> getDatalist_lookup()
        {
            List<JobtitlelookupVM> vReturn;


            using (var db = new DBMAINContext())
            {
                var oQRY = from tb in db.Jobtitles
                           select new JobtitlelookupVM
                           {
                               ID = tb.ID,
                               LOV_DESC = tb.LOV_DESC
                           };
                vReturn = oQRY.ToList();
            } //End using (var = new DbContext())
            return vReturn;
        } //End public List<JobtitlelookupVM> getDatalist_lookup()
    } //End public class JobtitleDS
} //End namespace APPBASE.Models

