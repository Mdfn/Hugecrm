using System.Data.Entity.Migrations;

namespace Hugecrm.Data
{
    public class CrmContextConfiguration : DbMigrationsConfiguration<CrmContext>
    {
        public CrmContextConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}