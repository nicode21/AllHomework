using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Training.Models;

namespace Training.Helpers
{
    public static class Extensions
    {
        public static bool CheckDigitInString( this string str,string pattern) // THIS OLMASA CLASSLA BIRYERDE CAGIRIRIQ AMA OLSA VARIABLEDEN SONRA YAZA BILERIK !!!
        {
            //var result = Regex.IsMatch(str,@"\d");
            return Regex.IsMatch(str, pattern);                 //BELE YAZSAQ DAHA ELVERISLIDIR !!!
        }

        public static string GetStringAfterCheck(this bool IsMArried)
        {
            return IsMArried ? "Evlidir" : "Subaydir";
        }

        public static string GetStudentName(this Student person ,string name)
        {
            return name;
        }
    }
}
