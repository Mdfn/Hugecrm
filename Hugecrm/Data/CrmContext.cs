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
        public DbSet<CLient> Clients { get; set; }
    }
}
