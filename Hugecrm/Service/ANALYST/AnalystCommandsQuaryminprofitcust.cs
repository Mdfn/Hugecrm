using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;

namespace Hugecrm.Service.ANALYST
{
    class AnalystCommandsQuaryminprofitcust : IAnalystCommands
    {
        public void CommandsRealization()
        {

            DateTime sysmindate;
            DateTime sysmaxdate;
            OrgSystem.DT(out sysmindate, out sysmaxdate);
            CrmContext context = new CrmContext();
            Console.WriteLine("enter MO ID, or global");
            int MO_que;

            string quetype = Console.ReadLine();

            Console.WriteLine("enter number of showing entities");
            int nument = Convert.ToInt32(Console.ReadLine());


            var query = (from a in context.Orders
                         where a.OrderDate > sysmindate && a.OrderDate < sysmaxdate
                         group a by a.CustomerId into groupped_cust
                         select new
                         {
                             CustomerId = groupped_cust.Key,

                             Profit = groupped_cust.Sum(_ => _.Bill)
                         });
            if (quetype == "global")
            {
                query = query.OrderBy(_ => _.Profit).Take(nument);
                foreach (var que in query)
                {
                    Console.WriteLine($"ID={que.CustomerId}");
                    Console.WriteLine($"profit=={que.Profit}");
                }
            }
            else
            {
                try
                {
                    MO_que = Int32.Parse(quetype);
                    if (context.Regions.Any(_ => _.Id == MO_que))
                    {
                        var queryreg = (from q in query
                                        join c in context.Customers on q.CustomerId equals c.Id
                                        where c.MO_Id == MO_que
                                        select new
                                        {
                                            cus = q.CustomerId,
                                            MO = c.MO_Id,
                                            pro = q.Profit
                                        }).OrderBy(_ => _.pro).Take(nument);
                        foreach (var q in queryreg)
                        {
                            Console.WriteLine($"ID={q.cus}");
                            Console.WriteLine($"profit=={q.pro}");
                            Console.WriteLine($"MO={q.MO}");


                        }
                    }
                    else
                        Console.WriteLine("region with such Id does not exist");
                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid data , enter numbers");
                    Console.WriteLine(e.Message);
                }



            }

        }
    }
}