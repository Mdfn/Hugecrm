﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("Crmconnectionstring")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CrmContext, CrmContextConfiguration>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Region> Regions { get; set; }
        //public DbSet<Sale> Sales { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //    .Map(m =>
        //    {
        //        m.MapInheritedProperties();
        //        m.ToTable("Users");
        //    });
        //    modelBuilder.Entity<Sale>().Map(m =>
        //    {
        //        m.MapInheritedProperties();
        //        m.ToTable("Sales");
        //    });
        //}
    }
}
