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
        Dictionary<string, string> description = new Dictionary<string, string>();
        public void PrintCommands()
        {

            foreach (string key in description.Keys)
            {
            
                Console.WriteLine("{0},{1}",key,description[key]);
            }
        }
        public void ExecuteCommands(string command)
        {
            try
            {
                analdic[command].CommandsRealization();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Dictfilling()
        {
            AnalystCommandsQuarymaxsaldprod maxsaldprod = new AnalystCommandsQuarymaxsaldprod();
            AnalystCommandsQuaryminsaldprod minsaldprod = new AnalystCommandsQuaryminsaldprod();
            AnalystCommandsQuarymaxprofitcust maxprofitcust = new AnalystCommandsQuarymaxprofitcust();
            AnalystCommandsQuaryminprofitcust minprofitcust = new AnalystCommandsQuaryminprofitcust();
            AnalystCommandsQuarymaxprofitdprod maxprofitdprod = new AnalystCommandsQuarymaxprofitdprod();
            AnalystCommandsQuaryminprofitprod minprofitprod = new AnalystCommandsQuaryminprofitprod();
            description.Add("show max saled product", "1");
            description.Add("show min saled product", "2");
            description.Add("show max profitable customer", "3");
            description.Add("show min profitable customer", "4");
            description.Add("max profitable product", "5");
            description.Add("min profitable product", "6");

            analdic.Add("1", maxsaldprod);
            analdic.Add("2", minsaldprod);
            analdic.Add("3", maxprofitcust);
            analdic.Add("4", minprofitcust);
            analdic.Add("5", maxprofitdprod);
            analdic.Add("6", minprofitprod);

        }
    }
}
