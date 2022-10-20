using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract.Models
{
    class Student : Person
    {
        //public override string ToString()
        //{
        //    return Name + " " + Surname + " " + Age;
        //}
        public override void Test2()
        {
            Console.WriteLine("test2");
        }
    }
}
