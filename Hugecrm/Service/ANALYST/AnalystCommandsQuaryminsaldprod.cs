using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service.ANALYST
{
    class AnalystCommandsQuaryminsaldprod:IAnalystCommands
    {
        public void CommandsRealization()
        {
            DateTime sysmindate;
            DateTime sysmaxdate;
            OrgSystem.DT(out sysmindate, out sysmaxdate);
            CrmContext context = new CrmContext();
            var query = (from a in context.Orders
                         where a.OrderDate < sysmaxdate && a.OrderDate > sysmindate
                         group a by a.ProductId into grouppedProds
                         select new { Product = grouppedProds.Key, Amount = grouppedProds.Sum(_ => _.Amount) }).ToList().OrderBy(_ => _.Amount).Take(5);
                         

            if (query != null)
            {
                foreach (var qq in query)

                {
                    Console.WriteLine($"{qq.Product}==amount=={qq.Amount}");
                }
            }
            else Console.WriteLine("нет данных удовлетворяющих запросу");

            
        }
    }
}
