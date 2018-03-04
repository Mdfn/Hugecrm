using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
   public class Order
   {
        public Int32 Id { get; set; }

        public int Amount { get; set; }

        public decimal Bill { get; set; }
        public Int32 CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public Int32 ProductId { get; set; }
public virtual Product Product { get; set; }
   
            public Order(int customerId, int productId,int amount)
            {
            ProductId = productId;
            CustomerId = customerId;
            Amount = amount;
        }


   }
}
