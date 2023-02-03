

using Exception_and_nullable;

List<string> list = null;

string x = Console.ReadLine();
try
{

	if (x.Length < 3)
	{
		throw new MyException("Выброшена моя ошибка");
	}

}
catch (MyException ex)
{
	Console.WriteLine("Меньше 3 символов надо");
}

Console.WriteLine("Конец проги");