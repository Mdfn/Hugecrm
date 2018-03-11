using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
using Hugecrm.Service.SALES;
using Hugecrm.Service.ANALYST;
using Hugecrm.Service;

namespace Hugecrm
{
 
    class Program
    {
            
        static void Main(string[] args)
        {
            bool condition = true;

            ICommandLineInterface CLI;

            LoginService Ls = new LoginService();
            User Usr = Ls.LogIndatabase();
            Console.ReadKey();
            if (Usr != null)
            {
                if (Usr.Root == "admin")
                {
                    CLI = new AdminCommandscommon();
                }
                else if (Usr.Root == "sales")
                {
                    CLI = new SalesCommandscommon();
                }
                else if (Usr.Root == "analyst")
                {
                    CLI = new AnalystCommandsCommon();
                }
                else
                {
                    Console.WriteLine("системная ошибка, обратитесь к администратору");
                    CLI = null;
                }
                if (CLI != null) CLI.Dictfilling();

                do
                {

                    CLI.PrintCommands();
                    Console.WriteLine("введите команду");

                    string command = Console.ReadLine();
                    if (command == "exit") condition = false;
                    else CLI.ExecuteCommands(command);
                }
                while (condition);
            }

            string task = "/*1) наиболее продаваемые продукты за интервал 2)наименее продаваемые продукты за интервал*/ 3) какие клиенты приносят наибольшую прибыль за интервал " +
                "4)какие клиенты приносят наименьшую прибыль за интервал Да, и добавь ещё наиболее прибыльные и наименее прибыльные товары за интервал 5) наиболее прибыльные продукты за интервал 6" +
                "6) наименее прибыльные продукты за интервал";
            Console.WriteLine(task);
            Console.ReadKey();
        }
    }
}
