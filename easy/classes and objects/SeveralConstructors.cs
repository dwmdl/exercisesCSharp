// TODO-ru : Напишите программу с классом, у которого есть два целочисленных поля. В классе должны быть описаны конструкторы, позволяющие создавать объекты без передачи аргументов, с передачей одного аргумента и с передачей двух аргументов (on 12/22/2022)

// TODO-en : Write a program with a class that has two integer fields. The class must contain constructors that allow you to create objects without passing arguments, passing one argument, and passing two arguments. (on 12/22/2022)

namespace exercisesCSharp.easy.classes_and_objects;

public class Project
{
    private int _firstField = 1;
    private int _secondField = 2;

    public Project() => Console.WriteLine($"Value of fields : {_firstField} and {_secondField}");
    public Project(int n) => Console.WriteLine($"Value of fields : {_firstField = n} and {_secondField}");
    public Project(int x, int n) => Console.WriteLine($"Value of fields : {_firstField = x} and {_secondField = n}");
}


class MyClass
{
    static void Main()
    {
        Console.WriteLine($"Initially the fields have values 1 and 2\n");
        Console.WriteLine("Constructor without arguments.");
        Project a = new Project();
        Console.WriteLine("Constructor with one argument.");
        Project b = new Project(438);
        Console.WriteLine("Constructor with two arguments.");
        Project c = new Project(707, 814);
    }
}