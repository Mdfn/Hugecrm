using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
    public class Customer
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Int32 Phone { get; set; }
        public string Address { get; set; }
        public string MarketOrganization { get; set; }
        public Customer(string name, string email, Int32 phone,string address,string marketorganization)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            MarketOrganization = marketorganization;
        }
        public Customer()
        { }
    }
}