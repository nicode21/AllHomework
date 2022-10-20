using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface ICalculation
    {
         public void Calculate();
        public void Addition(int input_1, int input_2);
        public void Subtraction(int input_1, int input_2);

        public  void Multiplication(int input_1, int input_2);
        public void Division(int input_1, int input_2);
    }
}
