using System;
using System.Collections.Generic;
using System.Text;

namespace CastingBoxingImplict.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }


        //public Eagle()
        //{
        //    Console.WriteLine("Eagle Constructor");
        //}
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
