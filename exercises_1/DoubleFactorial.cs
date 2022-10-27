namespace exercisesCSharp;

// TODO: Написать программу в которой описан статический метод для вычисления двойного факториала числа, переданного аргументом методу. Предложить версию с рекурсией и без рекурсии. (on 10/21/2022, 4:42pm)

internal static class DoubleFactorial
{
    // used recursive method
    private static int DoubleFactorialRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * DoubleFactorialRecursive(n - 2);
    }

    // method without recursive
    private static int DoubleFactorialWithoutRecursive(int n)
    {
        var result = n;
        for (var i = 2; i < n; i += 2)
        {
            result *= (n - i);
        }

        return result;
    }

    private static void Main()
    {
        Console.WriteLine(DoubleFactorialRecursive(5));
        Console.WriteLine(DoubleFactorialWithoutRecursive(5));
    }
}