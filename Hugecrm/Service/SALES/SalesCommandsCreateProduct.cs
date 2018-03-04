using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class SalesCommandsCreateProduct:ISalesCommands
    {
        public void CommandsRealization()
        {
            Console.WriteLine("введите тип продукта");
          string producttype=  Console.ReadLine();
            Console.WriteLine("введите цену продукта");
            decimal price=Convert.ToDecimal( Console.ReadLine());
            CrmContext creatingproduct = new CrmContext();
            Product prod = new Product(producttype, price);
            creatingproduct.Products.Add(prod);
            creatingproduct.SaveChanges();
        }

    }
}
