using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using APPBASE.Helpers;
using APPBASE.Models;

namespace APPBASE.Models
{
    #region Default Context Area
        public partial class DBMAINContext : DbContext
        {
            //LOV - Bloodtype
            public DbSet<Bloodtype> Bloodtypes { get; set; }
            //LOV - Education
            public DbSet<Education> Educations { get; set; }
            //LOV - Gender
            public DbSet<Gender> Genders { get; set; }
            //LOV - Jobtype
            public DbSet<Jobtype> Jobtypes { get; set; }
            //LOV - Religion
            public DbSet<Religion> Religions { get; set; }
            //LOV - Marital
            public DbSet<Marital> Maritals { get; set; }
            //LOV - Emplsts
            public DbSet<Emplsts> Emplstss { get; set; }
            //LOV - Jobtitle
            public DbSet<Jobtitle> Jobtitles { get; set; }
            //LOV - Incometype
            public DbSet<Incometype> Incometypes { get; set; }
            //City
            public DbSet<City> Citys { get; set; }
            //Empmutationsts
            public DbSet<Empmutationsts> Empmutationstss { get; set; }
            //Attendance
            public DbSet<Attendance> Attendances { get; set; }
        } //End public class DBMAINContext : DbContext
    #endregion
} //End namespace APPBASE.Models