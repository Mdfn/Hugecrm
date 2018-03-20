using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
    public class Customer
    {
        //public int SalesId { get;set;}
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }                                   
        public Int32 Phone { get; set; }
        public string Address { get; set; }
        public int MO_Id { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Customer(string name, string email, Int32 phone,string address,int marketorganization_Id)
        {
            //SalesId = salesId;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            MO_Id= marketorganization_Id;
        }
        public Customer()
        { }
    }
}