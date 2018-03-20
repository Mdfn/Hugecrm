using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class AdmincommandsCreateRegion:IAdminCommands
    {
       
        public void CommandsRealization()
        {
            Console.WriteLine("введите название создаваемого региона");

            string createdreg_nm = Console.ReadLine();

            Region createdreg = new Region(createdreg_nm);

            CrmContext creatingregion = new CrmContext();
            creatingregion.Regions.Add(createdreg);
            creatingregion.SaveChanges();
        }

    }
}
