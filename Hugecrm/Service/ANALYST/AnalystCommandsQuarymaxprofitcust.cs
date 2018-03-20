using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
using Hugecrm.Service;
namespace Hugecrm.Service.ANALYST
{
    class AnalystCommandsQuarymaxprofitcust : IAnalystCommands
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
                query = query.OrderByDescending(_ => _.Profit).Take(nument);
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
                                        }).OrderByDescending(_ => _.pro).Take(nument);
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

                //var query = (from a in context.Orders
                //             join z in context.Customers on a.CustomerId equals z.Id into joen

                //             where a.OrderDate > sysmindate && a.OrderDate < sysmaxdate
                //             where 
                //             select new
                //             {
                //                from joen(_=>_)
                //                where 

                //             }
                /*.OrderBy(_ => _.Profit).Take(nument)*/
                
            //var query2 = (from q in query
            //              join c in context.Customers on q.CustomerId equals c.Id
            //              where c.MO_Id == MO_que
            //              select new
            //              {
            //                  cus = q.CustomerId,
            //                  MO = c.MO_Id,
            //                  pro = q.Profit
            //              }).OrderByDescending(_ => _.pro).Take(nument);
            //foreach (var que in query2)
            //{
            //    Console.WriteLine($"customer Id=={ que.cus}");
            //    Console.WriteLine($"customer profit=={ que.pro}");
            //    Console.WriteLine($"customer MO={ que.MO}");


            //}
            //query.Take(nument);




            ////////////свежая попытка
            //////var query = from a in context.Customers
            //////            group a by a.Id into groupped_cust

            //////            join b in context.Orders on groupped_cust.Key equals b.CustomerId
            //////            where /*a.MO_Id == MO_que && */b.OrderDate > sysmindate && b.OrderDate < sysmaxdate
            //////            select new
            //////            {
            //////                CustomerId = groupped_cust.Key,
            //////                u2=groupped_cust.(_=_.MO_Id),
            //////                Profit = b.Bill.
            ////// };
            //////var query2 = (from x in query
            //////              group x by x.Id into resultexact
            //////              select new
            //////              {
            //////                  CustomerId = resultexact.Key,

            //////                  Profit = resultexact.Sum(_ => _.Bill)
            //////              }).OrderByDescending(o => o.Profit).Take(nument);


            //////foreach (var que in query2)
            //////{
            //////    Console.WriteLine($"customer Id=={ que.CustomerId}");

            //////}
            //group a by a.CustomerId into groupped_cust join z in context.Customers on groupped_cust.(_=>_.CustomerId) equals z.Id
            //select new
            //{
            //    CustomerId = groupped_cust.Key,

            //    Profit = groupped_cust.Where(.Sum(_ => _.Bill)
            //}).OrderByDescending(_ => _.Profit).Take(5);
            //var query2 = from q in query
            //             join r in context.Customers on q.CustomerId equals r.Id
            //             join z in context.Regions on r.MO_Id equals z.Id
            //             select new
            //             {
            //                 ord = q.CustomerId,
            //                 cust = r.Id,
            //                 reg=z.Id

            //             };
            //var query3 = (from sel in query2
            //             where sel.reg == i
            //             select new
            //             {
            //                 CustomerId=sel.cust,
            //                 wprofit=sel(_=>_.)
            //             }

            //             );
            //foreach (var qua in query3)
            //{
            //    Console.WriteLine("gutted");
            //    Console.WriteLine($"{qua.CustomerId}); ");  /*/*000amount{qua.profit}*/


            //}
            Console.ReadKey();


            //query.Join(context.Customers,
            //q => q.CustomerId,
            //p => p.Id,
            //(p, q) => new
            //{
            //    order = q.Id,
            //    customer = p.CustomerId,
            //    MO =p. 
            //}
            //);
            //var query3=from qq in query2
            //           where qq.


        }
    }
}
