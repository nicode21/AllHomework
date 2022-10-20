using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract
{
    public interface IUser
    {
        void Login(string username,string password);
        string SendEmail(string email);

    }
}
