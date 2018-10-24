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
    public partial class DBMAINContext : DbContext
    {
        public DbSet<Summary_sell_info> Summary_sell_infos { get; set; }
    } //End public class DBMAINContext : DbContext
} //End namespace APPBASE.Models