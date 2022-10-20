using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract.Models
{
    public abstract class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
        public void Test()
        {
            Console.WriteLine("test");
        }

        public abstract void Test2();

        

    }
}
