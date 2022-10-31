using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeCount
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public double Salary { get; set; }

        public static Employee[] _arr = new Employee[0];

        public static int Count;

        public Employee(DateTime birthDay)
        {
            BirthDay=birthDay;
        }


        public void Add(Employee employee)
        {
            Array.Resize(ref _arr , _arr.Length+1);

            _arr[_arr.Length-1] = employee;
        }

        


        public int EmployeeCountCalculator(DateTime start , DateTime end,double salary )
        {
            Salary =salary;
            
                if (start < BirthDay && BirthDay < end && Salary > 2000)
                {
                    Count++;
                }
                return Count;
            
        }


        


    }
}
