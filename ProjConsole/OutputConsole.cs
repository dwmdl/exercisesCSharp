namespace Proj_1;
/*
 * Необходимо вывести на экран возраст и имя пользователя 
 */

static class InputConsole
{
	static void Main()
	{
		// заголовок окна
		Console.Title = "Приветствие";
		Console.WriteLine("Введите свое имя");
		// создаем переменную и сразу считываем информацию введенную в строке выше
		string? firstName = Console.ReadLine();
		Console.WriteLine("Введите свой возраст");
		// также считываем данные из строки выше 
		string? age = Console.ReadLine();
		// выводим в консоль
		Console.WriteLine("Здравствуйте, {0}", firstName);
		Console.WriteLine("Ваш возраст: " + age);
	}
}