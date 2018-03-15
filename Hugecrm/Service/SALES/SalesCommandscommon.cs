using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Service.SALES
{
    class SalesCommandscommon:ICommandLineInterface

    {
        Dictionary<string, ISalesCommands> salesdic = new Dictionary<string, ISalesCommands>();
        public void Dictfilling()
        {
            SalesCommandsCreateCustomer createCustomer = new SalesCommandsCreateCustomer();
            SalesCommandsDeleteCustomer deleteCustomer= new SalesCommandsDeleteCustomer();
            SalesCommandsCreateProduct createProduct = new SalesCommandsCreateProduct();
            SalesCommandsDeleteProduct deleteproduct = new SalesCommandsDeleteProduct();
            SalesCommandsChangeProduct changeProduct = new SalesCommandsChangeProduct();
            SalesCommandsMakeOrder makeOrder = new SalesCommandsMakeOrder();
            SalesCommandsChangeorder changeorder = new SalesCommandsChangeorder();
            salesdic.Add("create customer", createCustomer);
            salesdic.Add("delete customer", deleteCustomer);
            salesdic.Add("create product", createProduct);
            salesdic.Add("delete product", deleteproduct);
            salesdic.Add("change product", changeProduct);
            salesdic.Add("make order", makeOrder);
            salesdic.Add("change order", changeorder);
        }

        public void PrintCommands()
        {
            foreach (string key in salesdic.Keys)
            {
                Console.WriteLine(key);
            }

        }
        public void ExecuteCommands(string command)
        {
            foreach (string key in salesdic.Keys)
            {
                if (command == key)
                {
                    
                    salesdic[key].CommandsRealization();            
                }

            }

        }

    }
}
