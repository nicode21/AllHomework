using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public class Calculation : ICalculation
    {
        

        public void Calculate()
        {
            {
                
                    
                    Console.WriteLine("If you want to close calculator type : E");
                    Console.WriteLine("If you want to clear calculator type : C");
                while (true)
                {
                    Console.WriteLine("Enter Operator");

                    char action = Convert.ToChar(Console.ReadLine());
                    if (action == 'E')
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
                                Addition(input_1, input_2);
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


       
        }
        public void Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }

        public void Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }

        public void Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }

        public void Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n" + result);
        }

        
    }
}
