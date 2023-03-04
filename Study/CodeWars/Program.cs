using CodeWars;

//string x = Kata.BoolToWord1(false);
//Console.WriteLine(x);
//int[] arr = { 1, 2, 3};
//int sum =Kata.PositiveSum(arr);
//Console.WriteLine(sum);

//string p = Kata.RepeatStr(3,"llll");
//Console.WriteLine(p);
//string d = Kata.Remove_char("hello");
//Console.WriteLine(d);

//int sumi = Kata.FindSmallestInt(new int[] { 1, 2, -3 });
//Console.WriteLine(sumi);


//int sum =Kata.SquareSum(new int[] { 1, 2, 3 });
//Console.WriteLine(sum);
//Kata.Greet("name11");
//Kata.summation(1);
//Console.ReadLine();
//bool[] sheeps = { true, false, true, false, };
//Kata.CountSheeps(sheeps);
//Console.ReadLine();
//Kata.basicOp('+', 3, 4);
//Console.ReadLine();
//Kata.СenturyFromYear(1705);
//Kata.Litres(23);
//long n = 123456789;
//long[] reversed = Kata.Digitize(n);
//Console.ReadLine();
//int[] x = { 1, 2, 3, 4, 5, 6, 7, };
//Kata.Maps(x);
//string name = "Misha Iliyn";
//string initials = Kata.AbbrevName(name);
//Console.WriteLine(initials);
//bool love =Kata.lovefunc(1, 0);
//Console.WriteLine(love);
//double[] array = { 34, 76, 45 };
//Kata.SumArray(array);

//var result = Kata.IsCube(23, 34);
//Console.WriteLine(result);

int[] numbers = { 1, 2, 3, -4, -5 };
int[] inverses = Kata.InvertValues(numbers);
Console.WriteLine("Inverted values:");
for (int i = 0; i < inverses.Length; i++)
{
    Console.WriteLine(inverses[i]);
}
