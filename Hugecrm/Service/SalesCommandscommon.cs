using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Service
{
    class SalesCommandscommon:ICommandLineInterface

    {
        Dictionary<string, SalesCommandscommon> salesdic = new Dictionary<string, SalesCommandscommon>();
        public void Dictfilling()
        {
            SalesCommandscommon needsomepersonalclaassandcommand = new SalesCommandscommon();
            SalesCommandscommon needsomepersonalclaassandcommand2 = new SalesCommandscommon();
            salesdic.Add("somecommand", needsomepersonalclaassandcommand);
            salesdic.Add("somecommand2", needsomepersonalclaassandcommand2);
        }

        public void PrintCommands()
        {
            foreach (string key in salesdic.Keys)
            {
                Console.WriteLine(key);
            }

        }
        public void ExecuteCommands(string commands)
        {


        }

    }
}
