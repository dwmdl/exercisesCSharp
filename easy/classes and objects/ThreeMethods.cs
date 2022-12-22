// TODO-ru : Напишите программу с классом, в котором есть закрытое символьное поле и три открытых метода. Один из методов позволяет присвоить значение полю. Еще один метод при вызове возвращает результатом код символа. Третий метод позволяет вывести в консольное окно символ(значение поля) и его код. (on 12/22/2022, 7:24pm)

// TODO-en : Write a program with a class that has a private character field and three public methods. One method allows you to assign a value to a field. Another method, when called, returns a character code as a result. The third method allows you to display the symbol (field value) and its code in the console window. (on 12/22/2022, 7:24pm)

namespace exercisesCSharp.easy.classes_and_objects;

class MyClass
{
    private char _symblslock;

    public char AssignValue(char x) => _symblslock = x;
    public void DisplayingValue(int code) => Console.WriteLine(code);
    public void MethodThree(char code) => Console.WriteLine($"Symbol : {code}, Code of symbol : {(int)(code)}");


    static void Main()
    {
        MyClass obj = new MyClass();
        char symbs = obj.AssignValue('C');
        obj.DisplayingValue(symbs);
        obj.MethodThree(symbs);
    }
}

