using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
    public class Product
    {
        public string ProductType { get; set; }
        public decimal Price { get; set; }
    public int Id { get; set; }
        public Product(string producttype,decimal price)
        {
            ProductType = producttype;

            Price = price;
        }
        public Product()
        { }
    }
}
