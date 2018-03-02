using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Service
{
    class AdminCommandscommon:ICommandLineInterface
    {
     public Dictionary<string, IAdminCommands> admindic = new Dictionary<string, IAdminCommands>();
      


        public void Dictfilling()
        {
            AdminCommandsCreateUser createuser = new AdminCommandsCreateUser();
            AdminCommandsDeleteUser deleteuser = new AdminCommandsDeleteUser();
            AdminCommandsDeleteUser createcommand = new AdminCommandsDeleteUser();

            admindic.Add("create user", createuser);
            admindic.Add("delete user", deleteuser);
            admindic.Add("create command", createcommand);

        }


        public  void PrintCommands()
        {
            foreach (string key in admindic.Keys)
            {
                Console.WriteLine(key);
            }
        

        }
        public void ExecuteCommands(string command)
        {
            foreach (string key in admindic.Keys)
            {
                if (command == key)
                {
                    AdminCommandscommon cmd = new AdminCommandscommon(); 
                        admindic[key].CommandsRealization(cmd);
                }
            }

        }



    }
}
