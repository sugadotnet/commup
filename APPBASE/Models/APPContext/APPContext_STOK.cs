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
            //Employee
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Employee_info> Employee_infos { get; set; }

            //Storage
            public DbSet<Storage> Storages { get; set; }
            public DbSet<Storage_info> Storage_infos { get; set; }

            //Countrycode
            public DbSet<Countrycode> Countrycodes { get; set; }
            public DbSet<Countrycode_info> Countrycode_infos { get; set; }
            //Finishing
            public DbSet<Finishing> Finishings { get; set; }
            public DbSet<Finishing_info> Finishing_infos { get; set; }
            //Prodsubtype
            public DbSet<Prodsubtype> Prodsubtypes { get; set; }
            public DbSet<Prodsubtype_info> Prodsubtype_infos { get; set; }
            //Prodtype
            public DbSet<Prodtype> Prodtypes { get; set; }
            public DbSet<Prodtype_info> Prodtype_infos { get; set; }
            //Serial
            public DbSet<Serial> Serials { get; set; }
            public DbSet<Serial_info> Serial_infos { get; set; }
            //Ukuran
            public DbSet<Ukuran> Ukurans { get; set; }
            public DbSet<Ukuran_info> Ukuran_infos { get; set; }
            //Vendor
            public DbSet<Vendor> Vendors { get; set; }
            public DbSet<Vendor_info> Vendor_infos { get; set; }

            //Product
            public DbSet<Product> Products { get; set; }
            public DbSet<Product_info> Product_infos { get; set; }

            //Productnew
            public DbSet<Productnew> Productnews { get; set; }
            public DbSet<Productnew_info> Productnew_infos { get; set; }

            //Productstock
            public DbSet<Productstock> Productstocks { get; set; }
            public DbSet<Productstock_info> Productstock_infos { get; set; }

            //Trnstock
            public DbSet<Trnstock> Trnstocks { get; set; }
            public DbSet<Trnstock_info> Trnstock_infos { get; set; }

            //Trnstockd
            public DbSet<Trnstockd> Trnstockds { get; set; }
            public DbSet<Trnstockd_info> Trnstockd_infos { get; set; }

        } //End public class DBMAINContext : DbContext
    #endregion
} //End namespace APPBASE.Models