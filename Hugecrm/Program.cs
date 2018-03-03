using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
using Hugecrm.Service;

namespace Hugecrm
{
 
    class Program
    {
            
        static void Main(string[] args)
        {
            bool condition = true;

            ICommandLineInterface CLI;
            //SalesCommandscommon sls = new SalesCommandscommon();

            LoginService Ls = new LoginService();
            User Usr = Ls.LogIndatabase();
            if (Usr.Root)
                CLI = new AdminCommandscommon();
            else CLI = new SalesCommandscommon();
            CLI.Dictfilling();
            do
            {
                CLI.PrintCommands();
                Console.WriteLine("введите команду");
                Console.WriteLine(CLI.GetType());

                string command = Console.ReadLine();
                if (command == "exit") condition = false;
                else CLI.ExecuteCommands(command);
            }
            while (condition);

            //AdminCommandsDelete test = new AdminCommandsDelete();
            //   test.CommandsRealization(adm);
            Console.ReadKey();
        }
    }
}
