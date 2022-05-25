namespace ProjConsole;

/*
 * 
 */

static class OutputConsole
{
	static void Main()
	{
		Console.WriteLine("Enter any first number");
		int firstNumber = Int32.Parse(Console.ReadLine()!);
		Console.WriteLine("Enter any second number");
		int secondNumber = Int32.Parse(Console.ReadLine()!);
		int sum = firstNumber + secondNumber;
		int difference = firstNumber - secondNumber;
		Console.WriteLine($"Sum of numbers : {sum}");
		Console.WriteLine($"The difference of numbers : {difference}");
	}
}