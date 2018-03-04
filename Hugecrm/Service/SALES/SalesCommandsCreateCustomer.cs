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
        public void CommandsRealization(/*SalesCommandscommon command*/)
        {
            CrmContext creatingcustomer = new CrmContext();
            Console.WriteLine("введите имя");
          string name= Console.ReadLine();
            Console.WriteLine("введите адрес эмейл");
           string email= Console.ReadLine();
            Console.WriteLine("введите номер телефона ");
           Int32 phone= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите адрес расположения");
           string address= Console.ReadLine();
            Console.WriteLine("введите marketorganization");
           string marketorganization= Console.ReadLine();


            Customer cust = new Customer(name, email, phone,address,marketorganization);
            creatingcustomer.Customers.Add(cust);
            creatingcustomer.SaveChanges();

        }
    }
}
