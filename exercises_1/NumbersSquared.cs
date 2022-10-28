namespace exercisesCSharp;

// TODO: Написать программу со статическим методом, который вычисляет сумму квадратов натуральных чисел. Число N передается аргументом методу. Необходимо предложить версию с рекурсией и без рекурсии. (on 10/28/2022, 6:03pm)

public class NumbersSquared
{
    private static int WithoutRecursion(int n)
    {
        var result = 0;
        for (var i = 1; i <= n; i++) result += i * i;
        return result;
    }

    private static int Recursive(int n)
    {
        if (n <= 1) return 1;
        return n * n + Recursive(n - 1);
    }


    private static void Main()
    {
        Console.WriteLine(WithoutRecursion(5));
        Console.WriteLine(Recursive(5));
    }
}