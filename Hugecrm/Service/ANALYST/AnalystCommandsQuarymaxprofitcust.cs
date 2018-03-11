using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
using Hugecrm.Service;
namespace Hugecrm.Service.ANALYST
{
    class AnalystCommandsQuarymaxprofitcust:IAnalystCommands
    {

        public void CommandsRealization()
        {

            DateTime sysmindate;
            DateTime sysmaxdate;
            OrgSystem.DT(out sysmindate, out sysmaxdate);
            CrmContext context = new CrmContext();
            var query = (from a in context.Orders
                         where a.OrderDate > sysmindate && a.OrderDate < sysmaxdate
                         group a by a.CustomerId into groupped_cust
                         select new
                         {
                             CustomerId = groupped_cust.Key,

                             Profit = groupped_cust.Sum(_ => _.Bill)
                         }).OrderByDescending(_ => _.Profit).Take(5);
            if (query != null)
            {
                foreach (var qq in query)

                {
                    Console.WriteLine($"{qq.CustomerId}==amount=={qq.Profit}");
                }
            }
            else Console.WriteLine("нет данных удовлетворяющих запросу");
        }
    }
}
