using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Connection360.Web.Models
{
    public class BrandModuleContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Sku> Skus { get; set; }
        public DbSet<BrandSkuMap> BrandSkuMaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Connection360.Web.ViewModel.AddViewModel> AddViewModels { get; set; }
    }
}