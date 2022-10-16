using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAccesmodifiersNamespacesEtc_
{
    class Dog : Animal
    {
        public Dog(string dogName)
        {
            //name = "Reks";

            //Console.WriteLine(name);

            name = dogName;

            Console.WriteLine(this.name);
        }
    }
}
