using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialExtension.Helpers.Extensions
{
    public static class Factorial
    {
        public static int GetFactorialResult(this int num)
        {
            int result = 1;
            if (num>0)
            {
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
            }
            else
            {
                return 0;
            }
            
            return result;
        }
    }
}
