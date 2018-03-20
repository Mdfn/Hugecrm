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
        public void CommandsRealization()
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
            
          //int salsId = OrgSystem.saveusrsales[OrgSystem.saveusrsales.Count-1].Id;
          int salsMO = OrgSystem.saveusrsales[OrgSystem.saveusrsales.Count - 1].MO;

            Customer cust = new Customer(/*salsId,*/name, email, phone, address, salsMO);
            creatingcustomer.Customers.Add(cust);
            creatingcustomer.SaveChanges();

        }
    }
}
