using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class SalesCommandsDeleteCustomer:ISalesCommands
    {
        public void CommandsRealization(/*SalesCommandscommon command*/)
        {
            CrmContext DeletingCustomer = new CrmContext();
            Console.WriteLine("введите Id удаляемого клиента");
            int IdDel = Convert.ToInt32(Console.ReadLine());
            var SalesCommandsDeleteCustomer = DeletingCustomer.Customers.FirstOrDefault(qua => qua.Id == IdDel);
            if (SalesCommandsDeleteCustomer != null)
            {
                DeletingCustomer.Customers.Remove(SalesCommandsDeleteCustomer);
                DeletingCustomer.SaveChanges();
            }
            else Console.WriteLine("не существует такого логина");

        }
    }
}
