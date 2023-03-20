namespace exercisesCSharp.easy.classes_and_objects;

public class Entity
{
    private static int Number;
    private Entity() => Number = 0;
    private Entity(int n) => Number = n >= 100 ? 100 : n;
    
    public static void Method() => Number = 0;
    public static void Method(int n) => Number = n >= 100 ? 100 : n;

    // field value check
    public static void Show() => Console.WriteLine($"Field value : {Number}");

    static void Main()
    {
        Method();
        Show();
        Method(75);
        Show();
        Method(101);
        Show();

        Entity dummy = new Entity();
        Show();
        Entity dummy2 = new Entity(10);
        Show();
    }
}