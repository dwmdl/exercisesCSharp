// TODO-ru : Напишите программу с классом, у которого есть два символьных поля и метод. Он не возвращает результат, и у него нет аргументов. При вызове метод выводит в консольное окно все символы из кодовой таблицы, которые находятся между символами, являющимися значениями полей объекта (из которого вызывается метод). Например, если полям объекта присвоены значения ' А ' и ' D ' , то при вызове метода в консольное окно должны выводиться все символы от ' А ' до ' D ' включительно. (on 12/22/2022, 8:36pm)

// TODO-en : Write a program with a class that has two character fields and a method. It does not return a result and it has no arguments. When called, the method prints to the console window all the characters from the code table that are between the characters that are the values of the fields of the object (from which the method is called). For example, if the object fields are assigned the values 'A' and 'D', then when the method is called, all characters from 'A' to 'D' inclusive should be displayed in the console window. (on 12/22/2022, 8:36pm)

namespace exercisesCSharp.easy.classes_and_objects;

public class CodeSequence
{
    private char _fieldOne;
    private char _fieldTwo;

    private void Method()
    {
        for (var i = _fieldOne + 1; i < _fieldTwo; i++) 
            Console.Write($"{i},");
    }
    
    static void Main()
    {
        CodeSequence obj = new CodeSequence();
        Console.WriteLine("Enter two any character from A to Z");
        obj._fieldOne = char.Parse(Console.ReadLine()!);
        obj._fieldTwo = char.Parse(Console.ReadLine()!);
        obj.Method();
    }
}