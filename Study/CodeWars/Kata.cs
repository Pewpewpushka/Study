using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Kata
    {
        public static string EvenOrOdd(int number)
        {
            string result = string.Empty;

            bool isOdd = number % 2 == 0;

            switch (isOdd)
            {
                case true:
                    result = "Odd";
                    break;

                case false:
                    result = "Even";
                    break;
            }

            return result;
        }
        public static string BoolToWord1(bool word)
        {
            
            string text = word ? "Yes" : "No";
            return text;
        }
    }
}
