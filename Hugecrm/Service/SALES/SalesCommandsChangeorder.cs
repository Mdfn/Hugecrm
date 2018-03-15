using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service.SALES
{
    class SalesCommandsChangeorder : ISalesCommands
    {
        public void CommandsRealization()
        {
            Console.WriteLine("введите Id заказа, подлежащего корректировке");
            var changeorderId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("какое поле меняем у заказа, подлежащего корректировке(true=data,false=amount)?");
            bool polekor = Convert.ToBoolean(Console.ReadLine());
            CrmContext changeorder = new CrmContext();

            var ordertochange = changeorder.Orders.FirstOrDefault(qua => qua.Id == changeorderId);
            if (ordertochange != null)
            {
                if (polekor)
                {
                    DateTime orderchvalue = Convert.ToDateTime(Console.ReadLine());
                    ordertochange.OrderDate = orderchvalue;
                }
                else
                {
                    int prodchvalue = Convert.ToInt32(Console.ReadLine());
                    ordertochange.Amount = prodchvalue;
                }
                changeorder.SaveChanges();
            }
            else Console.WriteLine("Id отсутствует");
        }
    }
}
