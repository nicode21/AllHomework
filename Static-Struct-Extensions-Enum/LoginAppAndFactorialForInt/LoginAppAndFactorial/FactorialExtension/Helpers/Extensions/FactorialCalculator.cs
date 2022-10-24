using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialExtension.Helpers.Extensions
{
    public static class FactorialCalculator
    {

        public static int GetFactorialResult(this int num)
        {
            int result =1;
            for (int i = 1; i <= num; i++)
            {
                result *=i;
            }
            return result;
        }

    }
}
