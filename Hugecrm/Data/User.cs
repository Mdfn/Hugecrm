using System;

namespace Hugecrm.Data
{
    public class User
    {
        public Boolean Root { get; set; }

        public String Name { get; set; }

        public Int32 Id { get; set; }

        public String Login { get; set; }

        public String Password { get; set; }

        public User(bool root, string name, string login, string password)
        {
            Root = root;
            Name = name;
            Login = login;
            Password = password;
        }
        public User()
        { }
    }
}