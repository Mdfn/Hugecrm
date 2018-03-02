using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Service
{
    interface ICommandLineInterface
    {
        void PrintCommands();
        void ExecuteCommands(string command);
        void Dictfilling();
    }
}
