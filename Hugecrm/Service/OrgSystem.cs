using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Service
{
   public static class OrgSystem
    {
        public static void DT(out DateTime first, out DateTime second)
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
          
            first = DateTime.Parse(mindate);
            second = DateTime.Parse(maxdate);

        }


    }
}
