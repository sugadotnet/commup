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
            //CFG - Branch
            public DbSet<Branch> Branchs { get; set; }
            public DbSet<Branch_info> Branch_infos { get; set; }
            public DbSet<BranchHQ_info> BranchHQ_infos { get; set; }
            public DbSet<Branchall_info> Branchall_infos { get; set; }
            //CFG - Photogallery
            public DbSet<Photogallery> Photogallerys { get; set; }
        } //End public class DBMAINContext : DbContext
    #endregion
} //End namespace APPBASE.Models