using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Service
{
    /// <summary>
    /// Моё мега крутое изменение в исходном коде :)
    /// </summary>
    class AdminCommandscommon:ICommandLineInterface
    {
     public Dictionary<string, IAdminCommands> admindic = new Dictionary<string, IAdminCommands>();
      


        public void Dictfilling()
        {
            AdminCommandsCreateUser createuser = new AdminCommandsCreateUser();
            AdminCommandsDeleteUser deleteuser = new AdminCommandsDeleteUser();
            AdmincommandsCreateRegion createregion = new AdmincommandsCreateRegion();

            admindic.Add("create user", createuser);
            admindic.Add("delete user", deleteuser);
            admindic.Add("create region", createregion);
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

                  
                        admindic[key].CommandsRealization();

                    
                }
            }

        }



    }
}
