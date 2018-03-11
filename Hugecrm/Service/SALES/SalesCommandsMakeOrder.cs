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
            string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};

       
            DateTime datetime;

            CrmContext Makingorder = new CrmContext();
            Console.WriteLine("введите Id клиента для создания заказа");
            var tempid = Convert.ToInt32(Console.ReadLine());
            bool condition = true;
            do
            {

                Console.WriteLine("введите id продукта");
                var product = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите количество продукта");
                var amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите дату и время");
                string userDTentry = Console.ReadLine();
                datetime = DateTime.Parse(userDTentry);

                var order = new Order(tempid, product, amount, datetime);
                Console.WriteLine($"hehehehehhe{order.OrderDate}");
                Console.ReadKey();
                var prod_ = Makingorder.Products.FirstOrDefault(_ => _.Id == product);
                order.Bill = prod_.Price * amount;
                Makingorder.Orders.Add(order);

                Console.WriteLine($"hehehehehhe222{order.OrderDate}");
                Makingorder.SaveChanges();
                Console.WriteLine("введите exit для окончания формирования заказа или нажмите enter для продолжения");
                var cond = Console.ReadLine();
                if (cond == "exit") condition = false;
            }
            while (condition);


        }
    }
}
