﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interface
{
    public interface IAccountService
    {
        string Login(string email,string password,int role);
        

        
    }
}
