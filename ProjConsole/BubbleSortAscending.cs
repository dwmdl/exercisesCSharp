/*  
 * Создать массив. 
 * Заполнить массив случайными значениями 
 * Отсортировать массив в порядке убывания значений 
 */  
  
namespace ProjConsole;  
  
internal static class BubbleSortAscending  
{  
   private static void Main()  
   {      
			var rnd = new Random();			  
      var array = new int[rnd.Next(1, 29)];  
  
      Console.WriteLine("Array before sorting :");  
      for (var i = 0; i < array.Length; i++)  
      {         
				 array[i] = rnd.Next(0, 260);  
         Console.Write($"{array[i]}, ");  
      }  
  
      // ALGORITHM OF BUBBLE SORT  
      for (var i = 1; i < array.Length; i++)  
      for (var j = 0; j < array.Length - i; j++)  
      {  
         if (array[j] >= array[j + 1]) continue;  
         (array[j + 1], array[j]) = (array[j], array[j + 1]);  
      }  
  
      Console.WriteLine("\nArray after sorting : ");  
      foreach (int t in array) Console.Write($"{t}, ");  
   }  
}
