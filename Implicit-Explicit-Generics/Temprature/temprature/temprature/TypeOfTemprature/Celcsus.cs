using System;
using System.Collections.Generic;
using System.Text;

namespace temprature.TypeOfTemprature
{
    public class Celcsus
    {
        public double Degree { get; set; }

        public Celcsus(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celcsus degree)
        {
            return new Kelvin(degree.Degree + 273);
        }

    }
}
