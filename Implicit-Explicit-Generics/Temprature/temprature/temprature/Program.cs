using System;
using temprature.TypeOfTemprature;

namespace temprature
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Celcsus C = new Celcsus(10);

            Kelvin K = new Kelvin(300);

            Celcsus nC=K;

            Console.WriteLine(nC.Degree);

        }
    }
}
