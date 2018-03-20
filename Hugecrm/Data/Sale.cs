using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugecrm.Data
{
    public class Sale : User
    {
        public int MO { get; set; }
        public Sale(string root,int _MO, string name, string login, string password)
        {
            Root = root;
            MO= _MO;
            Name = name;
            Login = login;
            Password = password;
        }
        public Sale()
        { }
    }
}
