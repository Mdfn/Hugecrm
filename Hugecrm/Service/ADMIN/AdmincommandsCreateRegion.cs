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
             
            Region createdreg = new Region();

            CrmContext creatingregion = new CrmContext();
            Console.WriteLine("введите название создаваемого региона");
            createdreg.Name = Console.ReadLine();
            creatingregion.Regions.Add(createdreg);
            creatingregion.SaveChanges();
        }

    }
}
