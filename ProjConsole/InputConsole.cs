namespace Proj_1;
/*
 Необходимо написать консольную версию программ, которая сначала принимает имя пользователя, потом фамилию и выводит эту информацию на в консоль
*/

static class InputConsole
{
	static void Main()
	{
		Console.Title = "Приветствие";
		Console.WriteLine("Введите свое имя");
		// объявляем строковую переменную и сразу считываем ее
		string? firstName = Console.ReadLine();
		Console.WriteLine("Введите свою фамилию");
		string? secondName = Console.ReadLine();
		// выводим на экран имя(0 индекс) и фамилию(1 индекс) пользователя
		Console.WriteLine("Здравствуйте, {0} {1} ", firstName, secondName);
	}
}