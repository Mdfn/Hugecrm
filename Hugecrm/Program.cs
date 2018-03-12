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

            string task = "Заказчик вводит регионы.Каждый кастомер принадлежит какому то региону.Регионы заводит админ, Сотрудник(сейл) принадлежит к региону," +
                "Добавляемые им кастомеры принадлежат региону сотрудника.Запросы аналитика теперь меняются таким образом - либо глобальные, либо по региону";
            Console.WriteLine(task);
            Console.ReadKey();
        }
    }
}
