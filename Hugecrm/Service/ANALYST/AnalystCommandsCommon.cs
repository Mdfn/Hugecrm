using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Service.ANALYST;
namespace Hugecrm.Service
{
    class AnalystCommandsCommon:ICommandLineInterface

    {
        Dictionary<string, IAnalystCommands> analdic = new Dictionary<string, IAnalystCommands>();
        public void PrintCommands()
        {
            foreach (string key in analdic.Keys)
            {
                Console.WriteLine(key);
            }
        }
        public void ExecuteCommands(string command)
        {
            analdic[command].CommandsRealization();
            

        }

        public void Dictfilling()
        {
            AnalystCommandsQuarymaxsaldprod maxsaldprod = new AnalystCommandsQuarymaxsaldprod();
            AnalystCommandsQuaryminsaldprod minsaldprod = new AnalystCommandsQuaryminsaldprod();
            AnalystCommandsQuarymaxprofitcust maxprofitcust = new AnalystCommandsQuarymaxprofitcust();
            AnalystCommandsQuaryminprofitcust minprofitcust = new AnalystCommandsQuaryminprofitcust();
            AnalystCommandsQuarymaxprofitdprod maxprofitdprod = new AnalystCommandsQuarymaxprofitdprod();
            AnalystCommandsQuaryminprofitprod minprofitprod = new AnalystCommandsQuaryminprofitprod();

            analdic.Add("show max saled product", maxsaldprod);
            analdic.Add("show min saled product", minsaldprod);
            analdic.Add("show max profitable customer", maxprofitcust);
            analdic.Add("show min profitable customer", minprofitcust);
            analdic.Add("max profitable product", maxprofitdprod);
            analdic.Add("min profitable product", minprofitprod);

        }
    }
}
