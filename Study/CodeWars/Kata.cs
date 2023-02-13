using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        public static int PositiveSum(int[] arr)
        {
            int result = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    result += num;
                }
            }
            return result;
        }
        public static string RepeatStr(int n, string s)
        {
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res += s;
            }
            return res;
        }
        public static string Remove_char(string s)
        {
            string result1 = "";

            result1 = s.Substring(1);
            result1 = result1.Substring(0, result1.Length - 1);

            return result1;
        }
        public static int FindSmallestInt(int[] args)
        {
            //int minElement = args[0];

            //int minIndex = 0;

            //for (int i = 1; i < args.Length; i++)
            //{
            //    if (args[i] < minElement)
            //    {
            //        minElement = args[i];

            //        minIndex = i;
            //    }
            //}
            //return minIndex;
            
            int minValue = args.Min();
            return minValue;
        }

    }
}
