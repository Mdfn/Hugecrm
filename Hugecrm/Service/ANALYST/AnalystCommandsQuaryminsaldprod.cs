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
            string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};

            Console.WriteLine("введите дату ОТ");
            string mindate = Console.ReadLine();
            Console.WriteLine("введите дату ДО");
            string maxdate = Console.ReadLine();
            DateTime sysmindate;
            DateTime sysmaxdate;
            sysmindate = DateTime.Parse(mindate);
            sysmaxdate = DateTime.Parse(maxdate);
            CrmContext context = new CrmContext();
            var query = (from a in context.Orders
                         join b in context.Products on a.ProductId equals b.Id
                         orderby a.Amount 
                         where a.OrderDate < sysmaxdate && a.OrderDate > sysmindate
                         select a.Amount).Take(5);




        }
    }
}
