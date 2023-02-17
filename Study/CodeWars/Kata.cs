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

        public static string Hello()
        {
            string a = "H";
            string b = "e";
            string c = "l";
            string d = "lo";
            string e = "world!";
            
            string[] values = { a, b, c, d };
            string result = string.Join("", values);
            string result1= string.Concat( result," ",e);
            Console.WriteLine(result1);
            return result1;
        }
    }
}
