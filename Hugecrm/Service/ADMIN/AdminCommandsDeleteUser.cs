using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
using System.Data.Entity;

namespace Hugecrm.Service
{
    class AdminCommandsDeleteUser:IAdminCommands
    {
        
        public void CommandsRealization(/*AdminCommandscommon command*/)
        {
            CrmContext Deletingcommand = new CrmContext();
            Console.WriteLine("введите логин пользователя , подлежащего удалению");
            string dellogin = Console.ReadLine();
            var usertodelete = Deletingcommand.Users.FirstOrDefault(qua => qua.Login.Equals(dellogin));
            if (usertodelete != null)
            {
                Deletingcommand.Users.Remove(usertodelete);
                Deletingcommand.SaveChanges();
            }
            else Console.WriteLine("такого логина не существует");


        }




    }
}
