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
        public void CommandsRealization(/*AdminCommandscommon command*/)
        {

            Console.WriteLine("введите права доступа создаваемого пользователя(true=admin false=sales)");
            bool root = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Введите имя создаваемого пользователя");
            string name = Console.ReadLine();
            
            Console.WriteLine("введите логин нового пользователя");
            string login = Console.ReadLine();


            Console.WriteLine("введите пароль нового пользователя");
            string password = Console.ReadLine();

            CrmContext CrmCreateUserContext = new CrmContext();
            User usr = new User(root, name, login, password);
           CrmCreateUserContext.Users.Add(usr);
            CrmCreateUserContext.SaveChanges();
            
            
            //foreach (User newusr in quarry)
            //{                                                 //для изменений текущей записи
            //    newusr.Root = root;
            //    newusr.Name = name;
            //    newusr.Login = login;
            //    newusr.Password = password;
            //}
            //CrmCreateUserContext.SaveChanges();

            
        }
    }

}
