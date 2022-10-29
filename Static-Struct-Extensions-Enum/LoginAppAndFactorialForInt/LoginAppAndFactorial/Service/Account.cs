using Service.Enums;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Account : IAccount
    {
        public void CheckLogin()
        {

            while (true)
            {
                Console.WriteLine("Enter your role : ");
                int roleID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();


                switch (roleID)
                {
                    case (int)Roles.SuperAdmin:
                        Console.WriteLine("SuperAdmin");
                        break;
                    case (int)Roles.Admin:
                        Console.WriteLine("Admin");
                        break;
                    case (int)Roles.Member:
                        Console.WriteLine("Member");
                        break;

                }

                if (email == "test@code.edu.az" && password == "test12345" && roleID == 191919)            2222asd
                {
                    Console.WriteLine("Entrance is successful");
                    break;
                }
                else if (roleID == 191919 && email != "test@code.edu.az" && password != "test12345")
                {
                    Console.WriteLine("Hey, SuperAdmin You have mistake on email or password");
                }
                else if (roleID == 191919 && email != "test@code.edu.az" && password == "test12345")
                {
                    Console.WriteLine("Hey, SuperAdmin You have mistake on email or password");
                }
                else if (roleID == 191919 && email == "test@code.edu.az" && password != "test12345")
                {
                    Console.WriteLine("Hey, SuperAdmin You have mistake on email or password");
                }
                else if (roleID != 191919 && password == "test12345" && email == "test@code.edu.az")
                {
                    Console.WriteLine("You have not permission enter site like SuperAdmin");
                }
                else
                {
                    Console.WriteLine("We can't recognize you please try again");
                }
            }

        }


    }
}
