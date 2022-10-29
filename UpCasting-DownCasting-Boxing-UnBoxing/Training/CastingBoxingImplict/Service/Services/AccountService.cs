
using Service.Helpers.Constants;
using Service.Helpers.Enums;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public string Login(string email, string password, int role)
        {
            if (email==AccountConstants.Email && password == AccountConstants.Password)
            {
                if (CheckRole(role))
                {
                    return AccountConstants.Succes;
                }
                else
                {
                    return AccountConstants.NoAuthorize;
                }
            }

            return AccountConstants.Failed;
        }

        private bool CheckRole(int role)
        {

            //switch (role)
            //{
            //    case (int)Roles.SuperAdmin:
            //        break;
            //    case (int)Roles.Admin:
            //        break;
            //    case (int)Roles.Member:
            //        break;
            //    default:
            //        break;
            //}

            if (role== (int)Roles.SuperAdmin) // BU UPCASTINGDIR
            {
                return true;
            }
            return false;
        }
    }
}
