using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class SalesCommandsMakeOrder:ISalesCommands

    {
        public void CommandsRealization()
        {
            CrmContext Makingorder = new CrmContext();
            Console.WriteLine("введите Id клиента для создания заказа");
            var tempid = Convert.ToInt32(Console.ReadLine());
            bool condition = true;
            do
            {
                
                Console.WriteLine("введите id продукта");
                var product = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine ("введите количество продукта");
                var amount = Convert.ToInt32(Console.ReadLine());
                var order = new Order(tempid, product,amount);
                var prod_ = Makingorder.Products.FirstOrDefault(_ => _.Id == product);
                order.Bill =  prod_.Price * amount;
                Makingorder.Orders.Add(order);
                Makingorder.SaveChanges();
                Console.WriteLine("введите exit для окончания формирования заказа или нажмите enter для продолжения");
                var cond = Console.ReadLine();
                if (cond == "exit") condition = false;
            }
            while (condition);
            
            
        }
    }
}
