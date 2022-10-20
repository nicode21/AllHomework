using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract
{
    public class User : IUser
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Login oldu");
        }

        public string SendEmail(string email)
        {
            return "Email gonderildi";
        }
    }
}
