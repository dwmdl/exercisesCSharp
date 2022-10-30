namespace exercisesCSharp;

// TODO-RU: Написать статический метод, которому аргументом передается целочисленный массив и целое число. Результатом метод возвращает ссылку на новый массив, который получается из исходного массива, если в нем взять несколько начальных элементов. Кол-во элементов, которые нужно взять из исходного массива, определяется вторым аргументом метода. Если второй аргумент метода больше длины массива, то методом создается копия изходного массива и возвращается ссылка на эту копию.  (on 10/29/2022, 9:26AM)

// TODO-ENG: Write a static method that takes an integer array and an integer as an argument. As a result, the method returns a reference to a new array, which is obtained from the original array if several initial elements are taken from it. The number of elements to be taken from the original array is determined by the second argument of the method. If the second argument of the method is greater than the length of the array, then the method creates a copy of the original array and returns a reference to this copy. (on 10/29/2022, 9:26AM)

public class RandomArray
{
    private static void RandomArrayLength(int[] array, int amount)
    {
        var newArray = new int[amount];
        var random = new Random();

        if (amount > array.Length)
        {
            Console.WriteLine(
                $"The {amount} value is greater than the length of the array. Return the original array : ");
            foreach (var i in array) Console.Write($"{i}, ");
        }
        else
            for (var i = 0; i < amount; i++)
            {
                var secondIndex = random.Next(0, array.Length);
                newArray[i] = array[secondIndex];
                Console.Write($"{newArray[i]}, ");
            }
    }


    private static void Main()
    {
        int[] array = { 234, 312, 575, 680, 422, 12, 532, 123 };
        RandomArrayLength(array, 9);
    }
}