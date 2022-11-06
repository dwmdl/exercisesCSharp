namespace exercisesCSharp.easy.methods;

// TODO-RU: Написать программу со статическим методом, аргументом которому передается двумерный целочисленный массив.  У метода, кроме аргумента-массива, есть два неинициализированных аргумента. Результатом метод возвращает значение наибольшего элемента в массиве. Неинициализированным аргументам присваиваются значения индексов этого элемента.  (on 11/3/2022)

// TODO-ENG: Write a program with a static method that takes a two-dimensional integer array as an argument. The method, in addition to the array argument, has two uninitialized arguments. As a result, the method returns the value of the largest element in the array. Uninitialized arguments are assigned the index values of that element. 

public class LargestValue2DArray
{
    private static void LargestValue(int[,] array, out int a, out int b)
    {
        a = 0;
        b = 0;
        var value = array[a, b];

        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] <= value) continue;
                value = array[i, j];
                a = i;
                b = j;
            }
        }
        Console.WriteLine($"Largest value of a two-dimensional array: {value}");
    }

    private static void Main()
    {
        int[,] array = { { 232, 180, 521, 50, 109 }, { 530, 269, 756, 124, 635 } };
        LargestValue(array, out var indexOne, out var indexTwo);
        Console.WriteLine($"Largest element index: {indexOne}, {indexTwo}");
    }
}