using System;
using System.Collections.Generic;
using System.Text;

namespace temprature.TypeOfTemprature
{
    public class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Celcsus(Kelvin degree)
        {
            return new Celcsus(degree.Degree-273);
        }
    }

    
}
