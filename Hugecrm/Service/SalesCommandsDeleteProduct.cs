﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
namespace Hugecrm.Service
{
    class SalesCommandsDeleteProduct : ISalesCommands

    {
        public void CommandsRealization()
        {
            CrmContext deletingproduct = new CrmContext();
            Console.WriteLine("введите Id продукта для удаления");
            int delprodid = Convert.ToInt32(Console.ReadLine());
            var delquar = deletingproduct.Products.First(quar => quar.Id == delprodid);
            deletingproduct.Products.Remove(delquar);
            deletingproduct.SaveChanges();
        }

    }

}
