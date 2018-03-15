using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;

namespace Hugecrm.Service
{
    class AdminCommandsCreateUser :IAdminCommands
    {
        public Dictionary<string, string> roottypes = new Dictionary<string, string>();

      
        public void CommandsRealization()
        {

            if (roottypes.Count==0)
            {
                roottypes.Add("admin", "admin");
                roottypes.Add("sales", "sales");
                roottypes.Add("analyst", "analyst");
            }

            Console.WriteLine("выберите права доступа создаваемого пользователя(введите admin,sales,analyst)");
            string roottype = Console.ReadLine();
            string root = roottypes[roottype];
            


                Console.WriteLine("Введите имя создаваемого пользователя");
                string name = Console.ReadLine();

                Console.WriteLine("введите логин нового пользователя");
                string login = Console.ReadLine();


                Console.WriteLine("введите пароль нового пользователя");
                string password = Console.ReadLine();

                CrmContext CrmCreateUserContext = new CrmContext();
            if (root != "sales")
            {
                User usr = new User(root, name, login, password);
                CrmCreateUserContext.Users.Add(usr);
                CrmCreateUserContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("введите регион пользователя");
                string _MO = Console.ReadLine();
                Sale usr = new Sale(root, _MO, name, login, password);
                CrmCreateUserContext.Users.Add(usr);
                CrmCreateUserContext.SaveChanges();
            }


        }
    }

}
