/* DESCRIPTION:
 * Написать программу, в которой вычисляется сумма чисел
 * Числа должны удовлетворять следующим критериям : При делении числа на 5 - в остатке 2, при делении на 3 - в остатке 1
 * Кол-во чисел в сумме вводиться пользователем
 * Программа отображает числа, которые суммируются, и значение суммы
 * Необходимо использовать обработку исключений
 * Предложить версии программ с разными операторами цикла
 */

/* STEPS:
 * 1. Запросить у пользователя кол-во чисел в сумме
 * 2. Написать проверку для введенных чисел. Можно попробовать реализовать тернарный оператор.
 *	UPD:: Все это необходимо написать внутри оператора цикла
 * 3. Программа отображает число, которое суммируется (которое прошло проверку) и значение суммы
 * 4. Реализовать обработку исключений
 */


namespace ProjConsole;

static class SumCondition
{
	static void Main()
	{
		try
		{
			int userNumber, sum = 0;

			// use any suitable loop
			do
			{
				// STEPS: 1
				Console.WriteLine("Enter a any integer \nOr enter 0 to end the program");
				userNumber = Int32.Parse(Console.ReadLine()!);

				// STEPS: 2 ; ternary operator
				string yesNo = userNumber % 5 == 2 || userNumber % 3 == 1
					? $"{sum} + {userNumber} = {sum += userNumber}"
					: "The number does not match the condition. It has not been added to the total.\n";

				// STEPS: 2.1 ; if operator
				/*
				if (userNumber % 5 == 2 || userNumber % 3 == 1)
				{
					Console.Write($"The number {userNumber} satisfies the conditions and is added to the total." +
					              $"\nSum of numbers equals : {sum} + {userNumber} = {sum += userNumber}\n");
				}
				else Console.WriteLine("The number does not match the condition. It has not been added to the total.\n");
				*/

				// STEPS: 3
				Console.WriteLine($"{yesNo}");
			} while (userNumber != 0);

			Console.WriteLine("Program has been ended.");
		}
		catch
		{
			// STEPS: 4
			Console.WriteLine("You entered isn't a number. Program will be end");
		}
	}
}