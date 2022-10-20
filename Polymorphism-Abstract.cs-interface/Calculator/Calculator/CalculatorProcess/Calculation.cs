using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProcess
{
    class Calculation : ICalculation
    {
       

        void ICalculation.Calculate()
        {
            while (true)
            {
                Console.WriteLine("Enter Operator");
                char action = Convert.ToChar(Console.ReadLine());
                if (action == '0')
                {
                    break;
                }
                if (action == 'C')
                {
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Enter number 1");
                int input_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                int input_2 = Convert.ToInt32(Console.ReadLine());
                int result;


                switch (action)
                {
                    case '+':
                        {
                            ICalculation.Addition(input_1, input_2);
                            break;
                        }
                    case '-':
                        {
                            Subtraction(input_1, input_2);
                            break;
                        }
                    case '*':
                        {
                            Multiplication(input_1, input_2);
                            break;
                        }
                    case '/':
                        {
                            Division(input_1, input_2);
                            break;
                        }
                    default:
                        Console.WriteLine("Try Again");
                        break;


                }


            }
        }

        void ICalculation.Addition()
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }

        void ICalculation.Multiplication()
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;

            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }

        void ICalculation.Subtraction()
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;

            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }
        void ICalculation.Division()
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;

            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }
    }
}
