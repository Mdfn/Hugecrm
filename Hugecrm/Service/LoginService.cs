using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugecrm.Data;
using Hugecrm.Service;
namespace Hugecrm.Service
{
   public class LoginService
    {
        
        public void Login(out string login,out string password)
        {
            
            Console.WriteLine("enter login");
             
            login = Console.ReadLine();
            
            Console.WriteLine("enter password");

            password = Console.ReadLine();
        }
        public User LogIndatabase()
        {
            string login;
            string password;
            Login(out login, out password);
            CrmContext Logincrmcontext= new CrmContext();
            var quarry =Logincrmcontext.Users.FirstOrDefault(userz => userz.Login.Equals(login) && userz.Password.Equals(password));

            if (quarry != null)
            {
                Console.WriteLine($"{quarry.Name},Logged Sucessfull");
                return quarry;
            }
            else
            {
                Console.WriteLine("Error logging");
                return null;
            }
        }

    }
}
