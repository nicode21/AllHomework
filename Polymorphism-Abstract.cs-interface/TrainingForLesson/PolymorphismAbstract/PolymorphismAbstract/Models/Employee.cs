using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract.Models
{
    class Employee : Person
    {
        public override void Test2()
        {
            Console.WriteLine("Employee test");
        }
    }
}
