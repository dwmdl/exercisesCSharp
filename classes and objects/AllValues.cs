namespace exercisesCSharp.easy.classes_and_objects;

public static class AllValues
{
    static void Method(params int[] numbers)
    {
        // all this can be done in a different way, but using LINQ expressions is faster and easier.
        double averageValue = numbers.Sum();
        Console.WriteLine($"\nAverage value: {averageValue / numbers.Length}");
        
        var largestValue = numbers.Max();
        Console.WriteLine($"Largest value: {largestValue}");
        
        var lowestValue = numbers.Min();
        Console.WriteLine($"Lowest value: {lowestValue}");
    }

    static void Main()
    {
        var array = new[] { 903, 64, 163, 605, 641 };
        Method(array);
        Method(51, 8, 369, 933, 423);
    }
}