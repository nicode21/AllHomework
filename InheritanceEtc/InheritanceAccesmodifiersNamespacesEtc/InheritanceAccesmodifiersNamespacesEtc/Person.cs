using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAccesmodifiersNamespacesEtc_
{
    class Person : Group
    {
        internal string name; /*    Fieldlerin default A.M. -i private-dir  internal olduqda bu proyektde islede bilerik    */
        private protected string surname;  /*   Yox eger private -dirse o zaman eyni class da islede bilerik */
        protected string Adress{ get; set; }

        protected internal string Color { get; set; }

        private int age/*=15*/;
        public string phone;




        //public Person()
        //{
        //    Capacity = 12;
        //}

        //protected oldugu ucun inheritance alib isletmek olar



        public int Age { /*   get; set; }      */
            get
            {
                if (age < 18)
                {
                    Console.WriteLine("Can't see");
                    return -1;
                }
    
                return age;
            }
            set
            {
                age=value;
            }


            /*public Person(string phone)
            {
                Console.WriteLine(phone);
            }*/

            //public Person()
            //{
            //    surname = "Novruzzade";
            //}

            //public void ShowSurname()
            //{
            //    Console.WriteLine(surname);
            //}

            //show private fields with reflection:


            //typeof(Foo).GetField("_bar", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(objectForFoocClass, "newValue");



            //var _barVariable = typeof(Foo).GetField("_bar", BindingFlags.NonPublic | BindingFlags.Instance).GetValue////(objectForFooClass);


            //Console.WriteLine(_barVariable);             using etmek lazimdir!!!




        }
    }
}
