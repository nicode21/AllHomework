using System;
using System.Collections.Generic;
using System.Text;
using Training.Interface;

namespace Training.Models
{
    public class Student : Person , ITest
    {
        public string Teacher { get; set; }
    }
}
