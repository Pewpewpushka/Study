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
        public static int SquareSum(int[] number)
        {
            int power = 2;
            // возводим массив в степень
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = (int)Math.Pow(number[i], power);
            }

            // вычисляем сумму элементов
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            return sum;

        }
        public static string BooleanToString(bool b)
        {
            string result = string.Empty;

            if (b)
            {
                result = "True";
            }
            else
            {
                result = "False";
            }
            return result;
        }
        public static string Greet(string name)
        {
            string result = "Hello,  how are you doing today?";
            string substring = name;

            result = result.Insert(7, substring);
            Console.WriteLine(result);
            return result;
            // return $"Hello, {name} how are you doing today?";
        }
        public static int summation(int num)
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
            return result;
            //return num*(num+1)/2;
        }
        public static int CountSheeps(bool[] sheeps)
        {
            int result = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i])
                {
                    result++;
                }
            }
            Console.WriteLine(result);
            return result;
            //int count = 0;
            //foreach (bool sheep in sheeps)
            //{
            //    if (sheep) count++;
            //}
            //return count;
        }
        public static double basicOp(char operation, double value1, double value2)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;


            }
            Console.WriteLine(result);
            return result;
            //switch (op)
            //{
            //    case '+': return val1 + val2;
            //    case '-': return val1 - val2;
            //    case '*': return val1 * val2;
            //    case '/': return val1 / val2;
            //}
            //return 0;
        }
        public static int СenturyFromYear(int year)
        {
            int result = 0;
            result = year / 100 + 1;
            Console.WriteLine(result);
            return result;
        }
        public static int Litres(double time)
        {
            int result = (int)time / 2;
            Console.WriteLine(result);
            return result;
        }
        public static long[] Digitize(long n)
        {
            // Преобразуем число n в массив символов
            char[] result = n.ToString().ToCharArray();

            // Создаем новый массив, который будет содержать цифры в обратном порядке
            long[] reversed = new long[result.Length];

            // Копируем цифры из исходного массива в новый массив в обратном порядке
            for (int i = 0; i < result.Length; i++)
            {
                reversed[i] = long.Parse(result[result.Length - i - 1].ToString());
            }
            Console.WriteLine(reversed);
            // Возвращаем массив цифр в обратном порядке
            return reversed;
            //string nstring = n.ToString();
            //long[] schlong = new long[nstring.Length];

            //for (int i = 0; i < nstring.Length; i++)
            //{
            //    string b = nstring[nstring.Length - i - 1].ToString();
            //    long a = Int64.Parse(b);
            //    schlong[i] = a;
            //}
            //return schlong;

        }
        public static int[] Maps(int[] x)
        {

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * 2;
                Console.WriteLine(x[i]);
            }
            return x;
        }
        public static string AbbrevName(string name)
        {   //разделяем на два слова с помощью пробела
            string[] words = name.Split(' ');
            string initials = "";
            //затем проходит в цикле через каждое слово, извлекает первую букву и делает ее заглавной.
            foreach (string word in words)
            {
                initials += word[0].ToString().ToUpper();
            }
            //объединяем две начальные буквы точкой между ними и возвращает результат.
            return initials[0] + "." + initials[1];

            //string[] buf = name.Split(' ');

            //var firstName = buf.First();
            //var lastName = buf.Last();

            //var oneUpper = Char.ToUpper(firstName.First());
            //var twoUpper = Char.ToUpper(lastName.First());

            //return $"{oneUpper}.{twoUpper}";

        }
        public static bool lovefunc(int flower1, int flower2)
        {

            if (flower1 < flower2 || flower2 < flower1)
            {
                return true;
            }
            else if (flower1 > flower2 || flower2 > flower1)
            {
                return false;
            }
            else if (flower1 == flower2 || flower2 > flower1)
            {
                return false;

            }
            else
            {
                return false;
            }

            return true;
            //if (flower1 % 2 == 0 && flower2 % 2 != 0)  // flower1 has even number of petals and flower2 has odd number of petals
            //{
            //    return true;  // they are in love
            //}
            //else if (flower1 % 2 != 0 && flower2 % 2 == 0)  // flower1 has odd number of petals and flower2 has even number of petals
            //{
            //    return true;  // they are in love
            //}
            //else
            //{
            //    return false;  // they are not in love
            //}

            //return flower1 % 2 != flower2 % 2;

            // return (f1+f2)%2==1;



        }
    }
}
