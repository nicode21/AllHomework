using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Models
{
    public class Car // STATIC CLASSIN ICINDE STATIC OLMAYAN HEC BIRSEY YAZMAQ OLMUR !!!
                     // EGER CLASS STATICDIRSE O CLASSDAN INSTANCE ALMAQ OLMAZ CLASSIN ADI ILE CAGIRMAQ LAZIMDIR !!!


    {
        public static int Speed =500;

        static Car()

            // STATIC CONSTRUCTOR EN BIRINCI ISE DUSEN METHODDUR VE PARAMETR QEBUL ETMIR VEEEEE ACCES MODIFIERI OLMUR !!!
        
        {
            Console.WriteLine(Speed);
        }        
    }
    struct Test
    {
        public int Test1 { get; set; }

        //public Test(int a)  // STRUCT IN ICINDE YAZILAN PARAMETRLERI FIELDLERE MENIMSETMELISEN !!!
        //{
        //    Test1=a;
        //}
    }
}
