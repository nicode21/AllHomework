using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAbstract.Models
{
    class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
    }
}
