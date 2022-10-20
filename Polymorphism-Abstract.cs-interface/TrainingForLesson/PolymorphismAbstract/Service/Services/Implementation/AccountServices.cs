using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Implementation
{
    public class AccountServices : IAccountService
    {
        public void Register()
        {
            Console.WriteLine("Register olundu");
        }
    }
}
