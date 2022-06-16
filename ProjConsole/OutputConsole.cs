/*
 * Этапы :
 * 1. Запросить у пользователя сумму вклада и кол-во месяцев
 * 2. Прибавить 7% к вкладу за каждый месяц. Необходимо реализовать с оператором цикла for
 * 3. Вывести на экран сумму накопленную за все месяцы
 */

namespace ProjConsole;

static class BankDeposit
{
	static void Main()
	{
		Console.Write("Enter the deposit amount : ");
		decimal deposit = Convert.ToDecimal(Console.ReadLine());
		Console.Write("Enter the number of months for the deposit : ");
		int months = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= months; i++)
		{
			deposit += deposit * 0.07M;
		}
		Console.WriteLine($"Спустя {months} месяцев, сумма вклада составит {deposit}");
	}
}