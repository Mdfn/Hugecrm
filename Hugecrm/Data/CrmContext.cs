using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
    public class CrmContext:DbContext
    {
        public CrmContext() : base("Crmconnectionstring")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CrmContext,CrmContextConfiguration>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CrmContext>().
        //        Property(p=>p.Orders)
        //        .HasColumnType("datetime2")
        //        .HasPrecision(0)
        //        .IsRequired();
        //}
    }
}
