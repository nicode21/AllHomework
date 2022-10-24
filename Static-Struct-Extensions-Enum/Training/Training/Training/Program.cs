using System;
using Training.Enums;
using Training.Helpers;
using Training.Models;


namespace Training
{
    public static class Program
    {
         public static void Main(string[]args)        
         {
            #region Static
            // static oluguna gore static olmayan Test methodunu cagira bilmirik !!!


            //Test();


            //Car car1 = new Car();

            //Car.Speed =500;

            //Console.WriteLine(Car.Speed);     // Eger field ya da property staticdirse Classin adi ile cagirmaq lazimdir !!!


            //Person person1 = new Person();
            //Person person2 = new Person();
            //Person person3 = new Person();


            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();
            //Test(new int[] {1,2,3,4,5,6,7,8,9 });

            //Test(1,2,3,4,5,6,7,8,9);

            //int a = 5;

            //string name = "asdasdasd";

            //name.
            #endregion

            //string name = "sdasd3";

            //Console.WriteLine(name.CheckDigitInString(@"\d"));

            //bool Ismarried =false;

            //Console.WriteLine(Ismarried.GetStringAfterCheck());

            //Student student = new Student();

            //Console.WriteLine(student.GetStudentName("asdasd") ); 


            //CheckRoles(1);

            ChecWeeksDay(8);

        }


        public static void ChecWeeksDay(int weekDay)
        {            
            {
                switch (weekDay)
                {
                
                case (int)Weeks.Monday:
                    Console.WriteLine("1 ci");
                    break;
                case (int)Weeks.Tuesday:
                    Console.WriteLine("2 ci");
                    break;
                case (int)Weeks.Wednesday:
                    Console.WriteLine("3 cu");
                    break;
                    case (int)Weeks.Thursday:
                        Console.WriteLine("4 cu");
                        break;
                    case (int)Weeks.Friday:
                        Console.WriteLine("5 ci");
                        break;
                    case (int)Weeks.Saturday:
                        Console.WriteLine("6 ci");

                        break;
                    case (int)Weeks.Sunday:
                        Console.WriteLine("7 ci");
                        break;

                    default: 
                        Console.WriteLine("Sehv heftenin gununu girmisiniz");
                        break;
                }






                #region Test
                //public static void Test()
                //{
                //    Console.WriteLine("test");
                //}




                //public static void Test (params int []arr) // PARAMS YAZILDIQDA ARRAYIN ELEMENTLERINI DIREKT METHODUN SKOPKASININ ICINE YAZIRIQ !!!
                //{
                //    foreach (var item in arr)
                //    {
                //        Console.WriteLine(item);
                //    }
                //}

                #endregion

                //public static void CheckRoles(int rolid)
                //{
                //    switch (rolid)
                //    {

                //        case (int)Roles.SuperAdmin:
                //        Console.WriteLine( "Super Admindir");
                //            break;
                //        case (int)Roles.Admin:
                //            Console.WriteLine("Admindir");
                //            break;
                //        case (int)Roles.Member:
                //            Console.WriteLine("Memberdir");
                //            break;



                //    }
                //}


            }
        }

    }


    
}
