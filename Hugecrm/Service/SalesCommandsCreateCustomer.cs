using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class SalesCommandsCreateCustomer:ISalesCommands
    {
        public void CommandsRealization(SalesCommandscommon command)
        {
            CrmContext creatingcustomer = new CrmContext();
            var qarry = creatingcustomer;


        }
    }
}
