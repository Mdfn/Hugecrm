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
            //User AM = new User("admin", "upppr", "Admin", "123");
            //CrmContext test = new CrmContext();
            ////string str = "tyty";
            ////var quArry = test.Orders.FirstOrDefault(u => u.Id.Equals(str));
            //test.Users.Add(AM);
            //test.SaveChanges();
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
                if (CLI != null)
                {
                    CLI.Dictfilling();
                }
                Sale saveid = (Sale)Usr;
                OrgSystem.saveusrsales.Add(saveid);
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
            else Console.WriteLine("...");
            string task = "Заказчик вводит регионы.Каждый кастомер принадлежит какому то региону.Регионы заводит админ, Сотрудник(сейл) принадлежит к региону," +
                "Добавляемые им кастомеры принадлежат региону сотрудника.Запросы аналитика теперь меняются таким образом - либо глобальные, либо по региону";
            string bugstrac= "количество известных ошибок = 0";
            string bugs = "/*ошибка 1 - поиск комманд и продуктов для удаления в Сэйл коммандс идет по айди, а везде используется GUID */ FIXED, ошибка 2 ==" +
             "/*при двойном подряд создании юзера Админом выдается ошибка неуникального словаря Админа*/ FIXED";
            
            Console.WriteLine(task);
            Console.WriteLine(bugstrac);
            Console.WriteLine(bugs);

            Console.ReadKey();
        }
    }
}
