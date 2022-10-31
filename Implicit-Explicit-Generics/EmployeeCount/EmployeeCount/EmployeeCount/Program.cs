using System;

namespace EmployeeCount
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[]arr = Employee._arr;

            Employee emp1 = new Employee(DateConverter("01/05/2022"));
            emp1.Name = "asda";
            emp1.Add(emp1);
            Employee emp2 = new Employee(DateConverter("01/04/2022"));
            emp2.Name = "ada";
            emp2.Add(emp2);
            Employee emp3 = new Employee(DateConverter("01/06/2022"));
            emp3.Name = "adsadasda";
            emp3.Add(emp3);

            //foreach (var item in Employee._arr)
            //{
            //    Console.WriteLine(item.Name);
            //}

            emp1.EmployeeCountCalculator(DateConverter("01/03/2022"), DateConverter("01/07/2022"), 2002);
            emp2.EmployeeCountCalculator(DateConverter("01/03/2022"), DateConverter("01/07/2022"), 2002);
            Console.WriteLine(emp3.EmployeeCountCalculator(DateConverter("01/03/2022"), DateConverter("01/07/2022"), 2002));

        }

        #region Converter
        public static DateTime DateConverter(string date)
        {
            return DateTime.Parse(date);
        }
        #endregion

    }
}
