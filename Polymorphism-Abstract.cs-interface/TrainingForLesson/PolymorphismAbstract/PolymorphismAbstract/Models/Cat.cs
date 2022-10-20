using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract.Models
{
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat sound");
        }

        
    }
}
