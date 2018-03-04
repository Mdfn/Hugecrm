using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class SalesCommandsChangeProduct:ISalesCommands

    {
        public void CommandsRealization()
        {
            Console.WriteLine("введите Id продукта, подлежащего корректировке");
            var changeproductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("какое поле меняем у продукта, подлежащего корректировке(true=type,false=price)?");
            bool  polekor = Convert.ToBoolean(Console.ReadLine());
            CrmContext changeproduct = new CrmContext();
            
            var prodtochange = changeproduct.Products.FirstOrDefault(qua => qua.Id == changeproductId);
            if (prodtochange != null)
            {
                if (polekor)
                {
                    string prodchvalue = Console.ReadLine();
                    prodtochange.ProductType = prodchvalue;
                }
                else
                {
                    decimal prodchvalue = Convert.ToDecimal(Console.ReadLine());
                    prodtochange.Price = prodchvalue;
                }
                changeproduct.SaveChanges();
            }
            else Console.WriteLine("Id отсутствует");
            
        }
    }
    
}
