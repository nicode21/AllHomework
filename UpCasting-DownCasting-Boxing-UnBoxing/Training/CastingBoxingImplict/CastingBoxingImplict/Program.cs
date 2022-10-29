using CastingBoxingImplict.Models;
using Service.Extension;
using Service.Services;
using Service.Services.Interface;
using System;

namespace CastingBoxingImplict
{
    class Program
    {
        static void Main(string[] args)
        {
            //Login();

            #region UpCasting DownCasting UnBoxing....

            //int a =5;
            //string b = a;     //BURDA ALINMIR CUNKI ASAGIDA INHERITANCE ALINIB BURDA YOX


            /*byte*/            /*int num1 = 50;*/     //BU BOXINGDIR
            /*int*/             /*byte num2=(byte)num1;*/
            // BELE OLMUR CUNKI BILINMIR TAAA KI, CASTING EDENE KIMI

            //Console.WriteLine(num2);



            //Eagle eagle1 = new Eagle();

            //Animals animal = eagle1;

            //Animals animal2 = new Eagle();

            //Animals animal2 = new Animals();      //CUNKI ANIMAL ABSTRACTDIRRR

            //animal2.Eat();

            /*int a = 5;*/ // BU PROSES BOXING ADLANIR

            //object b = a;

            /*int c= (int)b;*/ // DOWNCASTING VE UNBOXING

            //string a = "50";

            //object b = a;

            //string c = b.ToString();

            //Console.WriteLine(c);

            #endregion

            //Eagle eagle1 = new Eagle();

            //Animals eagle2 = new Eagle();

            //Shark shark1 = new Shark();

            //Animals animal1 = shark1;

            //Animals shark2 = new Shark();

            /*Shark shark3 = shark2;*/    // SHARK ANIMALDAN MIRAS ALIB DEYE CAST EDE BILMIRIK!!!!





            //Animals[] animals = {eagle1,eagle2,shark1,shark2};

            //ANIMALSDAN MIRAS ALINIB DIYE ARRAYIN ICINE YIGA BILIRIK

            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}



            Animals shark1 = new Shark();

            Animals eagle1 = new Eagle();

            object [] objects = {1,2,"P414",shark1,eagle1};

            foreach (var item in objects)
            {

                Animals animal = item as Animals;

                //string animal =null;

                //string result = animal == null ? "Can't Casting" : "Succes Casting";

                bool IsCast = animal == null ? true:false;;
                if (!IsCast)
                {
                    var result = animal.Name ?? "Can't Casting";
                    Console.WriteLine(result);
                }
                /*var result = animal.Name ?? "Can't Casting";*/       //TIPI FERQLI OLARSA BUNU ETMEK OLMUR

                //string name = "sdad";

                //string response = name ?? " asdasd";

                //Console.WriteLine(result);

                //Console.WriteLine(item);

                //if (animal == null)
                //{
                //    Console.WriteLine("Can't Casting");
                //}
                //else
                //{
                //    animal.Name = "test2";

                //    Console.WriteLine(animal.Name);
                //}


                //    //Console.WriteLine(item);
                //    if (item is Animals t)
                //    {
                //        t.Name = "test";

                //        Console.WriteLine(t.Name);
                //    }
                //    else
                //    {
                //        Console.WriteLine("Can't Casting");
                //    }

            }


        }
        //static void Login()
        //{

        #region HomeWork
        //Console.WriteLine("Please add email:");

        //string email = Console.ReadLine();

        //Console.WriteLine("please add password:");

        //string password = Console.ReadLine();

        //int role = 1;

        //IAccountService account = new AccountService();

        //var result = account.Login(email, password, role);

        //Console.WriteLine(result);

        //int num = 4;

        //if (num<0)
        //{
        //    Console.WriteLine("Duzgun eded daxil edin");
        //}

        //Console.WriteLine(num.CalculateFactorial());

        #endregion

        //}
    }


    //class test : Object
    //{

    //}

}
