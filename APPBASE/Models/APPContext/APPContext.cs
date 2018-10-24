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
            //public DBMAINContext() : base(hlpDBMS.getStrConn()) //Use this line for next code (Production)
            public DBMAINContext() : base("DefaultConnection") //Use this line for First create Scaffold (Development)
            {
                Database.SetInitializer<DBMAINContext>(null);
            } //End public DBMAINContext() :base(hlpDBMS.getStrConn())
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            } //End protected override void OnModelCreating(DbModelBuilder modelBuilder)
        } //End public class DBMAINContext : DbContext
    #endregion
} //End namespace APPBASE.Models